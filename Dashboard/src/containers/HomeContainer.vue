<template>
  <div class="app" dir="ltr">
    <!-- <DefaultHeader fixed /> -->
    <div class="app-body">
      <b-container class="bv-example-row">
        <b-row>
          <div class="col-sm-6 col-lg-4">
            <!--<a  href="#/dari"><b-button block variant="primary" class="h4 m-0">دری</b-button></a-->
            <router-link to="/dari" >
              <b-button block variant="primary" class="h4 m-0">دری</b-button>
            </router-link>

          </div>
          <div class="col-sm-6 col-lg-4">
            <router-link to="/pashto">
              <b-button block variant="primary">پښتو</b-button>
            </router-link>


          </div>
        </b-row>
      </b-container>
      <router-view></router-view>
    </div>

    <!--<div class="card text-white bg-primary">
  </div>-->
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
  .container{
    margin:auto;
   
  }
  .btn-block
  {
    padding:1.2rem;
    font-size:1.1rem;
    background-color:#004889;
  }

</style>
<script>

</script>
