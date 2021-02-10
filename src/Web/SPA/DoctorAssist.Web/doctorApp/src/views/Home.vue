<template>
    <section class="section">
        <div class="container">
            <h1 class="title is-primary">Section</h1>
            <arti class="tile is-ancestor">
                <article class="tile is-child box is-5">
                    <p class="title">Today...</p>
                    <p></p>
                </article>
                <article class="tile is-child box is-5">
                    <p class="title">Search</p>
                    <p></p>
                </article>
            </arti>
        </div>
    </section>
</template>

<script lang="ts">
import { Vue } from 'vue-property-decorator';

export default class Home extends Vue {}
</script>
