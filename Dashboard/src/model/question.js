//import Div_Img from '@/shared/Img.vue'
export default {
    name: 'reg-question',
    data() {
        return {
            selects: {
                qtypes: [],
                qcategories: [],
                qlang: []
            },
            parm: {
                qtypeid: '',
                qcategoryid: '',
                qlangid: '',
                qtext: '',
                qscore: '',
                qactive: ''
            },
            
            photo: {
                recordid: '',
                FileName: '',
                img: ''
               
            }
        }
    },
    methods: {
        getTypes() {
            this.axios.get('/Look/GetQuestionTypes/QuestionTypes')
                .then(response => { this.selects.qtypes = response.data })
        },
        getCatgories() {
            this.axios.get('/Look/GetQuestionCategory/QuestionCategory')
                .then(response => { this.selects.qcategories = response.data })
        },
        getLang() {
            this.axios.get('/Look/GetLanguague/GetLanguague')
                .then(response => { this.selects.qlang = response.data })
        },
        save() {
            this.axios({
                method: 'post',
                url: '/Question/Create/CreateQuestion',
                data:
                {
                    questionTypeID: this.parm.qtypeid.id,
                    base64: this.photo.img,
                    categoryID: this.parm.qcategoryid.id,
                    lebel: this.parm.qtext,
                    point: this.parm.qscore,
                    isActive: this.parm.qactive,
                    fileName: 'static Name'                    
                    
                }
            }).then(x => { console.log(x) })
        },
        previewImage: function (event) {
            var input = event.target;
            if (input.files && input.files[0]) {
                // create a new FileReader to read this image and convert to base64 format
                var reader = new FileReader();
                // Define a callback function to run, when FileReader finishes its job
                reader.onload = (e) => {
                    // Note: arrow function used here, so that "this.imageData" refers to the imageData of Vue component
                    // Read image as base64 and set to imageData
                    this.photo.img = e.target.result;
                }
                // Start the reader job - read file as a data url (base64 format)
                reader.readAsDataURL(input.files[0]);
            }
        }
        
    },
    mounted() {
        this.getTypes()
        this.getCatgories()
        this.getLang()
    }
    //computed() {

    //}

    //components: {
    //    //Div_Img
    //}
    
}
