<template>
  <div>
    <text-input v-model="pageViewModel.fullName.value" :property="pageViewModel.fullName"></text-input>
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
  },

  methods: {
    Concat(list) {
      return _.join(list, "|");
    }
  }
};
</script>

<style>
</style>
