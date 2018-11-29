using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Attach to Player in 1Main
public class PlayerManager : MonoBehaviour
{
    public float MoveForce;                 //How much player moves
    public float StartingAnimationSpeed;            //Time between each sprite change
    public float DragInWater;

    private bool DoneAnimating = true;
    private bool CanJump;

    private float CurrentAnimationSpeed;
    private float StartingDrag;

    private void Awake()
    {
        StartingDrag = gameObject.GetComponent<Rigidbody2D>().drag;
    }

    private void Update()
    {
        ManagePhysics();
    }

    private void FixedUpdate()
    {
        OnMoveButtonPress(); 
    }

    #region Private Methods
    //Call in FixedUpdate - Moves player and plays animation
    private void OnMoveButtonPress()
    {
		if (GameStateManager.Instance.MoveButtonDown && CanJump && DoneAnimating && !GameStateManager.Instance.PlayerLost)
		{
			StartCoroutine(PlaySwimAnimation());

			gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
			gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, MoveForce));

			GameStateManager.Instance.MoveButtonDown = false;
            AudioManager.Instance.PlayJumpClip();
            DoneAnimating = false;
		}
        else if (GameStateManager.Instance.MoveButtonDown && !CanJump && DoneAnimating)
        {
            StartCoroutine(PlaySwimAnimation());

            GameStateManager.Instance.MoveButtonDown = false;
            DoneAnimating = false;
        }
    }

    //Call in Update - Manages if Player can jump and linear drag
    private void ManagePhysics()
    {
        if (Scene1MainObjects.WaterMark.transform.position.y > Scene1MainObjects.WaterLevel.transform.position.y)
        {
            CanJump = false;
            gameObject.GetComponent<Rigidbody2D>().drag = StartingDrag;
            CurrentAnimationSpeed = StartingAnimationSpeed / 2f;
        }
        else
        {
            CanJump = true;
            gameObject.GetComponent<Rigidbody2D>().drag = DragInWater;
            CurrentAnimationSpeed = StartingAnimationSpeed;
        }
    }
	#endregion

	#region Coroutines
	private IEnumerator PlaySwimAnimation()
	{
		bool increasingCounter = true;
		int counter = 0;

		while (true)
		{
			if (increasingCounter)
				counter++;
			else
				counter--;

			if (counter == GameStateManager.Instance.PlayerSprites.Length - 1)
				increasingCounter = false;

            if (GameStateManager.Instance.BeatenGame)
                gameObject.GetComponent<SpriteRenderer>().sprite = GameStateManager.Instance.GoldSprites[counter];
            else
                gameObject.GetComponent<SpriteRenderer>().sprite = GameStateManager.Instance.PlayerSprites[counter];

			if (counter == 0 && !increasingCounter)
			{
				break;
			}

			yield return new WaitForSeconds(CurrentAnimationSpeed);
		}

        DoneAnimating = true;
	}
    #endregion
}
