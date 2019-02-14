<template>
  <div>
    <h1>Welcome to Hands on Vue.js with ASP.NET Core!</h1>

    <router-view/>
  </div>
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