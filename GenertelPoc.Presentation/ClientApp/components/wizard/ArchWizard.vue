<template>
  <div>
    <h2>Wizard</h2>
    <div class="container">
      <wizard-accordion>
        <span slot="header">Price</span>
        <span slot="body">Price</span>
      </wizard-accordion>
    </div>
  </div>
</template>

<script>
import WizardAccordion from "./WizardAccordion.vue";
import HomeWizard from "./HomeWizard.vue";

export default {
  name: "arc-wizard",
  components: {
    WizardAccordion,
    HomeWizard
  }
};
</script>

<style>
</style>
