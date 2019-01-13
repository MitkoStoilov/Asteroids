using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenuHandler2 : MonoBehaviour {

	public string GameScene = "GameMode2";
	public void RestartGame()
	{
		SceneManager.LoadScene(GameScene);
	}

	public void QuitGame()
	{
		Application.Quit ();
	}
	public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}