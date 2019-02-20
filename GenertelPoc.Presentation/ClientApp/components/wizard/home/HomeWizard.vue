<template>
  <div class="ml-2">
    <h1></h1>
    <div class="text-center">{{currentPageId}}. oldal</div>
    <div class="row page-header">
      <div class="col">
        <transition name="fade" mode="out-in">
          <component
            :is="selectedPage"
            :viewModel="viewModel"
            :currentPageId="currentPageId"
            v-if="isLoaded"
          ></component>
        </transition>
      </div>
    </div>
    <div>
      <button
        id="nextPageButton"
        type="button"
        class="btn btn-primary"
        @click="next()"
        :disabled="!isFormValid"
        v-show="!isLastPage"
      >Tovább</button>
      
      <button
        id="previousPageButton"
        type="button"
        class="btn btn-danger"
        @click="back()"
        v-show="!isFirstPage"
      >Vissza</button>
      
      <button
        id="endPageButton"
        type="button"
        class="btn btn-success"
        @click="end()"
        v-show="isLastPage"
        :disabled="!isFormValid"
      >Befejezés</button>
    </div>
  </div>
</template>

<script>
import FirstPage from "./FirstPage.vue";
import SecondPage from "./SecondPage.vue";
import ThankYouPage from "./ThankYouPage.vue";
import CommonWizard from "../common/CommonWizard.vue";



export default {
  name: "wizard",
  extends:CommonWizard,
  components: {
    FirstPage,
    SecondPage,
    ThankYouPage
  },
  data() {
    return {
    wizardApi:"HomeWizardApi"
    };
  },
   computed: {
    selectedPage() {
      const pages = [FirstPage, SecondPage, ThankYouPage];
      return pages[this.currentPageId - 1];
    }
   }
};
</script>

<style>
</style>
