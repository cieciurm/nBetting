'user strict';

function AddEditTournamentViewModel(name, description, startDate, endDate) {
    var self = this;
    self.name = name;
    self.description = description;
    self.starDate = startDate;
    self.endDate = endDate;
};

module.exports = AddEditTournamentViewModel;