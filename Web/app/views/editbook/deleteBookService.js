app.factory('deleteBookService', ['$http', function ($http) {
    return function (id) {
        return $http.delete('http://sangbokenapp.azurewebsites.net/api/SongBook/'+id)
            .success(function (data) {
                return data;
            })
            .error(function (err) {
                return err;
            });
    };
}]);