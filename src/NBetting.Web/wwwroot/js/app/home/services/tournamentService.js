'use strict';

function TournamentService() {
    function getTournamentsInProgress() {
        return [
            { name: "turniej#1", description: "To jest mój zarąbisty turniej w którym pozdrawiam all", startDate: "2016-09-20", finishDate: "2016-09-24" },
            { name: "turniej#2", description: "Mój drugi zarąbisty turniej w którym pozdrawiam all", startDate: "2016-09-20", finishDate: "2016-09-24" }
        ];
    }

    function getMyTournaments() {
        return [
            { name: "turniej#3", description: "To jest mój zarąbisty turniej w którym pozdrawiam all", startDate: "2016-09-20", finishDate: "2016-09-24" },
            { name: "turniej#4", description: "Mój drugi zarąbisty turniej w którym pozdrawiam all", startDate: "2016-09-20", finishDate: "2016-09-24" }
        ];
    }

    function getJoinableTournaments() {
        return [
            { name: "turniej#5", description: "Mój drugi zarąbisty turniej w którym pozdrawiam all", startDate: "2016-09-20", finishDate: "2016-09-24" }
        ];
    }

    this.getMyTournaments = getMyTournaments;
    this.getTournamentsInProgress = getTournamentsInProgress;
    this.getJoinableTournaments = getJoinableTournaments;
}

module.exports = TournamentService;