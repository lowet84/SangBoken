'use strict';

angular.module('myApp.user-rights.setAdmin', [])

.directive('setAdmin', ['$rootScope', function($rootScope) {
    var template = ['<div layout="row" layout-align="end">',
    '<md-button ng-if="isAdmin" ng-click="toggle()">Sluta editera</md-button>',
    '<md-button ng-if="!isAdmin" ng-click="toggle()">Editera</md-button>',
    '</div>'].join('\n')
  return {
      template:template,
      link:function(scope,element,attrs){
          scope.toggle = function(){
              $rootScope.isAdmin = !$rootScope.isAdmin;
          }
      },
      replace:true
      
  }
}]);
