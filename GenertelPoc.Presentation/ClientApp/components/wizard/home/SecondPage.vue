<template>
  <div>
    <own-input
      v-model="pageViewModel.password.value"
      :property="pageViewModel.password"
      v-validate="'confirmed:confirmation'"
    ></own-input>
    <input v-model="password_confirm" type="password" ref="confirmation">
  </div>
</template>

<script>
import Input from "../controls/Input.vue";

export default {
  name: "second-page",
  data() {
    return {
      password: "123",
      password_confirm: ""
    };
  },
  components: {
    OwnInput: Input
  },
  props: {
    pageViewModel: {
      type: Object,
      required: true
    }
  },
  computed: {}
};
</script>

<style>
</style>
