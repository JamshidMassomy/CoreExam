export default {
  items: [
    {
      name: 'Dashboard',
      url: '/admin/dashboard',
      icon: 'icon-speedometer'
    },
    {
      name: 'Question Manager',
      url: '/admin/QuestionRegistrations',
      icon:''
    },
    {
      name: 'Applicant Manager',
      url: '',
      icon: ''
    },
    //{
    //  name: 'colors',
    //  url: '/theme/colors',
    //  icon: 'icon-drop'
    //},
    {
      title: true,
      name: 'Components',
      class: '',
      wrapper: {
        element: '',
        attributes: {}
      }
    },
    {
      name: 'Base',
      url: '/base',
      icon: 'icon-puzzle',
      children: [
        {
          name: 'Breadcrumbs',
          url: '/base/breadcrumbs',
          icon: 'icon-puzzle'
        }
      ]
    }


  ]
}
