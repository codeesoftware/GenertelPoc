<template>
  <div>
    <email-input v-model="email"></email-input>
  </div>
</template>

<script>
import EmailInput from "../inputs/EmailInput.vue";

export default {
  name: "second-page",
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
    console.log("second");
    const pageId = this.pageId;
    const email = this.email;
    const pageState = { email };
    this.$store.commit("offer/setPageState", { pageState, pageId });
  }
};
</script>

<style>
</style>
