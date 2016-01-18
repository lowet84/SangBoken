'use strict';

angular.module('myApp.editsong', ['ngRoute'])

    .config(['$routeProvider', function ($routeProvider) {
        $routeProvider.when('/editsong/:id', {
            templateUrl: 'views/editsong/editsong.html',
            controller: 'EditSongCtrl'
        });
    }])

    .controller('EditSongCtrl', ['editSongService', 'saveSongService', 'deleteSongService',
        '$scope', '$routeParams', '$location','$rootScope',
        function (editSongService, saveSongService, deleteSongService, $scope, $routeParams, $location,$rootScope) {
            if ($routeParams.id != -1) {
                editSongService($routeParams.id).success(function (data) {
                    $scope.song = data;
                    $rootScope.pageTitle = $scope.song.Name
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
                        $rootScope.goto('editsong',data);
                        
                    }
                });
            }
            $scope.delete = function () {
                deleteSongService($routeParams.id).success(function(data){
                    $rootScope.goto('song');
                });
            }
        }]);