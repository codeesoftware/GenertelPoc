<template>
  <div class="form-group">
    <block :label="pageViewModel.fullName.label" name="fullName">
      <input
        id="fullName"
        slot="body"
        type="text"
        v-validate.continues.initial="pageViewModel.fullName.validationsString"
        name="fullName"
        class="form-control"
        v-model.trim="pageViewModel.fullName.value"
      >
      <error :errors="errors.collect('fullName')"></error>
    </block>

    <block :label="pageViewModel.age.label" name="age">
      <input
        id="age"
        slot="body"
        type="text"
        v-validate.continues.initial="pageViewModel.age.validationsString"
        name="age"
        class="form-control"
        v-model.trim="pageViewModel.age.value"
      >
      <error :errors="errors.collect('age')"></error>
    </block>

    <block :label="pageViewModel.damage.label" name="damage">
      <select
        slot="body"
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
    </block>
  </div>
</template>

<script>
import Error from "../controls/Error.vue";
import Block from "../controls/Block.vue";
import CommonPage from "../common/CommonPage.vue";

export default {
  name: "first-page",

  components: {
    Error,
    Block
  },
  extends: CommonPage,
  data() {
    return {};
  }
};
</script>

<style>
</style>
