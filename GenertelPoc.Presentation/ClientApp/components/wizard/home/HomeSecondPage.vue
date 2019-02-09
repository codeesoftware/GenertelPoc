<template>
  <div>
    <email-input></email-input>
  </div>
</template>

<script>
import EmailInput from "../inputs/EmailInput.vue";

export default {
  // props: {
  //   pageId: {
  //     type: Number,
  //     required: true
  //   }
  // },
  name: "home-second-page",
  components: {
    EmailInput
  },
  methods: {
    back() {
      this.$router.push(`/home/1`);
    },
    next() {
      this.$router.push(`/home/3`);
    }
  }
};
</script>

<style>
</style>
