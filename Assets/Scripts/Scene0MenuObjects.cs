using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Attach to Main Camera in 0Menu
public class Scene0MenuObjects : MonoBehaviour 
{
    public static GameObject MuteButton;
    public static GameObject MostDaysFg;
    public static GameObject MostDaysBg;
    public static GameObject WinsFg;
    public static GameObject WinsBg;

    public GameObject MuteButtonRef;
    public GameObject MostDaysFgRef;
    public GameObject MostDaysBgRef;
    public GameObject WinsFgRef;
    public GameObject WinsBgRef;

    private void Awake()
    {
        MuteButton = MuteButtonRef;
        MostDaysFg = MostDaysFgRef;
        MostDaysBg = MostDaysBgRef;
        WinsFg = WinsFgRef;
        WinsBg = WinsBgRef;
    }
}
