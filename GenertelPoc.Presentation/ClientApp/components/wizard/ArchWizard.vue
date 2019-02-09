<template>
  <div class="text-center">
    <h2>Wizard</h2>
    <div class="container">
      <wizard-accordion>
        <span slot="header">Price</span>
        <home-wizard slot="body"></home-wizard>
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
