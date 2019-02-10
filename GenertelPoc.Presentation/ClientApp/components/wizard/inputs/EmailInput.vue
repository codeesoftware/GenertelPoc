<template>
  <div>
    <div class="form-group">
      <label for="exampleInputEmail1">Email address</label>
      <input
        type="email"
        class="form-control"
        v-bind:value="value"
        v-on:input="$emit('input', $event.target.value)"
        placeholder="Enter email"
      >
      <small
        id="emailHelp"
        class="form-text text-muted"
      >We'll never share your email with anyone else.</small>
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
