    using UnityEngine;
    using UnityEngine.SceneManagement;
     
    public class Control : MonoBehaviour
    {
        public void NextScene()
        {
            SceneManager.LoadScene("GameMode2");
        }
        public void NextScene1()
        {
            SceneManager.LoadScene("Main");
        }
    	public void QuitGame()
	    {
		    Application.Quit ();
	    }
    }

