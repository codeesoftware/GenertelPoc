<template>
  <div class="form-group">
    <label for="email">{{pageViewModel.email.label}}</label>
    <input
      type="text"
      v-validate.continues.initial="pageViewModel.email.validationsString"
      name="email"
      class="form-control"
      v-model="pageViewModel.email.value"
    >
    <error :errors="errors.collect('email')"></error>

    <label for="password">{{pageViewModel.password.label}}</label>
    <input
      type="text"
      v-validate.continues.initial="pageViewModel.password.validationsString+'|confirmed:confirmation'"
      name="password"
      class="form-control"
      v-model="pageViewModel.password.value"
    >
    <error :errors="errors.collect('password')"></error>

    <label for="password_confirmation">{{pageViewModel.password.label}} 1x</label>
    <input
      type="text"
      v-validate.continues.initial="pageViewModel.password.validationsString"
      name="password_confirmation"
      class="form-control"
      ref="confirmation"
    >
    <error :errors="errors.collect('password_confirmation')"></error>
  </div>
</template>

<script>
import Error from "../controls/Error.vue";

export default {
  name: "second-page",
  components: {
    Error
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
