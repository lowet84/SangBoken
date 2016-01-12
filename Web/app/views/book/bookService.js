app.factory('bookService', ['$http', function($http) {
    return $http.get('http://sangbokenapp.azurewebsites.net/api/songBook')
        .success(function(data) {
            return data;
        })
        .error(function(err) {
            return err;
        });
}]);