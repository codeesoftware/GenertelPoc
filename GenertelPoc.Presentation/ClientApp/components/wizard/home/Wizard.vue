<template>
  <div>
    <h3>Jelenlegi oldal {{this.currentPageId}}</h3>
    <home-first-page v-if="this.currentPageId == 1" :pageId="1"></home-first-page>
    <home-second-page v-if="this.currentPageId == 2" :pageId="2"></home-second-page>
    <div class="row">
      <div class="col">
        <component v-bind:is="selectedPage" :page="this.currentPageId"></component>
      </div>
    </div>
    <button class="btn btn-primary" @click="back()">Vissza</button>
    <button class="btn btn-primary" @click="next()">Tovább</button>
    <button class="btn btn-danger" @click="send()">Küld</button>
  </div>
</template>

<script>
import FirstPage from "./FirstPage.vue";
import SecondPage from "./SecondPage.vue";
import Axios from "axios";

const baseUrl = "https://localhost:44388";

export default {
  name: "wizard",
  components: {
    FirstPage,
    SecondPage
  },
  data() {
    return {
      currentPageId: Number
      // test: Object
    };
  },
  methods: {
    setCurrentPageId(pageId) {
      this.currentPageId = pageId;
    },
    back() {
      this.$router.push(`/home/${--this.currentPageId}`);
    },
    next() {
      this.$router.push(`/home/${++this.currentPageId}`);
    },
    send() {
      const offer = this.$store.state.offer.offerState;
      console.log(offer);
      Axios.post(`${baseUrl}/api/HomeWizardApi/End`, offer);
    }
  },
  computed: {
    getCurrentPageId() {
      return this.currentPageId;
    },
    selectedPage() {
      return this.currentPageId == 1 ? FirstPage : SecondPage;
    }
  },

  beforeRouteEnter(to, from, next) {
    console.log("hova " + to.params.id);
    Axios.get(`${baseUrl}/api/HomeWizardApi/Start`).then(response => {
      next(vm => {
        vm.$store.commit("offer/setOfferState", response.data);
        vm.setCurrentPageId(to.params.id);
      });
    });
  }
};
</script>

<style>
</style>
