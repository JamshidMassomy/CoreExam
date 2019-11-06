<template>
  <b-card>
    <div slot="header">
      <strong>Question Manager</strong>
    </div>
    <!-- Bootstrap Vue has some problems with Inline forms that's why we use some standard bootstrap classes -->
    <b-form inline>
      <label class="mr-sm-2" for="inlineInput1">Name: </label>
      <b-input id="inlineInput1" type="text" placeholder="Jane Doe"></b-input>
      <label class="mx-sm-2" for="inlineInput2">Email: </label>
      <b-input id="inlineInput2" type="email" placeholder="jane.doe@example.com" autocomplete="email"></b-input>
    </b-form>
    <b-form inline>
      <label class="mr-sm-2" for="inlineInput1">Name: </label>
      <b-input id="inlineInput1" type="text" placeholder="Jane Doe"></b-input>
      <label class="mx-sm-2" for="inlineInput2">Email: </label>
      <b-input id="inlineInput2" type="email" placeholder="jane.doe@example.com" autocomplete="email"></b-input>
    </b-form>
    <b-form inline>
      <label class="mr-sm-2" for="inlineInput1">Score </label>
      <b-input id="inlineInput1" type="text" placeholder="Score"></b-input>
      <label class="mx-sm-2" for="inlineInput2">isActive</label>
      <b-input id="inlineInput2" type="email" placeholder="isActive" autocomplete="email"></b-input>
    </b-form>
    <div slot="footer">
      <b-button type="submit" size="sm" variant="primary"><i class="fa fa-dot-circle-o"></i> Submit</b-button>
      <b-button type="reset" size="sm" variant="danger"><i class="fa fa-ban"></i> Reset</b-button>
    </div>
  </b-card>
</template>

<script>
  export default {
    name: "applicant",
    components: {},
    methods: {}
  };
</script>
