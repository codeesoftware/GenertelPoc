<template>
  <div class="ml-2">
    {{currentPageId}}
    <div class="text-center">{{currentPageId}}. oldal</div>
    <div class="row page-header">
      <div class="col">
        <component
          v-bind:is="selectedPage"
          v-bind:pageViewModel="getPageViewModel(currentPageId)"
          v-if="isLoaded"
        ></component>
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
import Validator from "../../validators/validator.js";

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
      currentPageId: Number,
      viewModel: null
    };
  },
  methods: {
    back() {
      this.$router.push(`/home/${--this.currentPageId}`);
    },
    next() {
      this.$router.push(`/home/${++this.currentPageId}`);
    },
    send() {
      //    const offer = this.$store.state.offer.offerState;
      Axios.post(`${baseUrl}/api/HomeWizardApi/End`, this.viewModel);
      this.$router.push(`/home/${++this.currentPageId}`);
    },
    getPageViewModel(pageId) {
      let currentPageViewModel = this.viewModel.pages.find(
        p => p.pageId === pageId
      );
      return this.isLoaded ? currentPageViewModel : null;
    }
  },
  computed: {
    selectedPage() {
      const pages = [FirstPage, SecondPage, ThankYouPage];
      return pages[this.currentPageId - 1];
    },
    isFirstPage() {
      return this.currentPageId <= 1;
    },
    isLastPage() {
      return 2 <= this.currentPageId;
    },
    isLoaded() {
      if (this.viewModel) {
        return true;
      }
      return false;
    }
  },

  beforeRouteEnter(to, from, next) {
    Axios.get(`${baseUrl}/api/HomeWizardApi/Start`).then(response => {
      next(vm => {
        vm.currentPageId = Number.parseInt(to.params.id);
        vm.viewModel = response.data;
      });
    });
  }
};
</script>

<style>
</style>
