using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Advertisements;

//Attach to GameStateManager
//Handles scene changes and loading stuff
public class GameStateManager : MonoBehaviour
{
    public static GameStateManager Instance;

    [HideInInspector]
    public Sprite[] PlayerSprites;
    [HideInInspector]
    public Sprite[] GoldSprites;
    [HideInInspector]
    public Sprite[] WaveSprites;
    [HideInInspector]
    public Sprite[] MuteSprites;
    [HideInInspector]
    public float StartingTimeScale;
    [HideInInspector]
    public bool PlayerLost;
    [HideInInspector]
    public bool Muted;
    [HideInInspector]
    public bool MoveButtonDown;
    [HideInInspector]
    public bool CanBeRevived;
    [HideInInspector]
    public bool ExtraLifeButtonPressed;
    [HideInInspector]
    public bool AdShowing;
    [HideInInspector]
    public bool BeatenGame;
    [HideInInspector]
    public bool LoggedIn;
    [HideInInspector]
    public bool WinsSet;
    [HideInInspector]
    public bool InvokePlayerLost;

    private Object[] tempSprites;
    private Object[] tempWaves;
    private Object[] tempMutes;
    private Object[] tempGold;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            StartingTimeScale = Time.timeScale;
            Application.targetFrameRate = 60;
            LoadSprites();
            LoadWaves();
            LoadMuteSprites();
            LoadGold();
			SetPlayerPrefsAndMuteState();
            SetMuteButtonSpriteIn0Menu();
            DontDestroyOnLoad(gameObject);
        }
        else
            Destroy(gameObject);
    }

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnLevelFinishedLoading;
        SceneManager.sceneUnloaded += OnLevelFinishedUnloading;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnLevelFinishedLoading;
        SceneManager.sceneUnloaded -= OnLevelFinishedUnloading;
    }

    #region Delegates
    private void OnLevelFinishedLoading(Scene scene, LoadSceneMode sceneMode)
    {
        AudioManager.Instance.StopDeathClip();
        AudioManager.Instance.StopWinningClip();

		if (scene.buildIndex == 1)
		{
			On1MainRestart();
		}
        else if (scene.buildIndex == 0)
        {
            SetMuteButtonSpriteIn0Menu();
        }
    }

    private void OnLevelFinishedUnloading(Scene scene)
    {
        if (scene.buildIndex == 1)
        {
            StopAllCoroutines();
        }
    }
    #endregion

    #region On Player Revive
    //Called in ButtonManager by OnExtraLifeButtonClicked
    public void OnPlayerRevive()
    {
        CanBeRevived = false;
        PlayerLost = false;
        AdShowing = false;
        Scene1MainObjects.UICanvas.SetActive(true);
        Scene1MainObjects.AdCanvas.SetActive(true);
        Scene1MainObjects.RestartCanvas.SetActive(false);
        Scene1MainObjects.ExtraLifeButton.SetActive(false);
        Scene1MainObjects.CantReviveFg.SetActive(true); 
        Scene1MainObjects.CantReviveBg.SetActive(true);
        Scene1MainObjects.Player.transform.position = new Vector3(Scene1MainObjects.Player.transform.position.x,
                                                                 -5f,
                                                                  Scene1MainObjects.Player.transform.position.z);

        StartCoroutine(ResetMeowsPos());
    }

    //Called in OnPlayerRevive - Moves Meows on revive
    private IEnumerator ResetMeowsPos()
    {
        while (Scene1MainObjects.Player.transform.position.y < Scene1MainObjects.WaterLevel.transform.position.y - .05f)
        {
            Scene1MainObjects.Player.transform.position = new Vector3(Scene1MainObjects.Player.transform.position.x,
                Mathf.Lerp(Scene1MainObjects.Player.transform.position.y,
                           Scene1MainObjects.WaterLevel.transform.position.y + .2f, .05f),
                                                                      Scene1MainObjects.Player.transform.position.z);

            yield return null;
        }

        Scene1MainObjects.AdCanvas.SetActive(false);
        StartCoroutine(ResumeOnButtonPress());
        StartCoroutine(CheckIfPlayerLost());
    }

    //Wait for buttonpress to restart
    private IEnumerator ResumeOnButtonPress()
    {
        while (MoveButtonDown == false)
            yield return null;

        Time.timeScale = StartingTimeScale;
    }
    #endregion

    #region Private Methods
    //Call in OnLevelFinishedLoading
    private void On1MainRestart()
    {
        StopCoroutine(PauseAtStart());
        StopCoroutine(CheckIfPlayerLost());

        MoveButtonDown = false;
        PlayerLost = false;
        ExtraLifeButtonPressed = false;
        Scene1MainObjects.CantReviveBg.SetActive(false);
        Scene1MainObjects.CantReviveFg.SetActive(false);
        AdShowing = false;
        CanBeRevived = true;
        Scene1MainObjects.ExtraLifeButton.SetActive(true);
        Scene1MainObjects.AdCanvas.SetActive(false);
        Scene1MainObjects.PauseCanvas.SetActive(false);
        Scene1MainObjects.RestartCanvas.SetActive(false);
        Scene1MainObjects.UICanvas.SetActive(true);
        SetMuteButtonSpriteIn1Main();

        StartingTimeScale = Time.timeScale;
        Time.timeScale = 0f;

        StartCoroutine(PauseAtStart());
        StartCoroutine(CheckIfPlayerLost());
    }

    //Call in On1MainRestart
    private void SetMuteButtonSpriteIn1Main()
    {
        if (Muted)
            Scene1MainObjects.MuteButton.GetComponent<Image>().sprite = MuteSprites[1];
        else
            Scene1MainObjects.MuteButton.GetComponent<Image>().sprite = MuteSprites[0];
    }

    //Call in Awake
    private void SetMuteButtonSpriteIn0Menu()
    {
        if (Muted)
            Scene0MenuObjects.MuteButton.GetComponent<Image>().sprite = MuteSprites[1];
        else
            Scene0MenuObjects.MuteButton.GetComponent<Image>().sprite = MuteSprites[0];
    }

    private void SetPlayerSprite()
    {
        if (BeatenGame)
            Scene1MainObjects.Player.GetComponent<SpriteRenderer>().sprite = GoldSprites[0];
        else
            Scene1MainObjects.Player.GetComponent<SpriteRenderer>().sprite = PlayerSprites[0];
    }
    #endregion

    #region Coroutines
    //Call in On1MainRestart - pauses game until MoveButtonDown == true
    private IEnumerator PauseAtStart()
    {
        while (MoveButtonDown == false)
            yield return null;

        Time.timeScale = StartingTimeScale;
    }

    //Call in On1MainRestart - checks if player has lost
    private IEnumerator CheckIfPlayerLost()
    {
        while (PlayerLost == false || InvokePlayerLost)
        {
            if (Scene1MainObjects.Head.transform.position.y < Scene1MainObjects.WaterLevel.transform.position.y
               || InvokePlayerLost) 
            {
                PlayerLost = true;
                InvokePlayerLost = false;
                AudioManager.Instance.PlayDeathClip();

                yield return new WaitForSeconds(1f);

                Scene1MainObjects.RestartCanvas.SetActive(true);
                Scene1MainObjects.UICanvas.SetActive(false);

                if (Scene1MainObjects.Player.GetComponent<Rigidbody2D>().velocity.y > 0f)
                    Scene1MainObjects.Player.GetComponent<Rigidbody2D>().velocity = Vector2.zero;

                if (DayNightManager.Day > PlayerPrefs.GetInt(PPKeys.MostDaysSurvived))
                {
                    PlayerPrefs.SetInt(PPKeys.MostDaysSurvived, DayNightManager.Day);

                    if (LoggedIn)
                        Social.ReportScore(PlayerPrefs.GetInt(PPKeys.MostDaysSurvived), "MostDaysID", (obj) => { });
                }
            }

            yield return null;
        }
    }
	#endregion

	#region CallInAwake
	//Call in Awake - Only gets called once at gamestart
	private void LoadSprites()
	{
		tempSprites = new Object[6];

		for (int i = 0; i < 6; i++)
		{
			tempSprites[i] = Resources.Load(string.Format("Sprites/Player{0}", i), typeof(Sprite));
		}

		PlayerSprites = new Sprite[tempSprites.Length];

		for (int i = 0; i < PlayerSprites.Length; i++)
		{
			PlayerSprites[i] = tempSprites[i] as Sprite;
		}
	}

    private void LoadGold()
    {
        tempGold = new Object[6];

        for (int i = 0; i < 6; i++)
        {
            tempGold[i] = Resources.Load(string.Format("Sprites/Player{0}Gold", i), typeof(Sprite));
        }

        GoldSprites = new Sprite[tempGold.Length];

        for (int i = 0; i < GoldSprites.Length; i++)
        {
            GoldSprites[i] = tempGold[i] as Sprite;
        }
    }

    //Call in Awake - Only gets called once at gamestart
    private void LoadWaves()
    {
        tempWaves = Resources.LoadAll("Sprites/JumpingWave", typeof(Sprite));

        WaveSprites = new Sprite[tempWaves.Length];

        for (int i = 0; i < WaveSprites.Length; i++)
        {
            WaveSprites[i] = tempWaves[i] as Sprite;
        }
    }

	//Call in Awake - Only gets called once at gamestart
	private void LoadMuteSprites()
    {
        tempMutes = Resources.LoadAll("Sprites/MuteButton", typeof(Sprite));

        MuteSprites = new Sprite[tempMutes.Length];

            for (int i = 0; i < MuteSprites.Length; i++)
        {
            MuteSprites[i] = tempMutes[i] as Sprite;
        }
    }

    //Deals with setting player stats
    private void SetPlayerPrefsAndMuteState()
    {
		if (!PlayerPrefs.HasKey(PPKeys.MuteState))
			PlayerPrefs.SetInt(PPKeys.MuteState, 1);

        if (!PlayerPrefs.HasKey(PPKeys.MostDaysSurvived))
            PlayerPrefs.SetInt(PPKeys.MostDaysSurvived, 0);

        if (!PlayerPrefs.HasKey(PPKeys.Wins))
            PlayerPrefs.SetInt(PPKeys.Wins, 0);

        if (PlayerPrefs.GetInt(PPKeys.Wins) > 0)
            BeatenGame = true;

		Muted = PPKeys.GetMuteState();
    }
	#endregion
}
