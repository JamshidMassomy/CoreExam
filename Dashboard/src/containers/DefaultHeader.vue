<template>
  <nav class="navbar navbar-expand-lg navbar-dark bg-primary">
    <a class="navbar-brand" href="#">Logo</a>

    <div class="collapse navbar-collapse" id="navbarColor01">
      <ul class="navbar-nav mr-auto">
        <li class="nav-item active">
          <router-link class="nav-link" to="/">Home</router-link>
        </li>
        <li>
          <router-link to="/about" class="nav-link">About</router-link>
        </li>
        <li>
          <router-link to="/login" class="nav-link">Admin</router-link>
        </li>
      </ul>
    </div>
  </nav>
</template>
<script>
import { Header as AppHeader, SidebarToggler, AsideToggler } from "@coreui/vue";
import DefaultHeaderDropdownAccnt from "./DefaultHeaderDropdownAccnt";

export default {
  name: "DefaultHeader",
  components: {
    AsideToggler,
    AppHeader,
    DefaultHeaderDropdownAccnt,
    SidebarToggler
  }
};
</script>
