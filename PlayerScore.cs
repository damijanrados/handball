using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : TeamName
{
    public int JerseryNumber;
    public int GoalsScored;
    public int GoalsMissed;

    public PlayerScore(string NameOfTheTeam, int JerseryNumber) : base (NameOfTheTeam)
    {
        this.JerseryNumber = JerseryNumber;
    }
}
