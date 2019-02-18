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

    <block :label="pageViewModel.password.label" name="password">
      <input
        slot="body"
        type="password"
        v-validate.continues.initial="pageViewModel.password.validationsString"
        name="password"
        class="form-control"
        v-model.trim="pageViewModel.password.value"
      >
      <error :errors="errors.collect('password')"></error>
    </block>

    <block :label="pageViewModel.passwordConfirmation.label" name="passwordConfirmation">
      <input
        slot="body"
        type="password"
        v-validate.continues.initial="pageViewModel.passwordConfirmation.validationsString"
        name="passwordConfirmation"
        class="form-control"
        ref="passwordConfirmation"
      >
      <error :errors="errors.collect('passwordConfirmation')"></error>
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
  computed: {
    pageViewModel() {
      let currentPageViewModel = this.viewModel.pages.find(
        p => p.pageId === this.currentPageId
      );
      return currentPageViewModel;
    }
  },
  data() {
    return {};
  },
  props: {
    viewModel: {
      type: Object,
      required: true
    },
    currentPageId: {
      type: Number,
      required: true
    },
     validator: function (value) {
        return 0 < value;
      }
  }
};
</script>

<style>
</style>
