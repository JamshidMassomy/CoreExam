<template>
  <b-card>
    <div slot="header">
      <strong>Question Manager</strong>
    </div>
    <!-- Bootstrap Vue has some problems with Inline forms that's why we use some standard bootstrap classes -->
    <b-form inline>
      <label class="mr-sm-2" >FirstName</label>
      <b-input  type="text" placeholder="Name"></b-input>
      <label class="mx-sm-2">LastName</label>
      <b-input  type="text" placeholder="LastName"></b-input>
    </b-form>
    <b-form inline>
      <label class="mr-sm-2" >NID</label>
      <b-input  type="text" placeholder="NID"></b-input>
      <label class="mx-sm-2" >Father Name </label>
      <b-input type="text" placeholder="Father Name" ></b-input>
    </b-form>
  
    <div slot="footer">
      <b-button type="submit" size="sm" variant="primary"><i class="fa fa-dot-circle-o"></i> Save</b-button>
      <b-button type="submit" size="sm" variant="primary"><i class="fa fa-dot-circle-o"></i> Clean</b-button>
      <b-button type="submit" size="sm" variant="primary"><i class="fa fa-dot-circle-o"></i> Print</b-button>
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
