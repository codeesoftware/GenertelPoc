<template>
  <div>
    <own-input v-model="pageViewModel.email.value" :property="pageViewModel.email"></own-input>
    <own-input
      v-model="pageViewModel.password.value"
      :property="pageViewModel.password"
      name="password"
      ref="password"
    ></own-input>
    {{errors}}
  </div>
</template>

<script>
import Input from "../controls/Input.vue";

export default {
  name: "second-page",
  data() {
    return {};
  },
  components: {
    OwnInput: Input
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
