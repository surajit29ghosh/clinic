<template>
	<p class="title">{{this.form.formName}}</p>
	<div>
		<DynamicForm :schema="this.form.formSchema" :data="this.form.formData"></DynamicForm>
	</div>
</template>

<script>
	import DynamicForm from '../components/DynamicForm.vue'

	export default {
		components: {
			DynamicForm
		},
		props: ['form'],
		
		created() {
			console.log(JSON.stringify(this.form));
		}
	}
</script>