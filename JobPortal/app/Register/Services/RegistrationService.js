(function () {

    angular.module('jobPortalModule').factory('registrationService', registrationService);
    registrationService.$inject = ['$http'];
    function registrationService($http)
    {
        var isRegistered = true;
        var register = function (credentials) {
            $http({
                method: 'POST',
                url: 'JobPortal.Api/api/HomeApi/RegisterUser',
                data: credentials
            }).then(function (response) {
                isRegistered = response.data.EmailAddress ? true : false;
                return isRegistered;
            });
        };
        return {
            registerUser: register
        }
    };

})();