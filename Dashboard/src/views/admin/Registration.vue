<template>
  <b-card>
    <div slot="header">
      <strong>Question Manager</strong>
    </div>
    <b-form inline>
      <label class="mr-sm-2">Select Test Types</label>
      <b-form-select v-model="registration.testID" size="md">
        <option v-for="tests  in select.testTypes" :key="tests.Id" v-bind:value="{ id: tests.id, text: tests.name }">
          {{ tests.name }}
        </option>

      </b-form-select>
      <label class="mx-sm-2">Access Levels </label>
      <b-form-select v-model="registration.accessLevelID" size="md">
        <option v-for="access in select.accessLevelType" :key="access.Id" :value="{id:access.id, text:access.name}">
          {{ access.name }}
        </option>
      </b-form-select>
    </b-form>

    <!-- Bootstrap Vue has some problems with Inline forms that's why we use some standard bootstrap classes -->
    <b-form inline>
      <label class="mr-sm-2">FirstName</label>
      <b-input type="text" placeholder="Name"></b-input>
      <label class="mx-sm-2">LastName</label>
      <b-input type="text" placeholder="LastName"></b-input>
    </b-form>
    <b-form inline>
      <label class="mr-sm-2">Gender</label>
      <b-form-select v-model="student.genderId" size="md">
        <option v-for="gender in select.genderType" :key="gender.Id" :value="{id:gender.id, text:gender.name}">
          {{ gender.name }}
        </option>
      </b-form-select>
      
    </b-form>
    <b-form inline>
      <label class="mr-sm-2">NID</label>
      <b-input type="text" placeholder="NID"></b-input>
      <label class="mx-sm-2">Father Name </label>
      <b-input type="text" placeholder="Father Name"></b-input>
    </b-form>

    <div slot="footer">
      <b-button type="submit" size="sm" variant="primary"><i class="fa fa-dot-circle-o"></i> Save</b-button>
      <b-button type="submit" size="sm" variant="primary"><i class="fa fa-dot-circle-o"></i> Clean</b-button>
      <b-button type="submit" size="sm" variant="primary"><i class="fa fa-dot-circle-o"></i> Print</b-button>
    </div>
  </b-card>
</template>
<script src="../../model/registration.js"></script>
