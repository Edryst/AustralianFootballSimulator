namespace FootballSimulator;

// Football club class
public class Club
{
    // Can be read by other classes, but only changed internally
    public string Name { get; private set; }
    public string State { get; private set; }
    public int Id { get; private set; }
    public double Strength { get; private set; }

    // Constructor that runs when a new Club object is created
    // "this" invokes another constructor in the same class
    public Club(string name) : this(name, "Unknown") { }

    // Overloaded Constructor that runs when a new Club object is created
    public Club(string name, string state) : this(name, state, 0) { }

    // Overloaded Constructor that runs when a new Club object is created
    public Club(string name, string state, int clubId) : this(name, state, clubId, 2.5) { }

    // Overloaded Constructor that runs when a new Club object is created
    public Club(string name, string state, int clubId, double strength)
    {
        // Assign the supplied arguments to the club's Name, State, Id and Strength properties
        // Validate user input.
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Club name cannot be blank");
        }
        if (string.IsNullOrWhiteSpace(state))
        {
            throw new ArgumentException("State name cannot be blank");
        }
        if (strength < 1.0 || strength > 5.0 || double.IsNaN(strength))
        {
            throw new ArgumentException(
                "Please provide a valid strength between 1.0 and 5.0"
                );
        }
        Name = name;

        State = state;

        Id = clubId;

        Strength = strength;
    }
}