(function () {
   
    angular.module('jobPortalModule').factory( 'authenticationService', authenticationService);

    authenticationService.$inject = ['$http'];
    function authenticationService($http) {
        var isLoginAuthorized;//= false;
        var isAuthorized = function(credentials) {
            return $http({
                method: 'POST',
                url: 'api/HomeApi/AuthorizeUser',
                data: credentials
            }).then(function (response) {
                isLoginAuthorized = response.data.EmailAddress ? true : false;
                return isLoginAuthorized;
            });
        };
        return {
            isAuthorized: isAuthorized,
            getLoginAuthorized: function () {
                return isLoginAuthorized;
            }
        }
    };

})();
