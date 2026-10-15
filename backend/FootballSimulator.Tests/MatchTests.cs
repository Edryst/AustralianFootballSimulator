using Xunit;
using FootballSimulator;

namespace FootballSimulator.Tests;

public class MatchTests
{
    [Fact]
    public void Match_ShouldStoreHomeAwayClubs()
    {
        // Arrange - Create two club objects and a match object
        Club club_1 = new Club("Central Coast Mariners", "NSW", 1, 5.0);
        Club club_2 = new Club("Newcastle Jets", "NSW", 2, 1.0);

        Match match = new Match(club_1, club_2);

        // Act and Assert. Verify the names of the clubs within the match are correct.
        Assert.Same(club_1, match.HomeClub);
        Assert.Same(club_2, match.AwayClub);
    }

    [Fact]
    public void Match_ShouldRejectSameClub()
    {
        // Arrange 
        Club monocle = new Club("FC Monocle", "NSW", 2, 1.0);
        // Act/Assert
        Assert.Throws<ArgumentException>(() =>
            new Match(monocle, monocle));
    }

    [Fact]
    public void Match_ShouldRejectClubsWithSameId()
    {
        // Arrange 
        Club club_1 = new Club("Backwater Porkmincers", "NSW", 1, 5.0);
        Club club_2 = new Club("South Sea Herring", "NSW", 1, 1.0);

        // Act/Assert
        Assert.Throws<ArgumentException>(() =>
            new Match(club_1, club_2));
    }

    [Fact]
    public void Match_ShouldRejectNullHomeClub()
    {
        // Arrange 
        Club club_2 = new Club("South Sea Herring", "NSW", 2, 1.0);

        // Act/Assert
        Assert.Throws<ArgumentException>(() =>
            new Match(null, club_2));
    }

    [Fact]
    public void Match_ShouldRejectNullAwayClub()
    {
        // Arrange 
        Club club_1 = new Club("The Warlocks", "SA", 23, 1.6);

        // Act/Assert
        Assert.Throws<ArgumentException>(() =>
            new Match(club_1, null));
    }

    [Fact]
    public void Match_ShouldStartWithNoScore()
    {
        // Arrange
        Club homeClub = new Club("Rapid Jazz FC", "NSW", 1, 2.2);
        Club awayClub = new Club("Bacon Grease United", "SA", 423, 1.4);

        Match match = new Match(homeClub, awayClub);

        //Act //Assert
        Assert.Null(match.HomeScore);
        Assert.Null(match.AwayScore);
    }

    [Fact]
    public void Match_ShouldRecordFinalScore()
    {
        // Arrange
        Club homeClub = new Club("Crusty Mustard CF", "VIC", 132, 1.2);
        Club awayClub = new Club("Underwater", "TAS", 34, 1.4);

        Match match = new Match(homeClub, awayClub);

        match.RecordResult(3, 1); // Act

        // Assert
        Assert.Equal(3, match.HomeScore);
        Assert.Equal(1, match.AwayScore);

    }

    [Fact]
    public void Match_ShouldRejectNegativeHomeScore()
    {
        // Arrange
        Club homeClub = new Club("Crusty Mustard CF", "VIC", 132, 1.2);
        Club awayClub = new Club("Underwater", "TAS", 34, 1.4);

        Match match = new Match(homeClub, awayClub);

        // Act // Assert
        Assert.Throws<ArgumentException>(() => match.RecordResult(-1, 2));

    }

    [Fact]
    public void Match_ShouldRejectNegativeAwayScore()
    {
        // Arrange
        Club homeClub = new Club("Crusty Mustard CF", "VIC", 132, 1.2);
        Club awayClub = new Club("Underwater", "TAS", 34, 1.4);

        Match match = new Match(homeClub, awayClub);

        // Act // Assert
        Assert.Throws<ArgumentException>(() => match.RecordResult(14, -2));

    }
}
