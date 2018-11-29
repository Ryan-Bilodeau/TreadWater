using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Attach to OceanManager in 1Main
//Manages moving the ocean
public class OceanManager : MonoBehaviour
{
    public float BackgroundXSpeed;
    public float BackgroundYSpeed;
    public float BackgroundYVariance;
    public float ForegroundXSpeed;
    public float ForegroundYSpeed;
    public float ForegroundYVariance;

    private GameObject Background;
    private GameObject Foreground;
    private GameObject[] BgOcean = new GameObject[3];
    private GameObject[] FgOcean = new GameObject[3];

    private Vector3 StartingBgPos;
    private Vector3 StartingFgPos;
    private float SpeedModifier = 1f;
    private float HeightModifer = 1f;
    private bool BgYIncreasing = true;
    private bool FgYIncreasing = true;

    private Vector3 TempPos;
    private float FramerateModifier;

    private void Awake()
    {
        Background = transform.GetChild(0).gameObject;
        Foreground = transform.GetChild(1).gameObject;
        StartingBgPos = Background.transform.position;
        StartingFgPos = Foreground.transform.position;
        PopulateArrays();
    }

    private void Start()
    {
        StartCoroutine(BgTiling());
        StartCoroutine(FgTiling());
    }

	private void Update()
	{
        if (Time.timeScale > 0f)            //Stops waves from moving on pause
        {
            FramerateModifier = Time.deltaTime * 60f;
			MoveBg();
            NewMoveFg();

            if (SceneManager.GetActiveScene().buildIndex == 1)
                SetWaterLevel();
        }
	}

    private void OnDisable()
    {
        StopAllCoroutines();            //Just to be safe
    }

    #region Private Methods
    //Moves foreground waves alternating up and down and to the right
    private void MoveBg()
    {
        TempPos = Background.transform.position;

        if (TempPos.y > StartingBgPos.y + (BackgroundYVariance * HeightModifer * .75f) && BgYIncreasing == true)
        {
            SpeedModifier = .5f;
        }
        else if (TempPos.y < StartingBgPos.y - (BackgroundYVariance * HeightModifer * .75f) && BgYIncreasing == false)
        {
            SpeedModifier = .5f;
        }

        if (TempPos.y > StartingBgPos.y + (BackgroundYVariance * HeightModifer) && BgYIncreasing == true)
        {
            HeightModifer = Random.Range(.4f, 1.4f);
            BgYIncreasing = false;
            SpeedModifier = 1f;
        }
        else if (TempPos.y < StartingBgPos.y - (BackgroundYVariance * HeightModifer) && BgYIncreasing == false)
        {
            HeightModifer = Random.Range(.4f, 1.4f);
            BgYIncreasing = true;
            SpeedModifier = 1f;
        }

        if (BgYIncreasing)
            TempPos.y += BackgroundYSpeed * SpeedModifier;
        else
            TempPos.y -= BackgroundYSpeed * SpeedModifier;

        TempPos.x += BackgroundXSpeed * FramerateModifier;
        Background.transform.position = TempPos;
    }

    private void NewMoveFg()
    {
        TempPos = Foreground.transform.position;
        TempPos.y = Background.transform.position.y - (StartingBgPos.y - StartingFgPos.y);
        TempPos.x += ForegroundXSpeed;
        Foreground.transform.position = TempPos;
    }

    //Moves background waves alternating up and down and to the right
    private void MoveFg()
    {
        TempPos = Foreground.transform.position;

        //Slow down wave movement at peak and trough
        if (TempPos.y > StartingFgPos.y + (ForegroundYVariance * HeightModifer * .75f) && FgYIncreasing == true)
            SpeedModifier = .5f;
        else if (TempPos.y < StartingFgPos.y - (ForegroundYVariance * HeightModifer * .75f) && FgYIncreasing == false)
            SpeedModifier = .5f;

        //Switch wave up and down movement
        if (TempPos.y > StartingFgPos.y + (ForegroundYVariance * HeightModifer) && FgYIncreasing == true)
        {
            FgYIncreasing = false;
            SpeedModifier = 1f;
        }
        else if (TempPos.y < StartingFgPos.y - (ForegroundYVariance * HeightModifer) && FgYIncreasing == false)
        {
            FgYIncreasing = true;
            SpeedModifier = 1f;
        }

        if (FgYIncreasing)
            TempPos.y += ForegroundYSpeed * SpeedModifier;
        else
            TempPos.y -= ForegroundYSpeed * SpeedModifier;

        TempPos.x += ForegroundXSpeed * FramerateModifier;
        Foreground.transform.position = TempPos;
    }

    //Call in Update - Sets WaterLevel position
    private void SetWaterLevel()
    {
		TempPos = Scene1MainObjects.WaterLevel.transform.position;
        TempPos.x = 0f;
		Scene1MainObjects.WaterLevel.transform.position = TempPos;
    }
    #endregion

    #region Coroutines
    //Call in Start - Manages Foreground ocean tiling
    private IEnumerator BgTiling()
    {
        while (gameObject.activeSelf)
        {
            foreach (var index in BgOcean)
            {
                if (index.transform.position.x > 8.25f)
                {
                    TempPos = index.transform.position;
                    TempPos.x -= 24.75f;
                    index.transform.position = TempPos;
                }
            }

            yield return new WaitForSeconds(.2f);
        }
    }

    //Call in Start - Manages Foreground ocean tiling
    private IEnumerator FgTiling()
    {
        while (gameObject.activeSelf)
        {
            foreach (var index in FgOcean)
            {
                if (index.transform.position.x > 8.25f)
                {
                    TempPos = index.transform.position;
                    TempPos.x -= 24.75f;
                    index.transform.position = TempPos;
                }
            }

            yield return new WaitForSeconds(.2f);
        }
    }
	#endregion

	#region Call in Awake
	//Load arrays 
	private void PopulateArrays()
	{
		for (int i = 0; i < 3; i++)
		{
			BgOcean[i] = transform.GetChild(0).GetChild(i).gameObject;
		}

		for (int i = 0; i < 3; i++)
		{
			FgOcean[i] = transform.GetChild(1).GetChild(i).gameObject;
		}
	}
    #endregion
}
