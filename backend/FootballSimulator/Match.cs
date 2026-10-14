namespace FootballSimulator;

// Football match class
public class Match
{
    // Can be read by other classes, but only changed internally
    public Club HomeClub { get; private set; }
    public Club AwayClub { get; private set; }

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
}