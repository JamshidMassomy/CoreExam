
export default {
    name: 'registration',
    data() {
        return {
            select:
            {
                genderType: [],
                accessLevelType: [],
                testTypes: []
            },
            student: {
                name: '',
                fatherName: '',
                nid: '',
                phone:'',
                email: '',
                genderId:''
            },
            registration: {
                testID: '',
                accessLevelID:''
            } 
        }
    },
    methods: {
        getGenderTypes() {
            this.axios.get('/Look/GetGenders/GetGenderTypes')
                .then(response => { this.select.genderType = response.data })
        },
        getAccessLevelTypes() {
            this.axios.get('/Look/GetAccessLevels/GetAccessLevels')
                .then(response => { this.select.accessLevelType = response.data })
        },
        getTestTypes() {
            this.axios.get('/Look/GetTests/GetTestTypes')
                .then(response => { this.select.testTypes = response.data })
        },
        save() {
            this.axios({
                method: 'post',
                url: '/Registration/Create/Registration',
                data:
                {
                    name: this.student.name,
                    fathername: this.student.fathername,
                    nid: this.student.nid,
                    email: this.student.email,
                    phone: this.student.phone,
                    genderId:this.student.genderId.id,
                    testID: this.registration.testID.id,
                    accessLevelID: this.registration.accessLevelID.id
                }
            }).then(x => { console.log(x) })
        },
    },
    mounted() {
        this.getGenderTypes()
        this.getAccessLevelTypes()
        this.getTestTypes()
    }
}
