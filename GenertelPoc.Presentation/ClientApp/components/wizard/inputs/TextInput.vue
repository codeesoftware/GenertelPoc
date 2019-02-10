<template>
  <div>
    <div class="form-group">
      <label for="exampleInputText1">Text</label>
      <input
        type="text"
        class="form-control"
        v-bind:value="value"
        v-on:input="$emit('input', $event.target.value)"
        placeholder="Enter text"
      >
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
