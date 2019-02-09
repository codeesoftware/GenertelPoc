<template>
  <div class="container text-center">
    <div>
      <slot name="header"></slot>
    </div>
    <!-- <transition @enter="onEnter" @leave="onLeave"> -->
    <div class="col-12">
      <slot name="body"></slot>
    </div>
    <!-- </transition> -->
  </div>
</template>

<script>
export default {
  name: "wizar-accordion"
};
</script>

<style>
</style>
