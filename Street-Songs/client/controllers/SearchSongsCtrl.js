angular.module('street-songs')
.controller('SearchSongsCtrl', ['$scope', ($scope) => {
  $scope.songs = [];
  for (i = 0; i < 50; i++) {
    $scope.songs.push({
      art: faker.image.cats(50, 50),
      name: faker.lorem.sentence(),
      album: faker.lorem.sentence(),
      artist: faker.fake('{{name.firstName}} {{name.lastName}}')
    });
  }
}]);
