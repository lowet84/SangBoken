'use strict';

angular.module('myApp.user-rights.isAdmin', [])

.directive('isAdmin', [ function() {
  return {
      template:'<div ng-if="isAdmin" ng-transclude></div>',
      transclude: true
      
  }
}]);
