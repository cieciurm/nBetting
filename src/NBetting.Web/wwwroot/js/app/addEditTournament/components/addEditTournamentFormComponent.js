'use strict';

var AddEditTournamentViewModel = require('../viewModels/addEditTournamentViewModel');

function AddEditTournamentFormComponentController() {
    var self = this;

    self.$onInit = function () {
        self.viewModel = new AddEditTournamentViewModel();
        self.viewModel.startDate = new Date();
    }

    self.save = function (tournament) {
        //TODO
        console.log(tournament);
    }
}

var AddEditTournamentFormComponent = {
    name: 'addEditTournamentForm',
    controller: AddEditTournamentFormComponentController,
    templateUrl: 'views/add-edit-tournament/add-edit-tournament-template.html'
}

module.exports = AddEditTournamentFormComponent;
