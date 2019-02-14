<template>
  <div>
    <div class="form-group">
      <label for="dropdown">Dropwdown</label>
      <select
        v-model="property.value"
        class="form-control"
        v-validate.continues.initial="`${validations}`"
      >
        <option
          v-for="option in property.options.$values"
          :key="option"
          :value="option"
        >{{ option }}</option>
      </select>

      <ul class="list-group">
        <li
          class="list-group-item list-group-item-danger"
          v-for="error in errors.collect('input')"
          :key="error.id"
        >{{ error }}</li>
      </ul>
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
  },
  computed: {
    validations() {
      return _.join(this.property.validations.$values, "|");
    }
  }
};
</script>

<style>
</style>
