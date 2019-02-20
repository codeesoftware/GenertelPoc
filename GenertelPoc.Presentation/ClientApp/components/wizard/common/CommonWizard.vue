<template></template>

<script>
import axios from "axios";
import validator from "../../scripts/customValidator";
import settings from "../../scripts/settings";

const baseUrl = settings.baseUrl;

export default {
  data() {
    return {
      currentPageId: Number,
      viewModel: null,
      wizardApiController: "" 
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
    end() {
      axios.post(`${baseUrl}/api/${this.wizardApiController}/End`, this.viewModel);
      this.$router.push(`/home/${++this.currentPageId}`);
    }
  },
  computed: {
    isFormValid() {
      return this.errors.items.length === 0;
    },
    selectedPage() {},
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
    next(vm => {
      vm.currentPageId = Number.parseInt(to.params.id);
    });
  },

  created() {
    axios
      .all([
        axios.get(`${baseUrl}/api/${this.wizardApiController}/Begin`),
        axios.get(`${baseUrl}/api/MessageApi/GetHomeWizardMessages`)
      ])
      .then(
        axios.spread((wizardViewModel, validatiomMessagesViewModel) => {
          this.viewModel = wizardViewModel.data;

          this.$store.commit(
            "validationMessage/setMessages",
            validatiomMessagesViewModel.data
          );
        })
      );
  }
};
</script>

<style>
</style>
