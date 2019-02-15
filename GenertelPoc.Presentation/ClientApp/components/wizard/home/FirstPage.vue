<template>
  <div class="form-group">
    <label for="fullName">{{pageViewModel.fullName.label}}</label>
    <input
      type="text"
      v-validate.continues.initial="pageViewModel.fullName.validationsString"
      name="fullName"
      class="form-control"
      v-model="pageViewModel.fullName.value"
    >
    <error :errors="errors.collect('fullName')"></error>

    <label for="age">{{pageViewModel.age.label}}</label>
    <input
      type="text"
      v-validate.continues.initial="pageViewModel.age.validationsString"
      name="age"
      class="form-control"
      v-model="pageViewModel.age.value"
    >
    <error :errors="errors.collect('age')"></error>

    <label for="damage">{{pageViewModel.damage.label}}</label>
    <select
      name="damage"
      v-model="pageViewModel.damage.value"
      class="form-control"
      v-validate.continues.initial="pageViewModel.damage.validationsString"
    >
      <option
        v-for="option in pageViewModel.damage.options.$values"
        :key="option"
        :value="option"
      >{{ option }}</option>
    </select>
    <error :errors="errors.collect('damage')"></error>
    <!-- <input :property="pageViewModel.age"></wn-input> -->
    <!-- <dropdown :property="pageViewModel.damage"></wn-dropdown> -->
  </div>
</template>

<script>
import Error from "../controls/Error.vue";

export default {
  name: "first-page",
  components: {
    Error
  },
data(){
  return{

  }
},
  props: {
    pageViewModel: {
      type: Object,
      required: true
    }
  }
};
</script>

<style>
</style>
