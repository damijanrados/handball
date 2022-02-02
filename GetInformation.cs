using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GetInformation : MonoBehaviour
{
    public TMP_InputField TeamNameInput;


    public void onButtonClickInput()
    {
        TeamName team = new TeamName(TeamNameInput.text);
        Debug.Log(team.NameOfTheTeam);
    }
}
