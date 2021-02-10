<template>
    <div class="form-control">
    <label>{{ field.label }}</label>
	<div v-bind:class="field.style">
		<select v-model="data">
			<template v-for="option in field.options">
				<option>{{option}}</option>
			</template>
		</select>
	</div>
  </div>
</template>

<script lang="ts">
import { Component, Prop, Vue } from 'vue-property-decorator';

@Component
export default class SelectInput extends Vue{
    @Prop() private field!: {};
    @Prop() private data!: {}
}
</script>
