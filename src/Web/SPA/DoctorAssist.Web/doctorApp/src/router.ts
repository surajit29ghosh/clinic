import Vue from 'vue'
import Router from 'vue-router'
import Home from './views/Home.vue'

Vue.use(Router)

export default new Router({
    mode: 'history',
    base: process.env.BASE_URL,
    routes: [
        {
            path: '/',
            name: 'home',
            component: Home
        },
        {
            path: '/Doctor/Home',
            redirect: '/'
        },
        {
            path: '/clients',
            name: 'clients',
            component: () => import(/* webpackChunkName: "about" */ './views/Clients.vue')
        },
        {
            path: '/profile',
            component: () => import(/* webpackChunkName: "profile" */ './views/Profile.vue'),
            children: [
                {
                    path: '',
                    name: 'profile',
                    component: () => import('./views/profile/Summary.vue')
                },
                {
                    path: 'details',
                    name: 'patient-details',
                    component: () => import(/* webpackChunkName: "profile.details" */ './views/profile/Details.vue')
                },
                {
                    path: 'docs',
                    name: 'patient-docs',
                    component: () => import(/* webpackChunkName: "profile.docs" */ './views/profile/Docs.vue')
                }
            ]
        },
        {
            path: '/manage',
            component: () => import(/* webpackChunkName: "manage" */ './views/Manage.vue'),
            children: [
                {
                    path: 'forms',
                    name: 'manage-forms',
                    component: () => import(/* webpackChunkName: "manage" */ './views/Manage/Forms.vue')
                }
            ]
        }
    ]
})
