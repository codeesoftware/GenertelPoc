<template>
  <div>
    <own-input :property="pageViewModel.password" v-validate="'confirmed:confirmation'"></own-input>
    <own-input :property="pageViewModel.password" type="password" ref="confirmation"></own-input>
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
