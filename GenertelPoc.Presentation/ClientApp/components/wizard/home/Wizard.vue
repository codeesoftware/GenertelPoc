<template>
  <div class="ml-2">
    <div class="text-center">{{currentPageId}}. oldal</div>
    <div class="row page-header">
      <div class="col">
        <component
          v-bind:is="selectedPage"
          v-bind:pageViewModel="selectedPageViewModel"
          v-if="isLoaded"
        ></component>
      </div>
    </div>
    <div>
      <button
        type="button"
        class="btn btn-primary"
        @click="next()"
        :disabled="!isFormValid"
        v-show="!isLastPage"
      >Tovább</button>
      <button type="button" class="btn btn-danger" @click="back()" v-show="!isFirstPage">Vissza</button>
      <button
        type="button"
        class="btn btn-success"
        @click="send()"
        v-show="isLastPage"
        :disabled="!isFormValid"
      >Küld</button>
    </div>
  </div>
</template>

<script>
import FirstPage from "./FirstPage.vue";
import SecondPage from "./SecondPage.vue";
import ThankYouPage from "./ThankYouPage.vue";
import axios from "axios";
import validator from "../../scripts/validator.js";
import settings from "../../scripts/settings.js";

const baseUrl = settings.baseUrl;

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
      if (this.isFormValid) {
        this.$router.push(`/home/${++this.currentPageId}`);
        return;
      }
      alert("noo");
    },
    send() {
      axios.post(`${baseUrl}/api/HomeWizardApi/End`, this.viewModel);
      this.$router.push(`/home/${++this.currentPageId}`);
    }
  },
  computed: {
    isFormValid() {
      return this.errors.items.length === 0;
    },
    selectedPage() {
      const pages = [FirstPage, SecondPage, ThankYouPage];
      return pages[this.currentPageId - 1];
    },
    selectedPageViewModel() {
      let currentPageViewModel = this.viewModel.pages.find(
        p => p.pageId === this.currentPageId
      );
      return currentPageViewModel;
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
    axios
      .all([
        axios.get(`${baseUrl}/api/HomeWizardApi/Start`),
        axios.get(`${baseUrl}/api/MessageApi/GetHomeWizardMessages`)
      ])
      .then(
        axios.spread((wizardViewModel, validatiomMessagesViewModel) => {
          next(vm => {
            vm.currentPageId = Number.parseInt(to.params.id);
            vm.viewModel = wizardViewModel.data;

            vm.$store.commit(
              "validationMessage/setMessages",
              validatiomMessagesViewModel.data
            );
          });
        })
      );
  }
};
</script>

<style>
</style>
