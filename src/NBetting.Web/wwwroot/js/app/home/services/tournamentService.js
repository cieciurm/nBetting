'use strict';

function TournamentService($http, $q, ApiUrlsService) {
    function getTournamentsInProgress() {
        return [
            { name: "turniej#1", description: "To jest mój zarąbisty turniej w którym pozdrawiam all", startDate: "2016-09-20", finishDate: "2016-09-24" },
            { name: "turniej#2", description: "Mój drugi zarąbisty turniej w którym pozdrawiam all", startDate: "2016-09-20", finishDate: "2016-09-24" }
        ];
    }

    function getMyTournaments() {
        var deferred = $q.defer();

        var url = ApiUrlsService.getMyTournamentsUrl();

        $http
            .get(url)
            .then(function (response) {
                deferred.resolve(response.data);
            });

        return deferred.promise;
    }

    function getJoinableTournaments() {
        return [
            { name: "turniej#5", description: "Mój drugi zarąbisty turniej w którym pozdrawiam all", startDate: "2016-09-20", finishDate: "2016-09-24" }
        ];
    }

    this.getMyTournaments = getMyTournaments;
    this.getTournamentsInProgress = getTournamentsInProgress;
    this.getJoinableTournaments = getJoinableTournaments;
}

TournamentService.$inject = ['$http', '$q', 'ApiUrlsService'];

module.exports = TournamentService;