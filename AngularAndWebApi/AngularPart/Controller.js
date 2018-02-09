app.controller('ItemsController', function ($scope, ItemService) {
    getAll();

    function getAll() {
        var servCall = ItemService.getItems();
        servCall.then(function (d) {
            $scope.items = d.data;
        },
            function (error) {
                alert('Opps ' + error.exception);
            });
    }

    $scope.saveItem = function () {
        var item = {
            Name: $scope.name,
            Type: $scope.type
        };
        var saveItem = ItemService.saveItems(item);
        saveItem.then(function (d) {
            getAll();
        },
            function (error) {
                console.log('Oops! Something went wrong while saving the data.')
                alert('One of field is empty');
            })
    };

    $scope.makeEditable = function (obj) {
        obj.target.setAttribute("contenteditable", true);
        obj.target.focus();
    };

    $scope.updName = function (item, eve) {
        item.Name = eve.currentTarget.innerText;
        var upd = ItemService.updateItem(item);
        upd.then(function (d) {
            getAll();
        }, function (error) {
            console.log('Oops! Something went wrong while updating the data.')
        })
    };

    $scope.updType = function (item, eve) {
        item.Type = eve.currentTarget.innerText;
        var upd = ItemService.updateItem(item);
        upd.then(function (d) {
            getAll();
        }, function (error) {
            console.log('Oops! Something went wrong while updating the data.')
        })
    };

    $scope.dltItem = function (itemId) {
        var dlt = ItemService.deleteItem(itemId);
        dlt.then(function (d) {
            getAll();
        }, function (error) {
            console.log('Oops! Something went wrong while deleting the data.')
            alert('Failed while deleting the data. Error message - ' + error.message);
        })
    };
}) 