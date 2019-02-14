<template>
  <div>
    <own-input v-model="pageViewModel.fullName.value" :property="pageViewModel.fullName"></own-input>
    <own-input v-model="pageViewModel.age.value" :property="pageViewModel.age"></own-input>
    <own-dropdown v-model="pageViewModel.damage.value" :property="pageViewModel.damage"></own-dropdown>
    {{errors}}
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
