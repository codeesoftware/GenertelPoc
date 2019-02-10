<template>
  <div class="ml-2">
    <div class="text-center">{{this.currentPageId}}. oldal</div>
    <div class="row page-header">
      <div class="col">
        <component v-bind:is="selectedPage" :pageId="this.currentPageId"></component>
      </div>
    </div>
    <div>
      <button type="button" class="btn btn-primary" @click="next()" v-show="!isLastPage">Tovább</button>
      <button type="button" class="btn btn-danger" @click="back()" v-show="!isFirstPage">Vissza</button>
      <button type="button" class="btn btn-success" @click="send()" v-show="isLastPage">Küld</button>
    </div>
  </div>
</template>

<script>
import FirstPage from "./FirstPage.vue";
import SecondPage from "./SecondPage.vue";
import ThankYouPage from "./ThankYouPage.vue";
import Axios from "axios";

const baseUrl = "https://localhost:44388";

export default {
  name: "wizard",
  components: {
    FirstPage,
    SecondPage,
    ThankYouPage
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
      this.$router.push(`/home/${++this.currentPageId}`);
      const offer = this.$store.state.offer.offerState;
      Axios.post(`${baseUrl}/api/HomeWizardApi/End`, offer);
      console.table(offer);
    }
  },
  computed: {
    getCurrentPageId() {
      return this.currentPageId;
    },
    selectedPage() {
      const pages = [FirstPage, SecondPage, ThankYouPage];
      return pages[this.currentPageId - 1];
    },
    isFirstPage() {
      return this.currentPageId <= 1;
    },
    isLastPage() {
      return 2 <= this.currentPageId;
    }
  },

  beforeRouteEnter(to, from, next) {
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
