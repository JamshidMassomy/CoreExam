<template>
  <div class="app" dir="ltr">
    <!-- <DefaultHeader fixed /> -->
    <div class="app-body">
      <b-container class="bv-example-row">
        <b-row>
          <div>
            <div class="transport-logo">
              <img src="../../public/img/Transport2.png" id="logo" />
            </div>

          </div>
          <b-col md="4">
            <b-card-group>
              <b-card no-body class="p-4">
                <b-card-body>
                  <b-form>
                    <h1>Login</h1>
                    <p class="text-muted">Sign In </p>
                    <b-input-group class="mb-4">

                      <b-form-input type="password" class="form-control" placeholder="Password" autocomplete="current-password" />
                    </b-input-group>
                    <b-row>
                      <b-col cols="6">
                        <b-button variant="primary" class="px-4">Login</b-button>
                      </b-col>
                    </b-row>
                  </b-form>
                </b-card-body>
              </b-card>
            </b-card-group>
          </b-col>
        </b-row>
      </b-container>
      <router-view></router-view>
    </div>
    <!--<div class="app flex-row align-items-center">
      <div class="container">
        <b-row class="justify-content-center">
          <b-col md="8">
            <b-card-group>
              <b-card no-body class="p-4">
                <b-card-body>
                  <b-form>
                    <h1>Login</h1>
                    <p class="text-muted">Sign In to your account</p>
                    <b-input-group class="mb-3">
                      <b-input-group-prepend><b-input-group-text><i class="icon-user"></i></b-input-group-text></b-input-group-prepend>
                      <b-form-input type="text" class="form-control" placeholder="Username" autocomplete="username email" />
                    </b-input-group>
                    <b-input-group class="mb-4">
                      <b-input-group-prepend><b-input-group-text><i class="icon-lock"></i></b-input-group-text></b-input-group-prepend>
                      <b-form-input type="password" class="form-control" placeholder="Password" autocomplete="current-password" />
                    </b-input-group>
                    <b-row>
                      <b-col cols="6">
                        <b-button variant="primary" class="px-4">Login</b-button>
                      </b-col>
                      <b-col cols="6" class="text-right">
                        <b-button variant="link" class="px-0">Forgot password?</b-button>
                      </b-col>
                    </b-row>
                  </b-form>
                </b-card-body>
              </b-card>
              <b-card no-body class="text-white bg-primary py-5 d-md-down-none" style="width:44%">
                <b-card-body class="text-center">
                  <div>
                    <h2>Sign up</h2>
                    <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.</p>
                    <b-button variant="primary" class="active mt-3">Register Now!</b-button>
                  </div>
                </b-card-body>
              </b-card>
            </b-card-group>
          </b-col>
        </b-row>
      </div>
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

</style>
<script>

</script>
