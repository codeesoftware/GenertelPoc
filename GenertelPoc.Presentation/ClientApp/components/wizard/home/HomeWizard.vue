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
import Axios from "axios";

export default {
  name: "home-wizard",
  components: {
    HomeFirstPage,
    HomeSecondPage
  },
  data() {
    return {
      wizardVM: null
    };
  },
  methods: {
    setWizardVM(wizardVM) {
      debugger;
      this.wizardVM = wizardVM;
    }
  },
  mounted() {
    Axios.get("https://localhost:44388/api/HomeWizardApi/Start").then(
      response => {
        console.log(response);
        this.setWizardVM(response.data);
      }
    );
  }
};
</script>

<style>
</style>
