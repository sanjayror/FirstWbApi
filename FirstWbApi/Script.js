
var App = angular.module("myapp", []);
App.controller("myctrl", function ($scope, $http) {
    
        var abc = $http.get('http://localhost:14943/api/First/GetAllUser').then(function (response) {
            $scope.Mem = response.data;
        });
    
  //function GetdatabyId(){
  //      var abc = $http.get('http://localhost:14943/api/First').then(function (response) {
  //          $scope.Mem = response.data;
  //      });
  //  }

});
