using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Advertisements;
using UnityEngine.SocialPlatforms.GameCenter;

//Attach to MainCamera in 1Main
public class ButtonManager : MonoBehaviour
{
    public void OnMoveButtonDown()
    {
        if (!GameStateManager.Instance.PlayerLost)
        {
            GameStateManager.Instance.MoveButtonDown = true;
        }
    }

    public void OnMoveButtonUp()
    {
        GameStateManager.Instance.MoveButtonDown = false;
    }

    public void OnPauseButtonClick()
    {
        Time.timeScale = 0f;
        Scene1MainObjects.UICanvas.SetActive(false);
        Scene1MainObjects.PauseCanvas.SetActive(true);
        AudioManager.Instance.PlayButtonClickClip();
    }

    public void OnResumeButtonClick()
    {
        Time.timeScale = GameStateManager.Instance.StartingTimeScale;
        Scene1MainObjects.UICanvas.SetActive(true);
        Scene1MainObjects.PauseCanvas.SetActive(false);
        AudioManager.Instance.PlayButtonClickClip();
    }

    public void OnExitButtonClick()
    {
        AudioManager.Instance.PlayButtonClickClip();
        SceneManager.LoadScene(0);
    }

    public void OnPlayButtonClick()
    {
        AudioManager.Instance.PlayButtonClickClip();
        SceneManager.LoadScene(1);
    }

    public void OnRestartButtonClick()
    {
        AudioManager.Instance.PlayButtonClickClip();
        SceneManager.LoadScene(1);
    }

    public void OnTwitterButtonClick()
    {
        AudioManager.Instance.PlayButtonClickClip();
        Application.OpenURL("https://twitter.com/UirtusCreations");
    }

    public void OnLeaderBoardButtonClick()
    {
        AudioManager.Instance.PlayButtonClickClip();
        if (Social.localUser.authenticated)
            Social.ShowLeaderboardUI();
    }

    public void OnMuteButtonClick()
    {
        PPKeys.ChangeMuteState();

        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            if (GameStateManager.Instance.Muted == false)
            {
                Scene1MainObjects.MuteButton.GetComponent<Image>().sprite
                                 = GameStateManager.Instance.MuteSprites[0];
            }
            else
            {
                Scene1MainObjects.MuteButton.GetComponent<Image>().sprite
                                 = GameStateManager.Instance.MuteSprites[1];
            }
        }
        else if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            if (GameStateManager.Instance.Muted == false)
            {
                Scene0MenuObjects.MuteButton.GetComponent<Image>().sprite
                                 = GameStateManager.Instance.MuteSprites[0];
            }
            else
            {
                Scene0MenuObjects.MuteButton.GetComponent<Image>().sprite
                                 = GameStateManager.Instance.MuteSprites[1];
            }
        }
    }

    public void OnExtraLifeButtonClicked()
    {
        AudioManager.Instance.PlayButtonClickClip();
        if (GameStateManager.Instance.CanBeRevived == true)
        {
            ShowRewardedAd("rewardedVideo");
        }
    }

    #region Show Rewarded Ad
    private void ShowRewardedAd(string zone = "")
	{
		if (string.Equals(zone, ""))
			zone = null;

		ShowOptions options = new ShowOptions();
		options.resultCallback = AdCallbackhandler;

		if (Advertisement.IsReady(zone))
		{
			Advertisement.Show(zone, options);
            OnAdShow();
		}
	}

	private void AdCallbackhandler(ShowResult result)
	{
		switch (result)
		{
			case ShowResult.Finished:
				GameStateManager.Instance.OnPlayerRevive();
				break;
			case ShowResult.Skipped:
			case ShowResult.Failed:
				Scene1MainObjects.AdCanvas.SetActive(false);
				GameStateManager.Instance.AdShowing = false;
				Time.timeScale = GameStateManager.Instance.StartingTimeScale;
				break;
		}
	}

	//Call when Ad is shown
	private void OnAdShow()
	{
		Time.timeScale = 0f;
		GameStateManager.Instance.AdShowing = true;
		Scene1MainObjects.AdCanvas.SetActive(true);
	}
    #endregion
}
