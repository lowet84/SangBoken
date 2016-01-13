app.factory('saveSongService', ['$http', function ($http) {
    return function (id, song) {
        if (id == -1) {
            return $http.post('http://sangbokenapp.azurewebsites.net/api/Song/',song)
                .success(function (data) {
                    return data;
                })
                .error(function (err) {
                    return err;
                });
        }
        else {
            return $http.put('http://sangbokenapp.azurewebsites.net/api/Song/'+id,song)
                .success(function (data) {
                    return id;
                })
                .error(function (err) {
                    return err;
                });
        }
    };
}]);