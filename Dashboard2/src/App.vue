<template>
  <div id="app">
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
    <!-- <div class="col-md-4">
      <button type="button" class="btn btn-primary btn-lg btn-block">Dari</button>
      <button type="button" class="btn btn-primary btn-lg btn-block">Pashto</button>
    </div>-->

    <router-view />
    <footer>
      <nav class="navbar navbar-expand-lg navbar-light bg-light">
        <a class="navbar-brand" href="#">Asan Khedmat 2019</a>

        <div class="collapse navbar-collapse" id="navbarColor03">
          <ul class="navbar-nav mr-auto">
            <li class="nav-item">Powered by NET core 2.2</li>
          </ul>
        </div>
      </nav>
    </footer>
  </div>
</template>

<style>
#app {
  font-family: "Avenir", Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
}
footer {
  position: fixed;
  width: 100%;
  bottom: 0;
}
#nav {
  padding: 30px;
}

#nav a {
  font-weight: bold;
  color: #2c3e50;
}

#nav a.router-link-exact-active {
  color: #42b983;
}
</style>
