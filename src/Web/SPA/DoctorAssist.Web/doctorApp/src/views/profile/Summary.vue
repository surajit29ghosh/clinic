<template>
	<div>
		<h3>Summary</h3>

		<div class="tile is-ancestor">
			<div class="tile is-parent is-vertical">
				<div class="tile is-child notification is-info is-9">
					<p class="title">Summary</p>
					<p>{{profileId}}</p>
				</div>

				<div v-for="item in forms.form" class="card is-fullwidth">
					<header class="card-header">
						<p class="card-header-title">{{item.formName}}</p>
						<a class="card-header-icon card-toggle" @click="[current === item.formName ? current='' : current=item.formName ]">
							<i :class="[current === item.formName ? 'fa fa-angle-double-up' : 'fa fa-angle-double-down' ]"></i>
						</a>
					</header>
					<div :class="[ current === item.formName ? 'card-content' : 'card-content is-hidden']">
						<div class="content">
							<DynamicForm :schema="item.formSchema"></DynamicForm>
						</div>
					</div>
					<footer :class="[ current === item.formName ? 'card-footer' : 'card-footer is-hidden']">
						<p class="card-footer-item">

						</p>
						<p class="card-footer-item buttons">
							<a href="#" class="button is-success">
								<span>Save</span>
								<span class="icon is-small">
									<i class="fa fa-check"></i>
								</span>
							</a>
							<a href="#" class="button is-danger">
								<span>Discard</span>
								<span class="icon is-small">
									<i class="fa fa-times"></i>
								</span>
							</a>
						</p>

					</footer>
				</div>

			</div>
		</div>
	</div>
</template>

<script>
	import DynamicForm from '../../components/DynamicForm.vue'
	export default {
		components: {
			DynamicForm
		},
		data() {
			return {
				current: ''
			}
		},
		computed: {
			profileId() {
				return this.$route.query.pid;
			},
			forms() {
				return {
					form: [
						{
							formName: "Basic Details",
							formId: "00000-00000-00000-00000-00000",
							editInSummary: "1",
							formSchema:
							{
								fields: [
									{
                                        type: 'text-input',
                                        id: '1',
										name: 'first_name',
										label: 'First name',
										placeholder: 'Enter first name',
                                        style: "input",
                                        data: "Surajit"
									},
									{
                                        type: 'text-input',
                                        id: '2',
										name: 'last_name',
										label: 'Last name',
										placeholder: 'Enter last name',
                                        style: "input",
                                        data: "Doe"
									},
									{
                                        type: 'password-input',
                                        id: '3',
										name: 'user_pwd',
										label: 'Password',
                                        style: "input",
                                        data: ""
									},
									{
                                        type: 'select-input',
                                        id: '4',
										name: 'user_gender',
										label: 'Gender',
										options: ['Male', 'Female'],
                                        style: "select",
                                        data: "Male"
									},
									{
                                        type: "date-input",
                                        id: '5',
										name: "birth_date",
										label: "Date of Birth",
                                        style: "input",
                                        data: "2011-01-02"
									},
									{
                                        type: "number-input",
                                        id: '6',
										name: "user_age",
										label: "Age (in months)",
										min: "0",
										max: "100",
                                        style: "input",
                                        data: "50"
									},
									{
                                        type: "range-input",
                                        id: '7',
										name: "user_report",
										label: "Report",
										min: "1",
										max: "10",
                                        style: "input",
                                        data: "5"
									},
									{
                                        type: "text-area",
                                        id: '8',
										name: "prev_history",
										label: "Previous History",
                                        style: "textarea",
                                        data: "to enter"
									}
								]
							}
						}
					]
				}
			}
		},
		created() {
			//console.log(this.profileId);
			//console.log(JSON.stringify(this.forms));
		},
		mounted() {
			this.$http.post('api/patient/get', { "doctorId": this.$user.associationId, "clientId": this.profileId })
				.then(response => {
					console.log(response.data);
					this.searchList = response.data;
				})
				.catch((error) => {
					console.log(error);
				});
		}
	}

</script>
