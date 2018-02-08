var app;
(function () {
    app = angular.module('APIModule', ['angularUtils.directives.dirPagination']).config(['$httpProvider', function config($httpProvider) {
        $httpProvider.defaults.withCredentials = true;
    }]);
})();