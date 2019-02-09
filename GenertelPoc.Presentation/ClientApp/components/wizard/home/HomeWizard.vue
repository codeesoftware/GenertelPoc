<template>
  <div>
    <h3>Jelenlegi oldal {{this.currentPageId}}</h3>
    <!-- <home-first-page v-if="this.currentPageId == 1" :pageId="1"></home-first-page>
    <home-second-page v-if="this.currentPageId == 2" :pageId="2"></home-second-page>-->
    <div class="row">
      <div class="col">
        <component v-bind:is="selectedComponent"></component>
      </div>
    </div>
    <button class="btn btn-primary" @click="back()">Vissza</button>
    <button class="btn btn-primary" @click="next()">Tovább</button>
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
      currentPageId: Number,
      selected: 1
      // test: Object
    };
  },
  methods: {
    setCurrentPageId(pageId) {
      this.currentPageId = pageId;
    },
    back() {
      this.$router.push(`/home/${--this.selected}`);
    },
    next() {
      this.$router.push(`/home/${++this.selected}`);
    }
  },
  computed: {
    getCurrentPageId() {
      console.log(this.$store.state.offer.offerState);
      //return this.$store.getters["wizard/currentPageId"];
      //   return this.$store.state.offer.offerState.currentPageId;
      return this.currentPageId;
    },
    selectedComponent() {
      return this.selected == 1 ? HomeFirstPage : HomeSecondPage;
    }
  },

  beforeRouteEnter(to, from, next) {
    console.log("hova " + to.params.id);
    next(vm => vm.setCurrentPageId(to.params.id));
    // axios.get(`/api/products/${to.params.id}`).then(response => {
    //   next(vm => vm.setData(response.data));
    // });
  }
  // created() {
  //   Axios.get("https://localhost:44388/api/HomeWizardApi/Start").then(
  //     response => {
  //       this.$store.commit("offer/setOfferState", response.data);
  //       //  this.test = response.data;
  //     }
  //   );
  // }
};
</script>

<style>
</style>
