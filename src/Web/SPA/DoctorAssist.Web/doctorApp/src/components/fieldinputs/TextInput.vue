<template>
    <div class="form-control">
    <label>{{ field.label }}</label>
    <input v-bind:class="field.style" type="text" :placeholder="field.placeholder" v-model="data">
  </div>
</template>

<script lang="ts">
import { Component, Prop, Vue } from 'vue-property-decorator';

@Component
export default class TextInput extends Vue{
    @Prop() private field!: {};
    @Prop() private data!: {}
}
</script>
