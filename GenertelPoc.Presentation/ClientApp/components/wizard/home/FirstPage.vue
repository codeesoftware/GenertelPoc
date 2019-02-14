<template>
  <div>
    <own-input :property="pageViewModel.fullName"></own-input>
    <own-input :property="pageViewModel.age"></own-input>
    <own-dropdown :property="pageViewModel.damage"></own-dropdown>
  </div>
</template>

<script>
import Input from "../controls/Input.vue";
import Dropdown from "../controls/Dropdown.vue";

export default {
  name: "first-page",
  components: {
    OwnInput: Input,
    OwnDropdown: Dropdown
  },

  props: {
    pageViewModel: {
      type: Object,
      required: true
    }
  }
};
</script>

<style>
</style>
