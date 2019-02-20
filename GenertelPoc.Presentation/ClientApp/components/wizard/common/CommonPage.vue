<template></template>

<script>
export default {
  name: "common-page",
  computed: {
    pageViewModel() {
      let currentPageViewModel = this.viewModel.pages.find(
        p => p.pageId === this.currentPageId
      );
      return currentPageViewModel;
    }
  },
  props: {
    viewModel: {
      type: Object,
      required: true
    },
    currentPageId: {
      type: Number,
      required: true,
      validator: function(value) {
        return 0 < value;
      }
    }
  }
};
</script>

<style>
</style>
