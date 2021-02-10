<template>
	<section class="section">
		<div class="container column is-10">
			<div class="section">
				<h1 class="title is-primary">Clients</h1>

				<div class="card">
					<div class="card-header">
						<p class="card-header-title">Search</p>
					</div>
					<div class="card-content">
						<div class="field has-addons">
							<div class="control has-icons-left has-icons-right is-expanded">
								<input class="input" type="text" placeholder="type any value and hit enter to search..." v-on:keyup.enter="search()" v-model="term">
								<a class="icon is-small is-left">
									<i class="fa fa-search"></i>
								</a>
							</div>
							<p class="control">
								<a class="button is-info" v-on:click="search">Search</a>
							</p>
						</div>
						<table class="table is-bordered">
							<thead>
								<tr>
									<th>Name</th>
									<th>Email</th>
									<th>Phone</th>
									<th>Select</th>
								</tr>
							</thead>
							<tbody>
								<tr v-for="item in searchList">
									<td>{{item.patientName}}</td>
									<td>{{item.email}}</td>
									<td>{{item.phone}}</td>
									<td><router-link :to="{name: 'profile', query:{pid: item.patientId}}">Select</router-link></td>
								</tr>
							</tbody>
						</table>
					</div>
				</div>

				<div class="card">
					<div class="card-header">
						<p class="card-header-title">Quick Access</p>
					</div>
					<div class="card-content">
						<div class="tabs">
							<ul>
								<li :class="[ current === 'upcoming' ? 'is-active' : '']">
									<a @click="current='upcoming'">Upcoming</a>
								</li>
								<li :class="[ current === 'frequent' ? 'is-active' : '']">
									<a @click="current='frequent'">Frequent</a>
								</li>
								<li :class="[ current === 'recent' ? 'is-active' : '']">
									<a @click="current='recent'">Recent</a>
								</li>
							</ul>
						</div>
						<div :class="[ current === 'upcoming' ? 'box is-active-upcoming' : 'box in-active-upcoming']">
							<h3>Upcoming</h3>
							<table class="table is-bordered">
								<thead>
									<tr>
										<th>Name</th>
										<th>Email</th>
										<th>Phone</th>
										<th>Scheduled On</th>
										<th>Select</th>
									</tr>
								</thead>
								<tbody>
									<tr v-for="item in upcomingList">
										<td>{{item.patientName}}</td>
										<td>{{item.email}}</td>
										<td>{{item.phone}}</td>
										<td>{{item.formattedDate}} {{item.visitTime}}</td>
										<td><router-link :to="{name: 'profile', query:{pid: item.patientId}}">Select</router-link></td>
									</tr>
								</tbody>
							</table>
						</div>
						<div :class="[ current === 'frequent' ? 'box is-active-frequent' : 'box in-active-frequent']">
							<h3>Frequent</h3>
							<table class="table is-bordered">
								<thead>
									<tr>
										<th>Name</th>
										<th>Email</th>
										<th>Phone</th>
										<th>Select</th>
									</tr>
								</thead>
								<tbody>
									<tr v-for="item in frequentList">
										<td>{{item.patientName}}</td>
										<td>{{item.email}}</td>
										<td>{{item.phone}}</td>
										<td><router-link :to="{name: 'profile', query:{pid: item.patientId}}">Select</router-link></td>
									</tr>
								</tbody>
							</table>
						</div>
						<div :class="[ current === 'recent' ? 'box is-active-recent' : 'box in-active-recent']">
							<h3>Recent</h3>
							<table class="table is-bordered">
								<thead>
									<tr>
										<th>Name</th>
										<th>Email</th>
										<th>Phone</th>
										<th>Last visited</th>
										<th>Select</th>
									</tr>
								</thead>
								<tbody>
									<tr v-for="item in recentList">
										<td>{{item.patientName}}</td>
										<td>{{item.email}}</td>
										<td>{{item.phone}}</td>
										<td>{{item.formattedDate}} {{item.visitTime}}</td>
										<td><router-link :to="{name: 'profile', query:{pid: item.patientId}}">Select</router-link></td>
									</tr>
								</tbody>
							</table>
						</div>

					</div>
				</div>
			</div>
		</div>
	</section>
</template>

<style>
	.is-active-upcoming {
		display: block;
	}

	.in-active-upcoming {
		display: none;
	}

	.is-active-frequent {
		display: block;
	}

	.in-active-frequent {
		display: none;
	}

	.is-active-recent {
		display: block;
	}

	.in-active-recent {
		display: none;
	}
</style>

<script>
	import Router from '../router';

	export default {
		data: function () {
			return {
				current: 'upcoming',
				term: '',
				searchList: [],
				upcomingList: [],
				frequentList: [],
				recentList: []
			}
		},
		mounted() {
			this.$http.post('api/patient/all', { "doctorId": this.$user.associationId })
				.then(response => {
					console.log(response.data);
					this.searchList = response.data;
				})
				.catch((error) => {
					console.log(error);
				});

			this.$http.post('api/patient/upcoming', { "doctorId": this.$user.associationId })
				.then(response => {
					console.log(response.data);
					this.upcomingList = response.data;
				})
				.catch((error) => {
					console.log(error);
				});

			this.$http.post('api/patient/frequent', { "doctorId": this.$user.associationId })
				.then(response => {
					console.log(response.data);
					this.frequentList = response.data;
				})
				.catch((error) => {
					console.log(error);
				});

			this.$http.post('api/patient/recent', { "doctorId": this.$user.associationId })
				.then(response => {
					console.log(response.data);
					this.recentList = response.data;
				})
				.catch((error) => {
					console.log(error);
				});
		},
		methods: {
			load(id) {
				sessionStorage.setItem('profileId', 'patient');
				this.$router.push({ name: 'profile', query: { pid: sessionStorage.getItem('profileId') } })
			},
			search() {
				this.$http.post('api/patient/search', { "doctorId": this.$user.associationId, "term": this.term })
					.then(response => {
						console.log(response.data);
						this.searchList = response.data;
					})
					.catch((error) => {
						console.log(error);
					});
			}
		}

	}
</script>

