<template>
  <div>
    <own-input v-model="pageViewModel.fullName.value" :property="pageViewModel.fullName"></own-input>
    <own-input v-model="pageViewModel.age.value" :property="pageViewModel.age"></own-input>
  </div>
</template>

<script>
import Input from "../controls/Input.vue";

export default {
  name: "first-page",
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
