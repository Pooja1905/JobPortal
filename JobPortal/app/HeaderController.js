(function () {
    angular.module('jobPortalModule').controller('HeaderController', HeaderController);
   

    HeaderController.$inject = ['$scope', '$location'];
    function HeaderController($scope, $location) {
        var vm = this;
        vm.isActive = function (viewLocation) {
            return viewLocation === $location.path();
        }
    }
})();