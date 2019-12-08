<template>
  <div class="app" dir="ltr">
    <div class="app-body">

      <b-container class="bv-example-row">
        <b-row>
          <b-col md="8">
            <Logo></Logo>
          </b-col>

          <b-col md="4 login-dari">
            <b-card-group>
              <b-card no-body class="p-4">
                <b-card-body>
                  <b-form>
                    <h1>Admin Login</h1>
                    <b-input-group class="mb-4">
                      <b-form-input type="text" class="form-control" placeholder="UserName" />
                      <b-form-input type="password" class="form-control" placeholder="Password" autocomplete="current-password" />
                    </b-input-group>
                    <b-row>
                      <b-col cols="6">
                        <b-button type="submit"  variant="primary">Login</b-button>
                        <!--<p>error message</p>-->
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
  </div>
</template>

<script>
  import Logo from "@/shared/Logo.vue";
  export default {
    name: "Login",
    components: {
      Logo
    },
    methods: {}
  };
</script>
