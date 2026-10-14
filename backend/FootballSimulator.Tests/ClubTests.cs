using Xunit;
using FootballSimulator;

namespace FootballSimulator.Tests;

public class ClubTests
{
    // Mark method as automated test with [Fact]
    [Fact]
    public void Club_ShouldStoreItsName()
    {
        // Arrange: Create a club with a specified name.
        Club club = new Club("Central Coast Mariners");


        // Act: Retrieve the club's name
        string actualName = club.Name;


        //Assert: Verify the stored name is correct.
        Assert.Equal("Central Coast Mariners", actualName);
    }

    [Fact]
    public void Club_ShouldStoreItsState()
    {
        // Arrange
        Club club = new Club("Brisbane Roar", "QLD");

        // Act
        string actualState = club.State;

        // Assert
        Assert.Equal("QLD", actualState);
    }

    [Fact]
    public void Club_ShouldStoreItsId()
    {
        // Arrange
        Club club = new Club("Perth Glory", "WA", 1);

        // Act
        int actualClubId = club.Id;

        // Assert
        Assert.Equal(1, actualClubId);

    }
}