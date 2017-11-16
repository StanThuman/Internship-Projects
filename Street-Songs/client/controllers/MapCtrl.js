angular.module('street-songs')
.controller('MapCtrl', ['$scope', ($scope) => {
    $scope.map = {
     center: {
       latitude: 45,
       longitude: -73
     },
     zoom: 8,
     events: {}
   };
}]);
