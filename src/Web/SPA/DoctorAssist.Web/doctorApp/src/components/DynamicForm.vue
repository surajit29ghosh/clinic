<template>
<div class="VueForm">
    <template v-for="field in schema.fields">
      <component :is="field.type" :field="field" :data.sync="field.data"></component>
    </template>
  </div>
  </template>

  <script lang="ts">
  import {Vue, Component, Prop} from 'vue-property-decorator';
  import TextInput from '@/components/fieldinputs/TextInput.vue';
  import PasswordInput from '@/components/fieldinputs/PasswordInput.vue';
  import SelectInput from '@/components/fieldinputs/SelectInput.vue';
  import DateInput from '@/components/fieldinputs/DateInput.vue';
  import NumberInput from '@/components/fieldinputs/NumberInput.vue';
  import TextArea from '@/components/fieldinputs/TextArea.vue'
  import RangeInput from '@/components/fieldinputs/RangeInput.vue'
  
  @Component({
      components: {
          TextInput,
          PasswordInput,
          SelectInput,
          DateInput,
          NumberInput,
          RangeInput,
          TextArea
      }
  })
  export default class VueForm extends Vue{
      @Prop() schema!: {};



      constructor()
      {
          super();
		  //console.log(JSON.stringify(this.schema));
		  //console.log(JSON.stringify(this.data));
      }
  }
  
  </script>
  