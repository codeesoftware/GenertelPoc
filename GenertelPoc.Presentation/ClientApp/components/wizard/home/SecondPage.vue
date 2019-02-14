<template>
  <div>
    <email-input v-model="pageViewModel.email"></email-input>
  </div>
</template>

<script>
import EmailInput from "../inputs/EmailInput.vue";

export default {
  name: "second-page",

  components: {
    EmailInput
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
