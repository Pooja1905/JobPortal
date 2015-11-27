(function () {
    angular.module('jobPortalModule').controller('RegistrationController', RegistrationController);

    RegistrationController.$inject = ['registrationService', '$location'];

    function RegistrationController(registrationService, $location) {
        var vm = this;

        vm.register = function (form) {
            if (form.$invalid)
                return;
            var res = registrationService.registerUser(vm.credentials);
            if (res) {
                $location.path('/Dashboard');
            } else {
                vm.isRegistered = false;
            }
        }
    }

})();