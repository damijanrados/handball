using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingLocation : PlayerScore
{
    
    private string PositionOfShooting;
    private string LocationOfShot;

    public ShootingLocation(string NameOfTheTeam, int JerseryNumber) : base(NameOfTheTeam, JerseryNumber)
    {
        
    }
}
