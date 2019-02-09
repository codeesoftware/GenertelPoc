<template>
  <div>
    <h3>a{{this.getCurrentPageId}}</h3>
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
      // test: Object
    };
  },
  methods: {
    // setWizardVM(wizardVM) {
    //   debugger;
    //   this.wizardVM = wizardVM;
    // }
  },
  computed: {
    getCurrentPageId() {
      console.log(this.$store.state.offer.offerState);
      //return this.$store.getters["wizard/currentPageId"];
      return this.$store.state.offer.offerState.currentPageId;
      //return this.test.currentPageId;
    }
  },
  created() {
    Axios.get("https://localhost:44388/api/HomeWizardApi/Start").then(
      response => {
        this.$store.commit("offer/setOfferState", response.data);
        //  this.test = response.data;
      }
    );
  }
};
</script>

<style>
</style>
