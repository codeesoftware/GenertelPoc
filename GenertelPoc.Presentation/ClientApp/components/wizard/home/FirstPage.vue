<template>
  <div>
    <text-input
      v-model="pageViewModel.fullName.value"
      :validations="Concat(pageViewModel.fullName.validations.$values)"
    ></text-input>
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

  mounted() {
    console.log("mounted"); // {x:1}
    console.log(this.pageViewModel); // {x:1}
  },
  methods: {
    Concat(list) {
      console.log("Concat");
      console.log(list);
      return _.join(list, "|");
    }
  }
};
</script>

<style>
</style>
