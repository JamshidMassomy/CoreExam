<template>
  <b-card>
    <div slot="header">
      <strong>Question Manager</strong>
    </div>
    <b-form inline>
      <label class="mr-sm-2">Question Category</label>
      <b-form-select v-model="parm.qcategoryid" size="md">
        <option v-for="category in selects.qcategories" :key="category.Id" v-bind:value="{ id: category.id, text: category.name }">
          {{ category.name }}
        </option>

      </b-form-select>
      <label class="mx-sm-2">Question Type </label>
      <b-form-select v-model="parm.qtypeid" size="md">
        <option v-for="type in selects.qtypes" :key="type.Id" :value="{id:type.id, text:type.name}">
          {{ type.name }}
        </option>
      </b-form-select>
    </b-form>
    <b-form inline>
      <label class="mx-sm-2">Languague  </label>
      <b-form-select v-model="parm.qlangid" size="md">
        <option v-for="lang in selects.qlang" :key="lang.Id" v-bind:value="{id:lang.id, text:lang.name}">
          {{ lang.name }}
        </option>
      </b-form-select>
      <label class="mr-sm-2">Score </label>
      <b-input v-model="parm.qscore" type="text" placeholder="Score"></b-input>
    </b-form>
    <!--<b-form inline>
      <Div_Img />
    </b-form>-->
    <b-form inline>
      <div class="image-preview">
        <img class="preview" :src="photo.img">
      </div>
      <div class="file-upload-form">
        <input type="file" @change="previewImage" accept="image/*" id="file" ref="file">
        <!--<input type="button" @click="savePhoto" value="save" />-->
      </div>
    </b-form>
    <b-form inline>
      <label class="mr-sm-2">Question text </label>
      <b-form-textarea v-model="parm.qtext" :rows="12" placeholder="Question Lebel" ></b-form-textarea>
      <label class="mx-sm-2">isActive </label>
      <b-form-checkbox v-model="parm.qactive" value="true"></b-form-checkbox>
    </b-form>


    <b-form inline>
      <label class="mr-sm-2">Options 1 </label>
      <b-input v-model="choice.option1"  type="text" placeholder="Options"></b-input>
      <label class="mr-sm-2">Score</label>
      <b-input v-model="choice.option1Score" id="inlineInput1" type="text" placeholder="Score"></b-input>
    </b-form>
    <b-form inline>
      <label class="mr-sm-2">Options 2 </label>
      <b-input v-model="choice.option2" type="text" placeholder="Score"></b-input>
      <label class="mr-sm-2">Score </label>
      <b-input v-model="choice.option2Score" type="text" placeholder="Score"></b-input>
    </b-form>
    <b-form inline>
      <label class="mr-sm-2">Options 3 </label>
      <b-input v-model="choice.option3" type="text" placeholder="Options"></b-input>
      <label class="mr-sm-2">Score</label>
      <b-input v-model="choice.option3Score" type="text" placeholder="Score"></b-input>
    </b-form>
    <b-form inline>
      <label class="mr-sm-2">Options 4 </label>
      <b-input v-model="choice.option4" type="text" placeholder="Score"></b-input>
      <label class="mr-sm-2">Score </label>
      <b-input v-model="choice.option4Score" type="text" placeholder="Score"></b-input>
    </b-form>

    <div slot="footer">
      <b-button type="submit" @click="save()" size="sm" variant="primary"><i class="fa fa-dot-circle-o"></i> save</b-button>
      <!--<b-button type="reset" size="sm" variant="danger"><i class="fa fa-ban"></i> Reset</b-button>-->
    </div>

  </b-card>
</template>
<script src="../../model/question.js"></script>

