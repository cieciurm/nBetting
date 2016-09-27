function MyTournamentsController(tournamentService) {
    var vm = this;

    this.$onInit = function () {
        tournamentService.getMyTournaments().then(function(tournaments) {
            vm.myTournaments = tournaments;
        });
    };
}

MyTournamentsController.$inject = ['TournamentService'];

var myTournamentsComponent = {
    name: 'myTournaments',
    controller: MyTournamentsController,
    templateUrl: '/views/home/my-tournaments-component.html'
};

module.exports = myTournamentsComponent;