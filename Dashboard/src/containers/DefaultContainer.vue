<template>
  <div class="app">
    <!-- <DefaultHeader fixed /> -->
    <div class="app-body">
      <b-container class="bv-example-row">
        <b-row>
          <div class="container-fluid">
            <router-view></router-view>
          </div>
        </b-row>
      </b-container>
      <AppSidebar fixed>
        <SidebarNav :navItems="nav"></SidebarNav>
      </AppSidebar>
    </div>
    <!-- <DefaultFooter /> -->
  </div>
</template>
<style>
.container-fluid {
  margin-top: 5%;
}
</style>
<script>
import nav from "@/_nav";
import {
  Sidebar as AppSidebar,
  SidebarNav,
  Aside as AppAside
} from "@coreui/vue";

export default {
  name: "DefaultContainer",
  components: {
    AppSidebar,
    AppAside,
    SidebarNav
  },
  data() {
    return {
      nav: nav.items
    };
  },
  computed: {
    name() {
      return this.$route.name;
    },
    list() {
      return this.$route.matched.filter(
        route => route.name || route.meta.label
      );
    }
  }
};
// export default {
//   name: "DefaultContainer",
//   components: {
//     AppSidebar,
//     AppAside,
//     DefaultAside,
//     DefaultHeaderDropdownAccnt,

//     SidebarNav,

//     DefaultFooter,
//     DefaultHeader
//   },
//   data() {
//     return {
//       nav: nav.items
//     };
//   },
//   computed: {
//     name() {
//       return this.$route.name;
//     },
//     list() {
//       return this.$route.matched.filter(
//         route => route.name || route.meta.label
//       );
//     }
//   }
// };
</script>
