<template>
  <div>
    {{errors}}
    <!-- <own-input v-model="pageViewModel.email.value" :property="pageViewModel.email"></own-input> -->
    <own-input
      v-model="pageViewModel.password.value"
      :property="pageViewModel.password"
      v-validate="'confirmed:confirmation'"
    ></own-input>
    <!-- <input v-model="password" v-validate="'isBigger:confirmation'" type="password"> -->
    <input v-model="password_confirm" name="password_confirm" type="password" ref="confirmation">
    <!-- <span v-show="fields.password_conf && fields.password_conf.valid">I'm valid</span> -->
    {{isPasswordConfirmed}}
  </div>
</template>

<script>
import Input from "../controls/Input.vue";
import { ErrorBag } from "vee-validate";

const bag = new ErrorBag();

// For example, you may want to add an error related to authentication:

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
  computed: {
    isPasswordConfirmed() {
      console.log(this.$refs);
      return this.password_confirm == this.pageViewModel.password.value;
    }
  }
};
</script>

<style>
</style>
