var eventModule = angular.module("eventModule", []);

eventModule.controller("eventController", function ($scope) {
    $scope.talks = [{ id: 1001, name: 'Tommie' }, { id: 1002, name: 'Kristen' }];
});