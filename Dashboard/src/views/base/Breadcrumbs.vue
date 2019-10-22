<template>
  <div class="wrapper">
    <p>DEmo of axios has been </p>
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
  },
   mounted () {
    axios
      .get('https://localhost:5001/api/Look/GetQuestionTypes/QuestionTypes')
      .then(response => (console.log(response)))
  }
};

</script>
