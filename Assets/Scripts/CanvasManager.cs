using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SocialPlatforms.GameCenter;

//Attach to canvas in 0Menu
public class CanvasManager : MonoBehaviour 
{
    private string TempText;

    private void Start()
    {
        TempText = Scene0MenuObjects.MostDaysFg.GetComponent<Text>().text;
        TempText += PlayerPrefs.GetInt(PPKeys.MostDaysSurvived).ToString();
        Scene0MenuObjects.MostDaysFg.GetComponent<Text>().text = TempText;
        Scene0MenuObjects.MostDaysBg.GetComponent<Text>().text = TempText;

        TempText = Scene0MenuObjects.WinsFg.GetComponent<Text>().text;
        TempText += PlayerPrefs.GetInt(PPKeys.Wins).ToString();
        Scene0MenuObjects.WinsFg.GetComponent<Text>().text = TempText;
        Scene0MenuObjects.WinsBg.GetComponent<Text>().text = TempText;

        LeaderBoardStuff();
    }

    private void LeaderBoardStuff()
    {
        if (!Social.localUser.authenticated)
            Social.localUser.Authenticate((bool success) => 
        { 
            if (success)
            {
                GameStateManager.Instance.LoggedIn = true; 
            }
        });
    }
}
