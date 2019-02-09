<template>
  <div>
    <h3>{{this.$route.params.id }}</h3>
    <home-first-page :pageId="1"></home-first-page>
    <home-second-page :pageId="2"></home-second-page>
  </div>
</template>

<script>
import HomeFirstPage from "./HomeFirstPage.vue";
import HomeSecondPage from "./HomeSecondPage.vue";

export default {
  name: "home-wizard",
  components: {
    HomeFirstPage
  }
};
</script>

<style>
</style>
