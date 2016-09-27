'user strict';

function AddEditTournamentViewModel(name, description, startDate, endDate) {
    var self = this;
    self.name = name;
    self.description = description;
    self.starDate = startDate;
    self.endDate = endDate;
    self.teams = [];

    self.addNewTeam = function() {
        self.teams.push({
            id: getMinTransientId(),
            name: ""
        });
    }

    self.addTeam = function (team) {
        if (!team) {
            throw "Team can't be null";
        }

        var id = getMinTransientId();
        team.id = id;
        self.teams.push(team);
    }

    self.removeTeamById = function(id) {
        for (var i = 0; i < self.teams.length; i++) {
            if (self.teams[i].id == id) {
                self.teams.splice(i, 1);
            }
        }
    }

    self.updateTeam = function(team) {
        var teamToUpdate = getTeamById(team.id);
        teamToUpdate.name = team.name;
    }

    function getMinTransientId() {
        var minId = 0;
        for (var i = 0; i < self.teams.length; i++) {
            if (self.teams[i].id < minId)
                minId = self.teams[i].id;
        }

        return --minId;
    }

    function getTeamById(id) {
        for (var i = 0; i < self.teams.length; i++) {
            if (self.teams[i].id == id) {
                return self.teams[i];
            }
        }
    }
};

module.exports = AddEditTournamentViewModel;