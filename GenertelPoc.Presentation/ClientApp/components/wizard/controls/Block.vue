<template>
  <div>
    <label :for="name">{{label}}</label>
    <slot name="body"></slot>
    <slot ></slot>
  </div>
</template>

<script>
export default {
  name: "block",
  props: {
    label: {
      type: String,
      required: true
    },
    name: {
      type: String,
      required: true
    }
  },
};
</script>

<style>
</style>
