<template>
  <div>
    <div class="form-group">
      <label for="textInput">Text</label>
      <input
        type="text"
        v-validate="`${validations}`"
        name="textInput"
        class="form-control"
        v-on:input="$emit('input', $event.target.value)"
        :value="property.value"
      >
      <span class="badge badge-danger">{{ errors.first('textInput') }}</span>
    </div>
  </div>
</template>

<script>
export default {
  name: "text-input",
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
  // beforeCreate() {
  //   this.validations = "VAL_100";
  // }
};
</script>

<style>

</style>
