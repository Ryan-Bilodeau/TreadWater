using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Gets attached to each cloud in CloudManager in LoadClouds
public class CloudStateManager : MonoBehaviour
{
	private float DisableDist;
	private float MovementSpeed;

	private Vector3 TempPos;
	private float FramerateTimer;

	private void Update()
	{
        //Update position
		if (Time.timeScale > 0f)
		{
			FramerateTimer = Time.deltaTime * 60f;
			TempPos = transform.position;
			TempPos.x -= MovementSpeed * FramerateTimer;
			gameObject.transform.position = TempPos;
		}
	}

    public void StartManageState()
    {
        StopCoroutine(ManageState());
        StartCoroutine(ManageState());
    }

	#region Coroutines
	private IEnumerator ManageState()
	{
		while (gameObject.activeSelf)
		{
			if (gameObject.transform.position.x < -DisableDist)
			{
				CloudManager.DisabledClouds.Add(gameObject);
				gameObject.SetActive(false);
			}

			yield return new WaitForSeconds(.5f);
		}
	}
	#endregion

	#region Called by CloudManager
	//Called in LoadClouds 
	public void SetDisableDist(float dist)
	{
		DisableDist = dist;
	}

	//Called in LoadClouds
	public void SetMovementSpeed(float speed)
	{
		MovementSpeed = speed;
	}
	#endregion
}
