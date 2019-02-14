<template>
  <div>
    <div class="form-group">
      <label for="input">Text</label>
      <input
        type="text"
        v-validate="`${validations}`"
        name="input"
        class="form-control"
        v-on:input="$emit('input', $event.target.value)"
        :value="property.value"
      >
      <span class="badge badge-danger">{{ errors.first('input') }}</span>
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
