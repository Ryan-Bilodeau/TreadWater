using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Attach to CloudManager
public class CloudManager : MonoBehaviour
{
    public static List<GameObject> DisabledClouds;

    public float DisableDist;
    public float MovementSpeed;
    public float MinSpawnInterval;
    public float MaxSpawnInterval;

    private float MAX_Y_SPAWN_DIST = 6f;
    private float MIN_Y_SPAWN_DIST = 2f;
    private float MAX_X_SPAWN_DIST = 9f;
    private float MIN_X_SPAWN_DIST = 5.5f;

    private Vector3 TempPos;
    private int Index;

    private void Awake()
    {
        DisabledClouds = new List<GameObject>();
        LoadClouds();
        PlaceCloudsAtStart();
    }

    private void Start()
    {
        StartCoroutine(SpawnManager());
    }

    #region Coroutines
    //Call in Start - Manages spawning clouds
    private IEnumerator SpawnManager()
    {
        while (gameObject.activeSelf)
        {
            if (Time.timeScale > 0 && DisabledClouds.Count > 0 && !GameStateManager.Instance.AdShowing)
                SpawnCloud(MIN_X_SPAWN_DIST, MAX_X_SPAWN_DIST, MIN_Y_SPAWN_DIST, MAX_Y_SPAWN_DIST);

            yield return new WaitForSeconds(Random.Range(MinSpawnInterval, MaxSpawnInterval));
        }
    }
	#endregion

	#region Private Methods
	//Spawn a cloud and set it active
	private void SpawnCloud(float minX, float maxX, float minY, float maxY)
	{
		Index = Random.Range(0, DisabledClouds.Count);

        if (!DisabledClouds[Index].gameObject.activeSelf)
        {
			TempPos.x = Random.Range(minX, maxX);
			TempPos.y = Random.Range(minY, maxY);

			DisabledClouds[Index].SetActive(true);
			DisabledClouds[Index].gameObject.transform.position = TempPos;
			DisabledClouds[Index].gameObject.GetComponent<CloudStateManager>().StartManageState();
			DisabledClouds.RemoveAt(Index);
        }
	}
	#endregion

	#region Call in Awake
	//Load Clouds
	private void LoadClouds()
    {
        foreach (Transform child in transform)
        {
            child.gameObject.AddComponent<CloudStateManager>().SetDisableDist(DisableDist);
            child.gameObject.GetComponent<CloudStateManager>().SetMovementSpeed(MovementSpeed);
            DisabledClouds.Add(child.gameObject);
            child.gameObject.SetActive(false);
        }
    }

    //Places clouds when 1Main is loaded
    private void PlaceCloudsAtStart()
    {
        for (int i = 0; i < 3; i++)
        {
            SpawnCloud(-3, 3, MIN_Y_SPAWN_DIST, MAX_Y_SPAWN_DIST);
        }
    }
    #endregion
}
