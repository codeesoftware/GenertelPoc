<template>
  <div>
    <div class="form-group">
      <label for="exampleInputEmail1">Email address</label>
      <input
        class="form-control"
        v-validate="'required|email'"
        name="emailInput"
        type="text"
        v-on:input="$emit('input', $event.target.value)"
      >
      <span>{{ errors.first('emailInput') }}</span>
    </div>
  </div>
</template>

<script>
export default {
  name: "email-input"
};
</script>

<style>
</style>
