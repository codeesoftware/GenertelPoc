<template>
  <div>
    {{this.page}}
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
    page: {
      type: Number,
      required: true
    }
  },
  beforeDestroy() {
    console.log("leave");
    const fullName = this.fullName;
    this.$store.commit("offer/setPageState", { fullName }, 1);
  },
  methods: {}
};
</script>

<style>
</style>
