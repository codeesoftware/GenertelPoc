<template>
  <div>
    <text-input></text-input>
    <button class="btn btn-primary" @click="back()">Tovább</button>
    <button class="btn btn-primary" @click="next()">Tovább</button>
  </div>
</template>

<script>
import TextInput from "../inputs/TextInput.vue";

export default {
  props: {
    pageId: {
      type: Number,
      required: true
    }
  },
  name: "home-first-page",
  components: {
    TextInput
  },
  created() {
    console.log(this.pageId);
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
