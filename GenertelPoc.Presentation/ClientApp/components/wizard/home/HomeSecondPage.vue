<template>
  <div>
    <email-input></email-input>
    <button class="btn btn-primary" @click="back()">Tovább</button>
    <button class="btn btn-primary" @click="next()">Tovább</button>
  </div>
</template>

<script>
import EmailInput from "../inputs/EmailInput.vue";

export default {
  props: {
    pageId: {
      type: Number,
      required: true
    }
  },
  name: "home-second-page",
  components: {
    EmailInput
  },
  methods: {
    back() {
      this.$router.push(`/home/${this.pageId - 1}`);
    },
    next() {
      this.$router.push(`/home/${this.pageId + 1}`);
    }
  }
};
</script>

<style>
</style>
