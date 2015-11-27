(function () {

    angular.module('jobPortalModule').factory('registrationService', registrationService);
    registrationService.$inject = ['$http'];
    function registrationService($http)
    {
        var isRegistered = true;
        var register = function (credentials) {
            $http({
                method: 'POST',
                url: 'http://localhost/api/account/AddUser',
                data: credentials
            }).then(function (response) {
                isRegistered = response.data>=0 ? true : false;
                return isRegistered;
            });
        };
        return {
            registerUser: register
        }
    };

})();