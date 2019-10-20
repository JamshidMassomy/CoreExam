<template>
  <div class="wrapper">
    <p>hi from bread camp</p>
  </div>
</template>

<script>
export default {
  name: "breadcrumbs",
  data() {
    return {
      items: [
        {
          text: "Admin",
          href: "#"
        },
        {
          text: "Manage",
          href: "#"
        },
        {
          text: "Library",
          active: true
        }
      ]
    };
  }
};
</script>
