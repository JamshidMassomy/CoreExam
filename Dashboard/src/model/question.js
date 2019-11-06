import Div_Img from '@/shared/Img.vue'
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
                Base64:''
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
                    categoryID: this.parm.qcategoryid.id,
                    lebel: this.parm.qtext,
                    point: this.parm.qscore,
                    isActive: this.parm.qactive
                }
            }).then(x => { console.log(x) })
        },
        savePhoto() {
            this.axios.get('/File/SavePhoto/{'+this.photo.recordid + '}/{' + this.photo.FileName + '}/${' + this.photo.Base64 + '}')
                .then(response => { this.selects.qlang = response.data })
        }
    },
    mounted(){
        this.getTypes()
        this.getCatgories()
        this.getLang()
    },
    components: {
        Div_Img
    }
    //computed() {
        
    //}
}
