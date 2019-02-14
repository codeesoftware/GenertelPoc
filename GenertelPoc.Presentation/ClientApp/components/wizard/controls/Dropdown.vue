<template>
  <div>
    <div class="form-group">
      <label for="dropdown">Dropwdown</label>
      <select :value="property.value" @change="setValue($event.target.value)" class="form-control">
        <option
          v-for="option in property.options.$values"
          :key="option"
          :value="option"
        >{{ option }}</option>
      </select>
      
      <span class="badge badge-danger">{{ errors.first('dropdown') }}</span>
    </div>
  </div>
</template>

<script>
export default {
  name: "input",
  props: {
    property: {
      type: Object,
      required: true
    }
  },
  methods: {
    setValue(val) {
      console.log(val);
      this.$emit("input", val);
    }
  }
};
</script>

<style>
</style>
