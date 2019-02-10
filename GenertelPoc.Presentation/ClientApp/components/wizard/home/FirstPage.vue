<template>
  <div>
    {{this.pageId}}
    <text-input v-model="fullName"></text-input>
  </div>
</template>

<script>
import TextInput from "../inputs/TextInput.vue";

export default {
  name: "first-page",
  components: {
    TextInput
  },
  data() {
    return {
      fullName: ""
    };
  },
  props: {
    pageId: {
      type: Number,
      required: true
    }
  },
  beforeDestroy() {
    console.log("first");
    const fullName = this.fullName;
    const pageId = this.pageId;
    const pageState = { fullName };
    this.$store.commit("offer/setPageState", { pageState, pageId });
  },
  methods: {}
};
</script>

<style>
</style>
