'use strict';

var AddEditTournamentViewModel = require('../viewModels/addEditTournamentViewModel');

function AddEditTournamentFormComponentController() {
    var self = this;

    self.$onInit = function () {
        self.viewModel = new AddEditTournamentViewModel();
        self.viewModel.startDate = new Date();
        self.viewModel.addTeam({
            name: "Manchaster United"
        });
    }

    self.save = function (tournament) {
        //TODO
        console.log(tournament);
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

var AddEditTournamentFormComponent = {
    name: 'addEditTournamentForm',
    controller: AddEditTournamentFormComponentController,
    templateUrl: 'views/add-edit-tournament/add-edit-tournament-template.html'
}

module.exports = AddEditTournamentFormComponent;
