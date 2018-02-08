var app;
(function () {
    app = angular.module('StatisticApi', ['angularUtils.directives.dirPagination']).config(['$httpProvider', function config($httpProvider) {
        $httpProvider.defaults.withCredentials = true;
    }]);
})();