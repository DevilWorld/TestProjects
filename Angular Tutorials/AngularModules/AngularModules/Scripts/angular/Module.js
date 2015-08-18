var eventModule = angular.module("eventModule", [])

eventModule.controller("eventController", function($scope) {
    $scope.books = [
        { id: 1, name: 'The Last Days' },
        { id: 2, name: 'The November Month' },
        { id: 2, name: 'Tora Tora Tora' }
    ];
});