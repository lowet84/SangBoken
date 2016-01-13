'use strict';

angular.module('myApp.editsong', ['ngRoute'])

    .config(['$routeProvider', function ($routeProvider) {
        $routeProvider.when('/editsong/:id', {
            templateUrl: 'views/editsong/editsong.html',
            controller: 'EditSongCtrl',
        });
    }])

    .controller('EditSongCtrl', ['editSongService', 'saveSongService', 'deleteSongService',
        '$scope', '$routeParams', '$location',
        function (editSongService, saveSongService, deleteSongService, $scope, $routeParams, $location) {
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
                saveSongService($routeParams.id, $scope.song).success(function(data) {
                    if($routeParams.id==-1) {
                        $location.path('/editsong/' + data);
                    }
                });
            }
            $scope.delete = function () {
                deleteSongService($routeParams.id).success(function(data){
                    $location.path('/song/');
                });
            }
        }]);