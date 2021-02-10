<template>
    <div class="section">
        <h1 class="title is-primary">Clients</h1>
        <div class="container">
            <div class="columns">
                <aside class="column is-2 aside hero">
                    <div>
                        <div class="compose has-text-centered">
                            <h3 class="button is-danger is-block is-bold">
                                <span class="compose">Actions</span>
                            </h3>
                        </div>
                        <div class="main">
                            <router-link class="item" :to="{name: 'profile', query:{pid: profileId}}">Summary</router-link>
                            <router-link class="item" :to="{name: 'patient-details', query:{pid: profileId }}">Information</router-link>
                            <router-link class="item" :to="{name: 'patient-docs', query:{pid: profileId }}">Documents</router-link>
                        </div>
                    </div>
                </aside>
                <div class="column is-main-content">
                    <router-view></router-view>
                </div>
            </div>
        </div>
    </div>

</template>

<script>
    export default {
        computed: {
            profileId() {
                return this.$route.query.pid;
            }
        },
        created() {
            console.log(this.profileId);
        }
    }

</script>
