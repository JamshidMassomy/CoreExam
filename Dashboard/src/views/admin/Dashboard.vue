<template>
  <b-row>
    <b-col sm="8" md="3">
      <b-card>
        <div class="h1 text-muted text-right mb-4">
          <i class="icon-people"></i>
        </div>
        <div class="h4 mb-0">Registration</div>
        <small class="text-muted text-uppercase font-weight-bold">Register Applicant for exam</small>
      </b-card>
    </b-col>
    <b-col sm="6" md="3">
      <b-card>
        <div class="h1 text-muted text-right mb-4">
          <i class="icon-speech"></i>
        </div>
        <div class="h4 mb-0">Question Manager</div>
        <small class="text-muted text-uppercase font-weight-bold">Manage Question</small>
      </b-card>
    </b-col>
  </b-row><!--/.row-->
</template>

<script>
export default {
  name: "dashboard",
  components: {},
  methods: {}
};
</script>

<style>
/* IE fix */
#card-chart-01,
#card-chart-02 {
  width: 100% !important;
}
</style>
