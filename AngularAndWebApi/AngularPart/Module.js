﻿var app;
(function () {
    app = angular.module('ItemModule', ['angularUtils.directives.dirPagination']).config(['$httpProvider', function config($httpProvider) {
        $httpProvider.defaults.withCredentials = true;
    }]);
})();