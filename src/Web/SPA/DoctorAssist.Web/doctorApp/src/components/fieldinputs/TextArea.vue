<template>
    <div class="form-control">
    <label>{{ field.label }}</label>
    <textarea class="textarea" v-model="data">
    </textarea>
  </div>
</template>

<script lang="ts">
import { Component, Prop, Vue } from 'vue-property-decorator';

@Component
export default class TextArea extends Vue{
    @Prop() private field!: {};
    @Prop() private data!: {}
}
</script>
