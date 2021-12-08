using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;

public class Exit : MonoBehaviour
{

    public void GotoNextSceneAction()
    {
        Advertisement.Show();
        SceneManager.LoadScene("Start");
    }

}
