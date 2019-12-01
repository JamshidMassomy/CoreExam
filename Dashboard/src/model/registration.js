
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
                .then(response => { this.select.testTypes = response.data })        }
        
    },
    mounted() {
        this.getGenderTypes()
        this.getAccessLevelTypes()
        this.getTestTypes()
    }
}
