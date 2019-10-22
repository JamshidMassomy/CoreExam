<template>
  <div class="app">
    <!-- <DefaultHeader fixed /> -->
    <div class="app-body">
      <b-container class="bv-example-row">
        <b-row>
          <div class="container-fluid">
            <p>Home Container Question loads here</p>
            <div class="transport-logo">
              <img src="../../public/Transport2.png" id="logo" />
            </div>
            <router-view></router-view>
          </div>
        </b-row>
      </b-container>
      
    </div>
    <!-- <DefaultFooter /> -->
  </div>
</template>
<style>
.container-fluid {
  margin-top: 5%;
}
  #logo{
    width: 45em;
    float: left;
    margin-left: 4em;
    margin-top: 2em;
  }

</style>
<script>

</script>
