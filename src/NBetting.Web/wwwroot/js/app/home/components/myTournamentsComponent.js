function MyTournamentsController($location, tournamentService) {
    var self = this;

    this.$onInit = function () {
        tournamentService.getMyTournaments().then(function (tournaments) {
            self.myTournaments = tournaments;
        });
    };

    self.onEditButtonClickedHandler = function (tournamentId) {
        if (self.onEditClicked) {
            self.onEditClicked({ $event: { id: tournamentId } });
        }
    }
}

MyTournamentsController.$inject = ['$location', 'TournamentService'];

var myTournamentsComponent = {
    name: 'myTournaments',
    controller: MyTournamentsController,
    templateUrl: '/views/home/my-tournaments-component.html',
    bindings: {
        onEditClicked: '&'
    }
};

module.exports = myTournamentsComponent;