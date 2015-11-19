(function () {

    angular.module('jobPortalModule').controller('DashboardController', DashboardController);

    DashboardController.$inject = ['authenticationService', '$location', '$routeParams', 'userInformation'];
    function DashboardController(authenticationService, $location, $routeParams, userInformation) {
        var vm = this;
        debugger;
        vm.user = "Pooja";
        vm.consultantList = [{ "name": "Adam" }, { "name": "Bindi" }, { "name": "Clara" }];
        vm.positionsList = [{ "description": ".Net Developer,6+ months, New York, NY" }, { "description": ".Net Developer,6+ months, Pittsburgh, PA" }];
        vm.isAuthorized = !authenticationService.getLoginAuthorized() ? false : true;
        if (authenticationService.getLoginAuthorized()) {
            //get data to populate the consultants list
        } else {
            $location.path('/');
        }
    }


})();
