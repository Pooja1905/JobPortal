(function () {

    angular.module('jobPortalModule').factory('registrationService', registrationService);
    function registrationService() {
        var isRegistered = true;
        return {
            isRegistered: isRegistered,
            registerUser: function (form) {

                return isRegistered;
            }
        }
    };

})();