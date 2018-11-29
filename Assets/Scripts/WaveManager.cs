using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Attach to Wave in 1Main
//Manages playing wave animation
public class WaveManager : MonoBehaviour
{
    public float AnimationSpeed;

    private Vector3 TempPos;
    private bool PlayerWasAboveWater;

    private void Awake()
    {
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
    }

    private void Update()
    {
        TempPos = transform.position;
        TempPos.x = .22f;
        transform.position = TempPos;
        CheckIfShouldPlayAnimation();
    }

    #region Private Methods
    //Call in update 
    private void CheckIfShouldPlayAnimation()
    {
        if (Scene1MainObjects.WaterMark.transform.position.y > Scene1MainObjects.WaterLevel.transform.position.y)
        {
            PlayerWasAboveWater = true;
        }

        if (Scene1MainObjects.WaterMark.transform.position.y < Scene1MainObjects.WaterLevel.transform.position.y &&
            PlayerWasAboveWater == true)
        {
            PlayerWasAboveWater = false;
            StopCoroutine(PlayAnimation());
            StartCoroutine(PlayAnimation());
        }
    }
    #endregion

    #region Coroutines
    private IEnumerator PlayAnimation()
    {
        gameObject.GetComponent<SpriteRenderer>().enabled = true;
        AudioManager.Instance.PlayWaterHitClip();

        int counter = 0;

        while (true)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = GameStateManager.Instance.WaveSprites[counter];

            counter++;
            if (counter > 5)
                break;

            yield return new WaitForSeconds(AnimationSpeed);
        }

        gameObject.GetComponent<SpriteRenderer>().enabled = false;
    }
    #endregion
}
