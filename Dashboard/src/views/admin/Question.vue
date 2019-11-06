<template>
  <b-card>
    <div slot="header">
      <strong>Question Manager</strong>
    </div>
    <b-form inline>
      <label class="mr-sm-2" for="inlineInput1">Question Category</label>
      <select v-model="parm.qcategoryid">
        <option v-for="category in selects.qcategories" :key="category.Id" v-bind:value="{ id: category.id, text: category.name }">
          {{ category.name }}
        </option>
      </select>
      <label class="mx-sm-2" for="inlineInput2">Question Type </label>
      <select v-model="parm.qtypeid">
        <option v-for="type in selects.qtypes" :key="type.Id" :value="{id:type.id, text:type.name}">
          {{ type.name }}
        </option>
      </select>
    </b-form>
    <b-form inline>
      <label class="mx-sm-2" for="inlineInput2">Languague  </label>
      <select v-model="parm.qlangid">
        <option v-for="lang in selects.qlang" :key="lang.Id" v-bind:value="{id:lang.id, text:lang.name}">
          {{ lang.name }}
        </option>
      </select>
    </b-form>
    <b-form inline>
      <label class="mr-sm-2">Question text </label>
      <b-form-textarea v-model="parm.qtext" :rows="12" placeholder="Question Lebel"></b-form-textarea>
    </b-form>
    <b-form inline>
      <label class="mr-sm-2" for="inlineInput1">Score </label>
      <b-input v-model="parm.qscore" id="inlineInput1" type="text" placeholder="Score"></b-input>
      <label class="mx-sm-2">isActive </label>
      <b-form-checkbox v-model="parm.qactive" value="true"></b-form-checkbox>
    </b-form>

    <b-form inline>
      <label class="mr-sm-2" for="inlineInput1">Options 1 </label>
      <b-input type="text" placeholder="Options"></b-input>
      <label class="mr-sm-2" for="inlineInput1">Score</label>
      <b-input id="inlineInput1" type="text" placeholder="Score"></b-input>
    </b-form>
    <b-form inline>
      <label class="mr-sm-2" for="inlineInput1">Options 2 </label>
      <b-input id="inlineInput1" type="text" placeholder="Score"></b-input>
      <label class="mr-sm-2" for="inlineInput1">Score </label>
      <b-input id="inlineInput1" type="text" placeholder="Score"></b-input>
    </b-form>
    <b-form inline>
      <label class="mr-sm-2" for="inlineInput1">Options 3 </label>
      <b-input id="inlineInput1" type="text" placeholder="Options"></b-input>
      <label class="mr-sm-2" for="inlineInput1">Score</label>
      <b-input id="inlineInput1" type="text" placeholder="Score"></b-input>
    </b-form>
    <b-form inline>
      <label class="mr-sm-2" for="inlineInput1">Options 4 </label>
      <b-input id="inlineInput1" type="text" placeholder="Score"></b-input>
      <label class="mr-sm-2" for="inlineInput1">Score </label>
      <b-input id="inlineInput1" type="text" placeholder="Score"></b-input>
    </b-form>
    <b-form inline>
      <Div_Img />
    </b-form>

      <div slot="footer">
        <b-button type="submit" @click="save()" size="sm" variant="primary"><i class="fa fa-dot-circle-o"></i> save</b-button>
        <!--<b-button type="reset" size="sm" variant="danger"><i class="fa fa-ban"></i> Reset</b-button>-->
      </div>

  </b-card>



</template>
<script src="../../model/question.js"></script>

