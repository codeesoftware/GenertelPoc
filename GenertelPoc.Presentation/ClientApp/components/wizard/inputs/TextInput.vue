<template>
  <div>
    <div class="form-group">
      <label for="textInput">Text</label>
      <input
        type="text"
        v-validate="'required|betweenke:10,20'"
        name="textInput"
        class="form-control"
        v-on:input="$emit('input', $event.target.value)"
        placeholder="Enter text"
      >
      <span class="badge badge-danger">{{ errors.first('textInput') }}</span>
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
