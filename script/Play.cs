using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Play : MonoBehaviour {

    // Use this for initialization

    public void GotoNextSceneAction()
        {
            SceneManager.LoadScene("Level 1");

            
        }
    public void HardMode()
    {
        SceneManager.LoadScene("Hard Start");
   

    }
    public void Back()
    {
        SceneManager.LoadScene("Start");


    }
     public void HowToPlay()
    {
        SceneManager.LoadScene("Instructions");


    }

    public void GotoHardScene()
    {
        SceneManager.LoadScene("Level 4");


    }       public void Quit()
    {
        Application.Quit();
    }


}
