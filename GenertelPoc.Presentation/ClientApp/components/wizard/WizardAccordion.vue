<template>
  <div>
    <div>
      <slot name="header"></slot>
    </div>
    <!-- <transition @enter="onEnter" @leave="onLeave"> -->
    <div>
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
