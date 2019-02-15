<template>
  <ul class="list-group">
    <li
      class="list-group-item list-group-item-danger"
      v-for="error in errors"
      :key="error.id"
    >{{ error }}</li>
  </ul>
</template>

<script>
export default {
  name: "error",
  props: {
    errors: {
      type: Array,
      required: false
    }
  }
};
</script>

<style>
</style>
