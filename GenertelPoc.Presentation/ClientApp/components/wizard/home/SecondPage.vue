<template>
  <div>
    <own-input v-model="pageViewModel.password.value" :property="pageViewModel.password"></own-input>
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
  }
};
</script>

<style>
</style>
