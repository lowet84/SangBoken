'use strict';

angular.module('myApp.editsong', ['ngRoute'])

    .config(['$routeProvider', function ($routeProvider) {
        $routeProvider.when('/editsong/:id', {
            templateUrl: 'views/editsong/editsong.html',
            controller: 'EditSongCtrl',
        });
    }])

    .controller('EditSongCtrl', ['editSongService', 'saveSongService', '$scope', '$routeParams', '$location',
        function (editSongService, saveSongService, $scope, $routeParams, $location) {
            if ($routeParams.id != -1) {
                editSongService($routeParams.id).success(function (data) {
                    $scope.song = data;
                });
            }
            else {
                $scope.song = {
                    Name: "",
                    Line: ""
                }
            }
            $scope.save = function () {
                saveSongService($routeParams.id, $scope.song, function (data) {
                    $location.path('/editsong/' + data);
                });
            }
        }]);