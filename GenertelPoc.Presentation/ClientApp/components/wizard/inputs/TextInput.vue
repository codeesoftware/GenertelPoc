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
      >
      <span class="badge badge-danger">{{ errors.first('textInput') }}</span>
    </div>
  </div>
</template>

<script>
export default {
  name: "text-input",
  props: {
    validations: {
      type: String,
      required: false
    },
    defaultText: {
      type: String,
      required: false
    }
  }
  // beforeCreate() {
  //   this.validations = "VAL_100";
  // }
};
</script>

<style>
</style>
