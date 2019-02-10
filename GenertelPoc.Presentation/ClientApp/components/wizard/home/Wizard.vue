<template>
  <div>
    <h3>{{this.currentPageId}}. oldal</h3>
    <div class="row">
      <div class="col">
        <component v-bind:is="selectedPage" :pageId="this.currentPageId"></component>
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
import ThirdPage from "./ThirdPage.vue";
import Axios from "axios";

const baseUrl = "https://localhost:44388";

export default {
  name: "wizard",
  components: {
    FirstPage,
    SecondPage,
    ThirdPage
  },
  data() {
    return {
      currentPageId: Number
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
      Axios.post(`${baseUrl}/api/HomeWizardApi/End`, offer);
    }
  },
  computed: {
    getCurrentPageId() {
      return this.currentPageId;
    },
    selectedPage() {
      const pages = [FirstPage, SecondPage, ThirdPage];
      return pages[this.currentPageId - 1];
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
