'use strict';

function AddEditTournamentService($http, $q, apiUrlsService) {
    var self = this;

    var saveTournament = function(tournament) {
        return $http.post(apiUrlsService.getAddEditTournamentUrl(), tournament);
    }

    self.addOrEditTournament = saveTournament;
}

AddEditTournamentService.$inject = ['$http', '$q', 'ApiUrlsService'];

module.exports = AddEditTournamentService;