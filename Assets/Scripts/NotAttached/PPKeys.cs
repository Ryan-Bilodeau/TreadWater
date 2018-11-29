using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Don't attach to anything
//Deals with PlayerPrefs
public class PPKeys : MonoBehaviour 
{
    public static string MuteState = "MuteState";           //0 is muted, 1 isn't
    public static string MostDaysSurvived = "MostDaysSurvived";
    public static string Wins = "Wins";

    //Switch mute state in player prefs
    public static void ChangeMuteState()
    {
        if (PlayerPrefs.GetInt(MuteState) == 0)
        {
            PlayerPrefs.SetInt(MuteState, 1);
            GameStateManager.Instance.Muted = false;
        }
        else
        {
            PlayerPrefs.SetInt(MuteState, 0);
            GameStateManager.Instance.Muted = true;
        }
    }

    //Return mute state from player prefs
    public static bool GetMuteState()
    {
        if (PlayerPrefs.GetInt(MuteState) == 0)
            return true;
        else
            return false;
    }
}
