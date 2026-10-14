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

        // Act/Assert: Check that creating a class with an invalid state
        // throws an exception
        Assert.Throws<ArgumentException>(() => new Club("Valid Club FC", invalidState));
    }

    [Fact]
    public void Club_ShouldRejectWhiteSpaceName()
    {
        string invalidWhiteSpaceName = "  "; // Arrange: Define invalid white spaec name

        Assert.Throws<ArgumentException>(() => new Club(invalidWhiteSpaceName)); // Act/Assert
    }

    [Fact]
    public void Club_ShouldRejectWhiteSpaceState()
    {
        string invalidWhiteSpaceState = "  "; // Arrange: Define invalid white spaec state

        // Act/Assert
        Assert.Throws<ArgumentException>(() => new Club("Chicken Skin United", invalidWhiteSpaceState));
    }

    [Fact]
    public void Club_ShouldRejectNullName()
    {
        string? nullClubName = null;

        Assert.Throws<ArgumentException>(() => new Club(nullClubName));
    }

    [Fact]
    public void Club_ShouldStoreItsStrength()
    {
        Club club = new Club("Brisbane Roar", "QLD", 1, 2.8); // Arrange

        double strength = club.Strength; // Act

        Assert.Equal(2.8, strength);

    }

    [Fact]
    public void Club_ShouldRejectStrengthBelowMinimum()
    {
        // Arrange, Act and Assert
        // Attempt to create a club object with strength below minimum
        Assert.Throws<ArgumentException>(() =>
            new Club("Kipperfel United", "QLD", 99, 0.5));
    }

    [Fact]
    public void Club_ShouldRejectStrengthAboveMaximum()
    {
        // Arrange, Act and Assert
        // Attempt to create a club object with strength above maximum
        Assert.Throws<ArgumentException>(() =>
            new Club("The Slippery Eels", "QLD", 99, 5.9));
    }

    [Fact]
    public void Club_ShouldAcceptMinimumStrength()
    {
        Club club = new Club("Newcastle Jets", "NSW", 1, 1.0); // Arrange

        double terribleStrength = club.Strength; // Act

        Assert.Equal(1.0, terribleStrength);
    }

    [Fact]
    public void Club_ShouldAcceptMaximumStrength()
    {
        Club club = new Club("Central Coast Mariners", "NSW", 1, 5.0); // Arrange

        double highStrength = club.Strength; // Act

        Assert.Equal(5.0, highStrength);
    }

    [Fact]
    public void Club_ShouldRejectNaNStrength()
    {
        // Arrange, Act and Assert
        // Attempt to create a club object with strength NaN
        Assert.Throws<ArgumentException>(() =>
            new Club("Late Night Kebab FC", "QLD", 99, double.NaN));
    }
}
