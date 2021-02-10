<template>
    <div id="app">
        <nav class="navbar is-primary shadow" role="navigation" aria-label="main navigation">
            <div class="navbar-brand">
                <a class="navbar-item" href="#">
                    <img src="{{this.$user.logo}}" width="112" height="28" />
                    {{this.$user.userName}} - {{this.$user.userRole}}
                </a>

                <a role="button" class="navbar-burger burger" aria-label="menu" aria-expanded="false" data-target="navbarMain">
                    <span aria-hidden="true"></span>
                    <span aria-hidden="true"></span>
                    <span aria-hidden="true"></span>
                </a>
            </div>

            <div id="navbarMain" class="navbar-menu">
                <div class="navbar-start">
                    <router-link to="/" class="navbar-item">Home</router-link>
                    <router-link to="/clients" class="navbar-item">Clients</router-link>
                </div>

                <div class="navbar-end">
                    <div class="navbar-item has-dropdown is-hoverable">
                        <a class="navbar-link">
                            Manage
                        </a>
                        <div class="navbar-dropdown">
                            <router-link to="/manage/forms" class="navbar-item">Forms</router-link>
                        </div>
                    </div>

                    <div class="navbar-item">
                        <div class="buttons">
                            <a class="button is-dark" v-on:click="logOut()">
                                Log out
                            </a>
                        </div>
                    </div>
                </div>
            </div>
        </nav>

        <router-view />
    </div>
</template>
