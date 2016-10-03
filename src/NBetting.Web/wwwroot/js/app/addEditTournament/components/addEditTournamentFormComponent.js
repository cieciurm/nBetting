'use strict';

var AddEditTournamentViewModel = require('../viewModels/addEditTournamentViewModel');

function AddEditTournamentFormComponentController(addEditTournamentService) {
    var self = this;

    self.$onInit = function () {
        if (self.config && self.config.isEdit && self.config.id) {
            edit(self.config.id);
        } else {
            add();
        }
    }

    function edit(id) {
        addEditTournamentService.getTournament(id)
            .then(function (tournament) {
                self.viewModel = tournament;
            });
    }

    function add() {
        self.viewModel = new AddEditTournamentViewModel();
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

    self.addTeam = function () {
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
        onTournamentSaved: '&',
        config: '<'
    }
}

module.exports = AddEditTournamentFormComponent;
