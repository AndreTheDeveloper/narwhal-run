using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSceneOnTouch : MonoBehaviour
{
    public int sceneId;

    public void LoadSceneWithDelay() {
        Invoke("LoadScene", 0.5f);
    }

    public void LoadScene()
    {
        if(sceneId == 1) {
            PauseController.isPaused = false;
        }
            SceneManager.LoadScene(sceneId);
    }
}
