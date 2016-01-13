app.factory('saveSongService', ['$http', function ($http) {
    return function (id, song, callback) {
        if (id == -1) {
            $http.post('http://sangbokenapp.azurewebsites.net/api/Song/',song)
                .success(function (data) {
                    return callback(data);
                })
                .error(function (err) {
                    return err;
                });
        }
        else {
            var x = 0;
        }
    };
}]);