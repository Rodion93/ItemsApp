app.service('APIService', function ($http) {
    this.getItems = function () {
        return $http.get('http://localhost:51020/api/items');
    }
    this.saveItems = function (item) {
        return $http(
            {
                method: 'post',
                data: item,
                url: 'http://localhost:51020/api/items'
            });
    }

    this.updateItem = function (item) {
        return $http(
            {
                method: 'put',
                data: item,
                url: 'http://localhost:51020/api/items'
            });
    }
});   