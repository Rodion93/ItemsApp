app.service('ItemService', function ($http) {
    this.getItems = function () {
        return $http.get('http://localhost:51020/api/items');
    }
    this.saveItems = function (item) {
        var url = 'http://localhost:51020/api/items'
        return $http(
            {
                method: 'post',
                data: item,
                url: url
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

    this.deleteItem = function (itemId) {
        var url = 'http://localhost:51020/api/items' + '/' + itemId
        return $http(
            {
                method: 'delete',
                data: itemId,
                url: url
            });
    }
});   