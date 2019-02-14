<template>
  <div>
    <own-input v-model="pageViewModel.email.value" :property="pageViewModel.email"></own-input>
  </div>
</template>

<script>
import Input from "../controls/Input.vue";

export default {
  name: "second-page",

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
