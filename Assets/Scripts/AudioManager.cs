using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Attach to AudioManager in 0Menu
//Doesn't get destroyed on load, manages audio
public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    public AudioClip JumpClip;
    public AudioClip WaterHitClip;
    public AudioClip DayIncreaseClip;
    public AudioClip ButtonClickClip;
    public AudioClip DeathClip;
    public AudioClip WinningClip;

    [HideInInspector]
    public AudioSource JumpSource;
    [HideInInspector]
    public AudioSource WaterHitSource;
    [HideInInspector]
    public AudioSource DayIncreaseSource;
    [HideInInspector]
    public AudioSource ButtonClickSource;
    [HideInInspector]
    public AudioSource DeathSource;
    [HideInInspector]
    public AudioSource WinningSource;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            SetUpAudio();
            DontDestroyOnLoad(gameObject);
        }
        else
            Destroy(gameObject);
    }

	#region Play Clips
	public void PlayJumpClip()
	{
        if (!GameStateManager.Instance.Muted)
            JumpSource.Play();
	}

	public void PlayWaterHitClip()
	{
        if (!GameStateManager.Instance.Muted)
		    WaterHitSource.Play();
	}

    public void PlayDayIncreaseClip()
    {
        if (!GameStateManager.Instance.Muted)
            DayIncreaseSource.Play();
    }

	public void PlayButtonClickClip()
	{
        if (!GameStateManager.Instance.Muted)
		    ButtonClickSource.Play();
	}

	public void PlayDeathClip()
	{
        if (!GameStateManager.Instance.Muted)
		    DeathSource.Play();
	}

    public void PlayWinningClip()
    {
        if (!GameStateManager.Instance.Muted)
            WinningSource.Play();
    }
    #endregion

    #region Stop Clips From Playing
    public void StopDeathClip()
    {
        if (DeathSource.isPlaying)
            DeathSource.Stop();
    }

    public void StopWinningClip()
    {
        if (WinningSource.isPlaying)
            WinningSource.Stop();
    }
    #endregion

    #region Call in Awake
    private void SetUpAudio()
    {
        JumpSource = gameObject.AddComponent<AudioSource>();
        WaterHitSource = gameObject.AddComponent<AudioSource>();
        DayIncreaseSource = gameObject.AddComponent<AudioSource>();
        ButtonClickSource = gameObject.AddComponent<AudioSource>();
        DeathSource = gameObject.AddComponent<AudioSource>();
        WinningSource = gameObject.AddComponent<AudioSource>();

        JumpSource.playOnAwake = false;
        WaterHitSource.playOnAwake = false;
        DayIncreaseSource.playOnAwake = false;
        ButtonClickSource.playOnAwake = false;
        DeathSource.playOnAwake = false;
        WinningSource.playOnAwake = false;

        JumpSource.volume = .4f;
        DayIncreaseSource.volume = .4f; 
        WaterHitSource.volume = .1f;

        JumpSource.clip = JumpClip;
        WaterHitSource.clip = WaterHitClip;
        DayIncreaseSource.clip = DayIncreaseClip;
        ButtonClickSource.clip = ButtonClickClip;
        DeathSource.clip = DeathClip;
        WinningSource.clip = WinningClip;
    }
    #endregion
}
