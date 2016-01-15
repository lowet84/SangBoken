app.factory('saveBookService', ['$http', function ($http) {
    return function (id, book) {
        if (id == -1) {
            return $http.post('http://sangbokenapp.azurewebsites.net/api/SongBook/',book)
                .success(function (data) {
                    return data;
                })
                .error(function (err) {
                    return err;
                });
        }
        else {
            return $http.put('http://sangbokenapp.azurewebsites.net/api/SongBook/'+id,book)
                .success(function (data) {
                    return id;
                })
                .error(function (err) {
                    return err;
                });
        }
    };
}]);