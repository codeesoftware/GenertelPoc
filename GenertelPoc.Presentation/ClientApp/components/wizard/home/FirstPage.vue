<template>
  <div>
    <text-input v-model="pageViewModel.fullName.value" :property="pageViewModel.fullName"></text-input>
    <text-input v-model="pageViewModel.age.value" :property="pageViewModel.age"></text-input>
  </div>
</template>

<script>
import TextInput from "../inputs/TextInput.vue";

export default {
  name: "first-page",
  components: {
    TextInput
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
