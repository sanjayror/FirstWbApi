/// <reference path="D:\PracticeProject\FirstWbApi\FirstWbApi\Scripts/angulercdn.js" />



var app1 = angular.module("myapp", []);
app1.controller("LoginCtrl", function ($scope,$http) {
    $scope.GetUser();
    $scope.GetUser = function () {
        var abc = $http({
            method: "Post",
            Type: "User",
            Url: ("http://localhost:14943/api/First/LoginPage")
        });
    }

});