using Xunit;
using FootballSimulator;

namespace FootballSimulator.Tests;

public class ClubTests
{
    // Mark method as automated test with [Fact]
    [Fact]
    public void Club_ShouldStoreItsName()
    {
        Club club = new Club("Central Coast Mariners"); // Arrange: Create a club with a specified name.

        string actualName = club.Name; // Act: Retrieve the club's name

        Assert.Equal("Central Coast Mariners", actualName); //Assert: Verify the stored name is correct.
    }

    [Fact]
    public void Club_ShouldStoreItsState()
    {
        Club club = new Club("Brisbane Roar", "QLD"); // Arrange

        string actualState = club.State; // Act

        Assert.Equal("QLD", actualState); // Assert
    }

    [Fact]
    public void Club_ShouldStoreItsId()
    {
        Club club = new Club("Perth Glory", "WA", 1); // Arrange

        int actualClubId = club.Id; // Act

        Assert.Equal(1, actualClubId); // Assert

    }

    [Fact]
    public void Club_ShouldRejectEmptyName()
    {
        string invalidName = ""; // Arrange: Define an invalid club name

        // Act/Assert: Check that creating a class with an invalid name
        // throws an exception
        Assert.Throws<ArgumentException>(() => new Club(invalidName));
    }

    [Fact]
    public void Club_ShouldRejectEmptyState()
    {
        string invalidState = ""; // Arrange: Define an invalid state name

        Assert.Throws<ArgumentException>(() => new Club("Valid Club FC", invalidState));
    }

    [Fact]
    public void Club_ShouldRejectWhiteSpaceName()
    {
        string invalidWhiteSpaceName = "  ";

        Assert.Throws<ArgumentException>(() => new Club(invalidWhiteSpaceName));
    }

    [Fact]
    public void Club_ShouldRejectWhiteSpaceState()
    {
        string invalidWhiteSpaceState = "  ";

        Assert.Throws<ArgumentException>(() => new Club("Chicken Skin United", invalidWhiteSpaceState));
    }

    [Fact]
    public void Club_ShouldRejectNullName()
    {
        string? nullClubName = null;

        Assert.Throws<ArgumentException>(() => new Club(nullClubName));
    }
}