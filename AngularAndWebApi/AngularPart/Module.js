var app;
(function () {
    app = angular.module('APIModule', []).config(['$httpProvider', function config($httpProvider) {
        $httpProvider.defaults.withCredentials = true;
    }]);
})();