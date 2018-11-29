using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//Attach to DayAndNightCycle in 1Main
//Manages the Day/Night cycle
public class DayNightManager : MonoBehaviour
{
    public static int Day;

    public float RotationSpeed;

    private float Angle;            //Used to change LightDimmerCanvas alpha and Sky y position
    private Vector3 NewRot;         //This transform's rotation
    private Vector3 DirLightRot;
    private float FramerateModifier;

    private int StartingDaySize;
    private int DaySize;
    private float DayAngle;         //Used to change day count
    private float LastAngle;
    private bool CanIncremenetDay;
    private bool StopIncrementingDay;

    private bool Animating;

    private void Start()
    {
        Day = 0;
        StartingDaySize = Scene1MainObjects.ScoreFg.GetComponent<Text>().fontSize;
    }

    private void Update()
    {
        FramerateModifier = Time.deltaTime * 60f;
        RotateSunAndMoon();
        ManageLight();
        IncreaseDay();
    }

    #region Private Methods
    //Call in Update
    private void RotateSunAndMoon()
    {
        NewRot = transform.rotation.eulerAngles;
        NewRot.z += RotationSpeed * FramerateModifier;

        transform.rotation = Quaternion.Euler(NewRot);
        Scene1MainObjects.Sun.transform.rotation = Quaternion.Euler(Vector3.zero);
    }

    //Call in Update - Changes LightDimmerCanvas alpha based on Angle
    public void ManageLight()
    {
        Angle = Vector2.Angle(Vector2.up, transform.right);
        DayAngle = Vector2.Angle(Vector2.right, transform.right);
        DirLightRot = Scene1MainObjects.DirectionalLight.transform.rotation.eulerAngles;
        DirLightRot.x = 40 + (20 * (Angle / 180f));
        Scene1MainObjects.DirectionalLight.transform.rotation = Quaternion.Euler(DirLightRot);
    }

    //Call in Update - Updates Day
    private void IncreaseDay()
    {
        if (DayAngle > LastAngle && CanIncremenetDay && !GameStateManager.Instance.PlayerLost && !StopIncrementingDay) 
        {
            Day++;
            Scene1MainObjects.ScoreBg.GetComponent<Text>().text = Day.ToString();
            Scene1MainObjects.ScoreFg.GetComponent<Text>().text = Day.ToString();
            AudioManager.Instance.PlayDayIncreaseClip();
            StartCoroutine(IncreaseDayAnimation());

			if (Day >= 365 && !GameStateManager.Instance.WinsSet)
			{
				PlayerPrefs.SetInt(PPKeys.Wins, PlayerPrefs.GetInt(PPKeys.Wins) + 1);

				if (GameStateManager.Instance.LoggedIn)
					Social.ReportScore(PlayerPrefs.GetInt(PPKeys.Wins), "MostWinsID", (obj) => { });

				GameStateManager.Instance.WinsSet = true;
			}

            if (PlayerPrefs.GetInt(PPKeys.Wins) == 1)
            {
                Animating = true;
                StartCoroutine(FirstWinAnimation());
                StartCoroutine(FirstWinSpriteSwitcher());
            }

            CanIncremenetDay = false;
        }
        else if (DayAngle < LastAngle)
        {
            CanIncremenetDay = true;
        }

        LastAngle = DayAngle;
    }
    #endregion

    #region Coroutines
    private IEnumerator IncreaseDayAnimation()
    {
        bool done = false;
        bool increasing = true;

        DaySize = Scene1MainObjects.ScoreFg.GetComponent<Text>().fontSize;

        while (!done)
        {
            if (DaySize >= StartingDaySize + 20)
                increasing = false;

            if (increasing)
                DaySize += 2;
            else
                DaySize--;

            Scene1MainObjects.ScoreFg.GetComponent<Text>().fontSize = DaySize;
            Scene1MainObjects.ScoreBg.GetComponent<Text>().fontSize = DaySize;

			if (DaySize <= StartingDaySize)
				break;

            if (increasing)
                yield return new WaitForSeconds(.01f);
            else
                yield return new WaitForSeconds(.01f);
        }
    }

    private IEnumerator FirstWinAnimation()
    {
        Vector3 tempPos = Vector3.zero;

        Social.ReportProgress("SavedMeowsID", 100, (obj) => {});
        Scene1MainObjects.AdCanvas.SetActive(true);
        Scene1MainObjects.Player.GetComponent<Rigidbody2D>().gravityScale = 0f;
        Scene1MainObjects.Player.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        GameStateManager.Instance.BeatenGame = true;
        AudioManager.Instance.PlayWinningClip();
        StopIncrementingDay = true;

        while (Animating)
        {
            tempPos = Scene1MainObjects.Player.transform.position;

            if (Scene1MainObjects.Player.transform.position.y > 1.7f)
                break;
            else
            {
                tempPos.y += .5f;
                Scene1MainObjects.Player.transform.position = tempPos;
			}

            yield return null;
        }
    }

    private IEnumerator FirstWinSpriteSwitcher()
    {
        float timer = 1f;
        bool normalSprite = true;

        while (Animating)
        {
			if (normalSprite)
            {
                Scene1MainObjects.Player.GetComponent<SpriteRenderer>().sprite = GameStateManager.Instance.GoldSprites[0];
                normalSprite = false;
            }
			else
            {
                Scene1MainObjects.Player.GetComponent<SpriteRenderer>().sprite = GameStateManager.Instance.PlayerSprites[0];
                normalSprite = true;
            }

            if (timer < .1f)
                Animating = false;

            timer *= .9f;

            yield return new WaitForSeconds(timer);
        }

        Scene1MainObjects.Player.GetComponent<SpriteRenderer>().sprite = GameStateManager.Instance.GoldSprites[0];
        GameStateManager.Instance.BeatenGame = true;
        Scene1MainObjects.AdCanvas.SetActive(false);
        GameStateManager.Instance.InvokePlayerLost = true;

        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene(1);
    }
    #endregion
}
