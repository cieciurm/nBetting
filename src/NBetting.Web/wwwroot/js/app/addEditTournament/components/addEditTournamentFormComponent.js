'use strict';

var AddEditTournamentViewModel = require('../viewModels/addEditTournamentViewModel');

function AddEditTournamentFormComponentController(addEditTournamentService) {
    var self = this;

    self.$onInit = function () {
        self.viewModel = new AddEditTournamentViewModel();
        self.viewModel.startDate = new Date();
        self.viewModel.addTeam({
            name: "Manchaster United"
        });
    }

    self.save = function (tournament) {
        if (self.form.$invalid)
            return;

        addEditTournamentService.addOrEditTournament(tournament)
            .then(function () {
                onTournamentSavedHandler();
            });
    }

    function onTournamentSavedHandler() {
        if (self.onTournamentSaved) {
            self.onTournamentSaved();
        }
    }

    self.addTeam = function() {
        self.viewModel.addNewTeam();
    }

    self.onTeamDeleted = function ($event) {
        var id = $event.id;
        self.viewModel.removeTeamById(id);
    }

    self.onTeamChanged = function ($event) {
        self.viewModel.updateTeam($event.team);
    }
}

AddEditTournamentFormComponentController.$inject = ['AddEditTournamentService'];

var AddEditTournamentFormComponent = {
    name: 'addEditTournamentForm',
    controller: AddEditTournamentFormComponentController,
    templateUrl: 'views/add-edit-tournament/add-edit-tournament-template.html',
    bindings: {
        onTournamentSaved: '&'
    }
}

module.exports = AddEditTournamentFormComponent;
