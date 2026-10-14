namespace FootballSimulator;

// Football club class
public class Club
{
    // Can be read by other classes, but only changed internally
    public string Name { get; private set; }
    public string State { get; private set; }
    public int Id { get; private set; }

    // Constructor that runs when a new Club object is created
    // "this" invokes another constructor in the same class
    public Club(string name) : this(name, "Unknown")
    {
    }

    // Overloaded Constructor that runs when a new Club object is created
    public Club(string name, string state) : this(name, state, 0)
    {
    }

    // Overloaded Constructor that runs when a new Club object is created
    public Club(string name, string state, int clubId)
    {
        // Assign the supplied name to the club's Name, State and Id properties
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Club name must contain at least 1 letter");
        }
        if (string.IsNullOrWhiteSpace(state))
        {
            throw new ArgumentException("State name must contain at least 1 letter");
        }
        Name = name;

        State = state;

        Id = clubId;
    }
}