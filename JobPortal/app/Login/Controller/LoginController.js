(function () {
    angular.module('jobPortalModule').controller('LoginController', LoginController);

    LoginController.$inject = ['authenticationService','$location'];
    function LoginController(authenticationService, $location) {
        var vm = this;

        vm.login = function(form) {
            if (form.$invalid)
                return;
            var res = authenticationService.isAuthorized(vm.credentials);
                if (res) {
                    $location.path('/Dashboard');
                }
                else {
                    vm.isAuthorized = false;
                }

        }       
    }
})();

