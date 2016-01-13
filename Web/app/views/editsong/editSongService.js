app.factory('editSongService', ['$http', function ($http) {
    return function (id) {
        return $http.get('http://sangbokenapp.azurewebsites.net/api/song/' + id)
            .success(function (data) {
                return data;
            })
            .error(function (err) {
                return err;
            });
    };
}]);