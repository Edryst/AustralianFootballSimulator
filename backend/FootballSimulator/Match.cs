using System.Runtime.Serialization;

namespace FootballSimulator;

// Football match class
public class Match
{
    // Can be read by other classes, but only changed internally
    public Club HomeClub { get; private set; }
    public Club AwayClub { get; private set; }

    public int? HomeScore { get; private set; }
    public int? AwayScore { get; private set; }

    // Constructor that runs when a new Match object is created
    public Match(Club homeClub, Club awayClub)
    {
        // Assign the supplied arguments to the home and away club properties
        // Validate user input.
        if (homeClub == null || awayClub == null)
        {
            throw new ArgumentException("Two valid teams must be selected for the match");
        }
        if (homeClub.Id == awayClub.Id)
        {
            throw new ArgumentException("The two teams must be different");
        }

        HomeClub = homeClub;
        AwayClub = awayClub;
    }

    public void RecordResult(int homeScore, int awayScore)
    {
        if (homeScore < 0 || awayScore < 0)
        {
            throw new ArgumentException("Teams can't score in negative goals");
        }

        HomeScore = homeScore;
        AwayScore = awayScore;
    }
}