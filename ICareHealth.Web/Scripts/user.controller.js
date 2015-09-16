/**
* @author Adriano Galesso Alves
* @requires  Angular.js
* @namespace ICareHelth.Web
*/


(function () {

    var app = angular.module('BestPlanApp', []);

    app.controller('BestPlanController', ['$scope', '$http', function ($scope, $http) {

        var bestPlan = this;

        bestPlan.user = {
            name: '',
            birthYear: new Date().getFullYear(),
            gender: 'M'
        };

        bestPlan.years = [];
        bestPlan.sending = false;
        bestPlan.hasResults = false;

        for (var i = 1900; i <= new Date().getFullYear(); i++) {
            bestPlan.years.push(i);
        }

        bestPlan.getBestPlan = function () {
            bestPlan.sending = true;

            $http.put(
                '/api/user/', bestPlan.user
            ).success(function (data) {
                bestPlan.hasResults = true;

                bestPlan.age = data.Age;
                bestPlan.user.plan = data.Plan;

            }).error(function (data) {
                console.log(data);
                alert('Sorry =/');
            });
        }
    }]);

    app.controller('UserController', ['$http', function ($http) {

        var user = this;

        user.list = [];
        user.fetching = true;
        user.empty = false;

        user.getAll = function () {
            $http.get(
                '/api/user/'
            ).success(function (data) {
                user.list = data;
                user.fetching = false;
                user.empty = user.list.length == 0;
            }).error(function (data) {
                console.log(data);
                alert('Sorry =/');
            });
        };

        user.getAll();

    }]);

})();