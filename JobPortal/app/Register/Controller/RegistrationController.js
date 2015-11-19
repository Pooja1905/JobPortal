(function () {
    angular.module('jobPortalModule').controller('RegistrationController', RegistrationController);

    RegistrationController.$inject = ['registrationService', '$location'];

    function RegistrationController(registrationService, $location) {
        var vm = this;

        vm.register = function (form) {
            if (form.$invalid)
                return;
            var res = registrationService.isRegistered(form);
            if (res) {
                $location.path('/Dashboard');
            }            
        }
    }

})();