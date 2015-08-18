defaultModule.controller("defaultController", function($scope, defaultService) {
    defaultService.getPersons().then(
        function(persons) {
            $scope.persons = persons;
        },
        function(response, status) {
            alert("The request failed with response " + response + " and status code " + status);
        });
});