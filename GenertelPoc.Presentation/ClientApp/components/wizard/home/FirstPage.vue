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
  beforeRouteLeave(to, from, next) {
    const data = this.fullName;
    this.$store.commit("offer/setPageState", { data }, this.page - 1);
  },
  methods: {}
};
</script>

<style>
</style>
