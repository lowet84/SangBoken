app.factory('editBookService', ['$http', function ($http) {
    return function (id) {
        return $http.get('http://sangbokenapp.azurewebsites.net/api/songbook/' + id)
            .success(function (data) {
                return data;
            })
            .error(function (err) {
                return err;
            });
    };
}]);