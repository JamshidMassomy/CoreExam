<template>
  <div>
    
      <div class="image-preview">
        <img class="preview" :src="imageData">
      </div>
      <div class="file-upload-form">
        <input type="file" @change="previewImage" accept="image/*" id="file" ref="file">
        <input type="button" @click="savePhoto" value="save" />
      </div>
   
    
  </div>
</template>

<script>
  export default {
    name: 'div-img',
    data() {
      return {
        imageData: ''
      }
    },
    components: {},
    methods: {
      previewImage: function(event) {
            var input = event.target;
            if (input.files && input.files[0]) {
                // create a new FileReader to read this image and convert to base64 format
                var reader = new FileReader();
                // Define a callback function to run, when FileReader finishes its job
                reader.onload = (e) => {
                    // Note: arrow function used here, so that "this.imageData" refers to the imageData of Vue component
                    // Read image as base64 and set to imageData
                    this.imageData = e.target.result;
                }
                // Start the reader job - read file as a data url (base64 format)
                reader.readAsDataURL(input.files[0]);
            }
      },
      savePhoto: function () {
        //let formdata = new FormData();
        //formdata.append('file', this.file)
        this.axios({
          method: 'post',
          url: '/File/SavePhoto/SavePhoto',
          data: {
            recordId: 11,
            fileName: 'axios file',
            path: '/op',
            base64:this.imageData
          }
          //headers: {
          //    'Content-Type': 'multipart/form-data'
          //  }
          

        }).then(x => { console.log(x) })
      }
    }

  }
</script>
