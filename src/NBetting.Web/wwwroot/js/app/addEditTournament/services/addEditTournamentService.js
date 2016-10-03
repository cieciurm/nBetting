'use strict';

var AddEditTournamentViewModel = require('../viewModels/AddEditTournamentViewModel');

function AddEditTournamentService($http, $q, apiUrlsService) {
    var self = this;

    var saveTournament = function(tournament) {
        return $http.post(apiUrlsService.getAddEditTournamentUrl(), tournament);
    }

    var getTournament = function (id) {
        return $http.get(apiUrlsService.getTournamentUrl(id))
            .then(function (response) {
                var tournament = response.data;
                return new AddEditTournamentViewModel(tournament.id, tournament.name,
                    tournament.description, new Date(tournament.startDate), new Date(tournament.endDate), tournament.teams);
            });
    }

    self.addOrEditTournament = saveTournament;
    self.getTournament = getTournament;
}

AddEditTournamentService.$inject = ['$http', '$q', 'ApiUrlsService'];

module.exports = AddEditTournamentService;