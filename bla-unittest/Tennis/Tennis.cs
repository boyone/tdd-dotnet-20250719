



using System.Data.Common;
using System.Diagnostics;

namespace Tennis;

public class Tennis
{
    int ScoreA;
    int ScoreB;

    public void AWin()
    {
        ScoreA++;
    }

    public void BWin()
    {
        ScoreB++;
    }

    public string GetScore()
    {
        if (ScoreA >= 4 && (ScoreA - ScoreB >= 2))
        {
            return "Win-for-A";
        }
        if (ScoreB - ScoreA >= 2 && ScoreB >= 4)
        {
            return "Win-for-B";
        }
        if (ScoreA >= 3 && ScoreB >= 3 && (ScoreA - ScoreB == 1))
        {
            return "Match point A-advantage";
        }
        if (ScoreA == ScoreB && ScoreA >= 3)
        {
            return "Deuce";
        }



        string txtA = getTextScore(ScoreA);
        string txtB = getTextScore(ScoreB);
        return $"{txtA}-{txtB}";
    }

    private string getTextScore(int score)
    {
        switch (score)
        {
            case 1:
                return "Fifteen";
            case 2:
                return "Thirty";
            case 3:
                return "Forty";
            default:
                return "Love";
        }
    }

}
