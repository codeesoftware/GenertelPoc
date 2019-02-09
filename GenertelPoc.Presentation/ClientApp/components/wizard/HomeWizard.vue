<template>
  <div>
    <text-input></text-input>
    <email-input></email-input>
  </div>
</template>

<script>
import TextInput from "./inputs/TextInput.vue";
import EmailInput from "./inputs/EmailInput.vue";

export default {
  name: "home-wizard",
  components: {
    TextInput,
    EmailInput
  }
};
</script>

<style>
</style>
