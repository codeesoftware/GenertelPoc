<template>
  <div>
    {{this.page}}
    <email-input></email-input>
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
    page: {
      type: Number,
      required: true
    }
  },
  methods: {}
};
</script>

<style>
</style>
