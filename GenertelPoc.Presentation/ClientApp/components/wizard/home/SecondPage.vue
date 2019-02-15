<template>
  <div class="form-group">
    <block :label="pageViewModel.email.label" name="email">
      <input
        slot="body"
        type="text"
        v-validate.continues.initial="pageViewModel.email.validationsString"
        name="email"
        class="form-control"
        v-model.lazy.trim="pageViewModel.email.value"
      >
      <error :errors="errors.collect('email')"></error>
    </block>

    <block :label="pageViewModel.password.label" name="password_confirmation">
      <input
        slot="body"
        type="password"
        v-validate.continues.initial="pageViewModel.password.validationsString"
        name="password_confirmation"
        class="form-control"
        ref="confirmation"
      >
      <error :errors="errors.collect('password_confirmation')"></error>
    </block>

    <block :label="pageViewModel.password.label+' ismét'" name="password">
      <input
        slot="body"
        type="password"
        v-validate.continues.initial="pageViewModel.password.validationsString+'|VAL_300:confirmation'"
        name="password"
        class="form-control"
        v-model.trim="pageViewModel.password.value"
      >
      <error :errors="errors.collect('password')"></error>
    </block>
  </div>
</template>

<script>
import Error from "../controls/Error.vue";
import Block from "../controls/Block.vue";

export default {
  name: "second-page",
  components: {
    Error,
    Block
  },
  data() {
    return {};
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
