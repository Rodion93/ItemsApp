app.controller('StatController', function ($scope, StatisticApi) {
    getAll();

    function getAll() {
        var servCall = StatisticApi.getItems();
        servCall.then(function (d) {
            $scope.items = d.data;
        },
            function (error) {
                alert('Opps ' + error.exception);
            });
    }
}) 