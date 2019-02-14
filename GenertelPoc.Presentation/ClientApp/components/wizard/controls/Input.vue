<template>
  <div>
    <div class="form-group">
      <label for="input">Text</label>
      <input
        type="text"
        v-validate.continues.initial="`${validations}`"
        name="input"
        class="form-control"
        v-on:input="$emit('input', $event.target.value)"
        :value="property.value"
      >
      <ul class="list-group">
        <li
          class="list-group-item list-group-item-danger"
          v-for="error in errors.collect('input')"
          :key="error.id"
        >{{ error }}</li>
      </ul>
    </div>
  </div>
</template>

<script>
export default {
  name: "input",
  props: {
    property: {
      type: Object,
      required: true
    },
    label: {
      type: "",
      required: false
    }
  },
  computed: {
    validations() {
      return _.join(this.property.validations.$values, "|");
    }
  }
};
</script>

<style>
</style>
