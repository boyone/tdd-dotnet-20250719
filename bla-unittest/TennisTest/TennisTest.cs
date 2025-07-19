
namespace TennisTest;

public class TennisTest
{
    [Fact]
    public void StartGame_Score_is_Love_Love()
    {
        // Arrange
        var ExpectedScore = "Love-Love";
        var Tennis = new Tennis.Tennis();

        // Act
        string ActualScore = Tennis.GetScore();

        // Assert
        Assert.Equal(ExpectedScore, ActualScore);
    }

    [Fact]
    public void A_Win_1_and_B_Lose_0_Score_is_Fifteen_Love()
    {
        // Arrange
        var ExpectedScore = "Fifteen-Love";
        var Tennis = new Tennis.Tennis();

        // Act
        Tennis.AWin();
        string ActualScore = Tennis.GetScore();

        // Assert
        Assert.Equal(ExpectedScore, ActualScore);
    }

    [Fact]
    public void A_Win_2_and_B_Lose_0_Score_is_Thirty_Love()
    {
        // Arrange
        var ExpectedScore = "Thirty-Love";
        var Tennis = new Tennis.Tennis();

        // Act
        Tennis.AWin();
        Tennis.AWin();
        string ActualScore = Tennis.GetScore();

        // Assert
        Assert.Equal(ExpectedScore, ActualScore);
    }

    [Fact]
    public void A_Lose_2_and_B_Win_1_Score_is_Thirty_Fifteen()
    {
        // Arrange
        var ExpectedScore = "Thirty-Fifteen";
        var Tennis = new Tennis.Tennis();

        // Act
        Tennis.AWin();
        Tennis.AWin();
        Tennis.BWin();
        string ActualScore = Tennis.GetScore();

        // Assert
        Assert.Equal(ExpectedScore, ActualScore);
    }
    [Fact]
    public void A_Win_3_and_B_Lose_1_Score_is_Forty_Fifteen()
    {
        // Arrange
        var ExpectedScore = "Forty-Fifteen";
        var Tennis = new Tennis.Tennis();

        // Act
        Tennis.AWin();
        Tennis.AWin();
        Tennis.BWin();
        Tennis.AWin();
        string ActualScore = Tennis.GetScore();

        // Assert
        Assert.Equal(ExpectedScore, ActualScore);
    }

    [Fact]
    public void A_Win_4_and_B_Lose_1_Score_is_Win_for_A()
    {
        // Arrange
        var ExpectedScore = "Win-for-A";
        var Tennis = new Tennis.Tennis();

        // Act
        Tennis.AWin();
        Tennis.AWin();
        Tennis.BWin();
        Tennis.AWin();
        Tennis.AWin();
        string ActualScore = Tennis.GetScore();

        // Assert
        Assert.Equal(ExpectedScore, ActualScore);
    }

    [Fact]
    public void A_3_and_B_3_Score_is_Deuce()
    {
        // Arrange
        var ExpectedScore = "Deuce";
        var Tennis = new Tennis.Tennis();

        // Act
        Tennis.AWin();
        Tennis.AWin();
        Tennis.BWin();
        Tennis.AWin();
        Tennis.BWin();
        Tennis.BWin();
        string ActualScore = Tennis.GetScore();

        // Assert
        Assert.Equal(ExpectedScore, ActualScore);
    }

    [Fact]
    public void A_4_and_B_4_Score_is_Deuce()
    {
        // Arrange
        var ExpectedScore = "Deuce";
        var Tennis = new Tennis.Tennis();

        // Act
        Tennis.AWin();
        Tennis.AWin();
        Tennis.AWin();
        Tennis.BWin();
        Tennis.AWin();
        Tennis.BWin();
        Tennis.BWin();
        Tennis.BWin();
        string ActualScore = Tennis.GetScore();

        // Assert
        Assert.Equal(ExpectedScore, ActualScore);
    }

    [Fact]
    public void A_5_and_B_5_Score_is_Deuce()
    {
        // Arrange
        var ExpectedScore = "Deuce";
        var Tennis = new Tennis.Tennis();

        // Act
        Tennis.AWin();
        Tennis.AWin();
        Tennis.AWin();
        Tennis.BWin();
        Tennis.BWin();
        Tennis.BWin();
        Tennis.AWin();
        Tennis.BWin();
        Tennis.AWin();
        Tennis.BWin();

        string ActualScore = Tennis.GetScore();

        // Assert
        Assert.Equal(ExpectedScore, ActualScore);
    }

    [Fact]
    public void A_6_and_B_5_Score_is_advantage()
    {
        // Arrange
        var ExpectedScore = "Match point A-advantage";
        var Tennis = new Tennis.Tennis();

        // Act
        Tennis.AWin();
        Tennis.AWin();
        Tennis.AWin();
        Tennis.BWin();
        Tennis.BWin();
        Tennis.BWin();
        Tennis.AWin();
        Tennis.BWin();
        Tennis.AWin();
        Tennis.BWin();
        Tennis.AWin();
        string ActualScore = Tennis.GetScore();

        // Assert
        Assert.Equal(ExpectedScore, ActualScore);
    }
[Fact]
    public void A_5_and_B_7_Score_is_advantage()
    {
        // Arrange
        var ExpectedScore = "Win-for-B";
        var Tennis = new Tennis.Tennis();

        // Act
        Tennis.AWin();
        Tennis.AWin();
        Tennis.AWin();
        Tennis.BWin();
        Tennis.BWin();
        Tennis.BWin();
        Tennis.AWin();
        Tennis.BWin();
        Tennis.AWin();
        Tennis.BWin();
        Tennis.BWin();
        Tennis.BWin();
        string ActualScore = Tennis.GetScore();

        // Assert
        Assert.Equal(ExpectedScore, ActualScore);
    }

}
