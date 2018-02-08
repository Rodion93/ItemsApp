app.service('StatisticApi', function ($http) {
    this.getItems = function () {
        return $http.get('http://localhost:51020/api/statistic');
    }
});   