(function () {

    angular.module('jobPortalModule').factory('authenticationService', authenticationService);
    function authenticationService() {
        var isLoginAuthorized;//= false;
        var isAuthorized = function (credentials) {
            isLoginAuthorized = credentials.email != "" && credentials.password == "admin" ? true : false;
            return isLoginAuthorized;
        };
        return {
            isAuthorized: isAuthorized,
            getLoginAuthorized: function () {
                return isLoginAuthorized;
            }
        }
    };

})();
