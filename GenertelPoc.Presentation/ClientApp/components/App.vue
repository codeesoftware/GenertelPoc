<template>
  <transition name="fade" mode="out-in">
    <router-view/>
  </transition>
</template>

<script>
export default {
  name: "app",
  data() {
    return {
      time: new Date().toString()
    };
  },
  methods: {
    change() {}
  }
};
</script>
<style>
.fade-enter-active,
.fade-leave.actice {
  transition: opacity 0.3s ease-in-out;
}
.fade-enter,
.fade-leave-to {
  opacity: 0;
}
</style>
