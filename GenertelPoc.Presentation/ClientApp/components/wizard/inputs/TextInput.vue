<template>
  <div>
    <div class="form-group">
      <label for="exampleInputText1">Text</label>
      <input
        type="text"
        v-validate="'required|min:3'"
        name="textInput"
        class="form-control"
        v-on:input="$emit('input', $event.target.value)"
        placeholder="Enter text"
      >
      <span>{{ errors.first('textInput') }}</span>
    </div>
  </div>
</template>

<script>
export default {
  name: "text-input"
};
</script>

<style>
</style>
