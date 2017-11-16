angular.module('street-songs')
.controller('GoogleCtrl', ['$scope', function ($scope) {
    
    $scope.map = {
     center: {
       latitude: 45,
       longitude: -73
     },
     zoom: 8,
     events: {}
   };
}]);
