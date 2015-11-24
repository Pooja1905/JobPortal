(function () {
  angular.module('jobPortalModule').config(appConfig);

  appConfig.$inject = ['$routeProvider', '$locationProvider'];
  function appConfig($routeProvider, $locationProvider) {    
    $routeProvider.when('/', {
      templateUrl: 'app/Login/Views/Login.html',
      controller: 'LoginController',
      controllerAs: 'vm'
    }).when('/Register', {
        templateUrl: 'app/Register/Views/Register.html',
        controller: 'RegistrationController',
        controllerAs: 'vm'
    }).when('/Dashboard', {
        templateUrl: 'app/Dashboard/Views/Dashboard.html',
        controller: 'DashboardController',
        controllerAs: 'vm'
    }).when('/Dashboard/:id', {
        templateUrl: 'app/Dashboard/Views/Dashboard.html',
        controller:'DashboardController',
        controllerAs: 'vm'        
    });
  }
})();