app.factory('songService', ['$http', function($http) {
    return function() {
        return $http.get('http://sangbokenapp.azurewebsites.net/api/song')
            .success(function (data) {
                return data;
            })
            .error(function (err) {
                return err;
            });
    }
}]);