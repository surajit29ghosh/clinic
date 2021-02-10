<template>
    <div class="form-control">
    <label>{{ field.label }}</label>
    <input v-bind:class="field.style" type="number" :min="field.minvalue" :max="field.maxvalue" v-model="data">
  </div>
</template>

<script lang="ts">
import { Component, Prop, Vue } from 'vue-property-decorator';

@Component
export default class NumberInput extends Vue{
    @Prop() private field!: {};
    @Prop() private data!: {}
}
</script>
