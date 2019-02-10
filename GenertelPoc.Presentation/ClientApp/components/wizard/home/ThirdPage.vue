<template>
  <div>
    <email-input v-model="email"></email-input>
  </div>
</template>

<script>
import EmailInput from "../inputs/EmailInput.vue";

export default {
  name: "third-page",
  data() {
    return {
      email: ""
    };
  },
  components: {
    EmailInput
  },
  props: {
    pageId: {
      type: Number,
      required: true
    }
  },
  methods: {},
  beforeDestroy() {
    const email = this.email;
    const pageId = this.pageId;
    this.$store.commit("offer/setPageState", { email, pageId });
  }
};
</script>

<style>
</style>
