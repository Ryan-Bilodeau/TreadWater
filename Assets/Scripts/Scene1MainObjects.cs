using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Attach to MainCamera in 1Main
//Holds references to objects in 1main
public class Scene1MainObjects : MonoBehaviour 
{
    
    public static GameObject Sun;
    public static GameObject WaterLevel;            //Position set in OceanManager
    public static GameObject WaterMark;
    public static GameObject Head;
    public static GameObject ScoreBg;
    public static GameObject ScoreFg;
    public static GameObject UICanvas;
    public static GameObject PauseCanvas;
    public static GameObject MuteButton;
    public static GameObject RestartCanvas;
    public static GameObject Player;
    public static GameObject DirectionalLight;
    public static GameObject AdCanvas;
    public static GameObject ExtraLifeButton;
    public static GameObject CantReviveBg;
    public static GameObject CantReviveFg;

    public GameObject WaterLevelRef;
    public GameObject SunRef;
    public GameObject WaterMarkRef;
    public GameObject HeadRef;
    public GameObject ScoreBgRef;
    public GameObject ScoreFgRef;
    public GameObject UICanavsRef;
    public GameObject PauseCanvasRef;
    public GameObject MuteButtonRef;
    public GameObject RestartCanvasRef;
    public GameObject PlayerRef;
    public GameObject DirectionalLightRef;
    public GameObject AdCanvasRef;
    public GameObject ExtraLifeButtonRef;
    public GameObject CantReviveBgRef;
    public GameObject CantReviveFgRef;

    private void Awake()
    {
        Sun = SunRef;
        WaterLevel = WaterLevelRef;
        WaterMark = WaterMarkRef;
        Head = HeadRef;
        ScoreBg = ScoreBgRef;
        ScoreFg = ScoreFgRef;
        UICanvas = UICanavsRef;
        PauseCanvas = PauseCanvasRef;
        MuteButton = MuteButtonRef;
        RestartCanvas = RestartCanvasRef;
        Player = PlayerRef;
        DirectionalLight = DirectionalLightRef;
        AdCanvas = AdCanvasRef;
        ExtraLifeButton = ExtraLifeButtonRef;
        CantReviveBg = CantReviveBgRef;
        CantReviveFg = CantReviveFgRef;
    }
}
