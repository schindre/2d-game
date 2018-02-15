using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControl : MonoBehaviour {

	public static GameControl instance;
	public GameObject GameOverText;
	public Text scoreText;
	public bool GameOver = false;
	public float scrollSpeed = -1.5f;

	private int score = 0;

	// Use this for initialization
	void Awake ()
	{
		if (instance == null) { 
			instance = this;
		} else if (instance != this)
		{
			Destroy(gameObject);
		}
	}

	// Update is called once per frame
	void Update ()
	{
		if (GameOver == true && Input.GetMouseButtonDown (0))


		{
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
			SoundMananger.PlaySound ("restart");

		}	
	}

	public void birdScored()
	{
		if (GameOver) 
		{
			return;

		}
		score++;
		scoreText.text = "Score: " + score.ToString ();
		SoundMananger.PlaySound ("point");
	}
	public void BirdDied()
	{
		GameOverText.SetActive (true);
		GameOver = true;
		SoundMananger.PlaySound ("death");
	}

}
