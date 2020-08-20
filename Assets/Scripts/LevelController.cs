using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public abstract class LevelController : MonoBehaviour
{
    //public PlayerController player;
    protected  float clickRate = 1f;
    protected float nextClickTime = 0f;



    public void LoadNextScene()
    {
        int nextScene = SceneManager.GetActiveScene().buildIndex + 1;
        if (nextScene < (SceneManager.sceneCountInBuildSettings))
        {
            SceneManager.LoadScene(nextScene);
        }
        else
        {
            SceneManager.LoadScene(0);
        }
    }


    protected void LoadNextScene(float t)
    {
        StartCoroutine(WaitForNextScene(t));
    }

    IEnumerator WaitForNextScene(float t)
{
    //Print the time of when the function is first called.


    //yield on a new YieldInstruction that waits for 5 seconds.
    yield return new WaitForSeconds(t);

        //After we have waited 5 seconds print the time again.
        int nextScene = SceneManager.GetActiveScene().buildIndex + 1;
        if (nextScene < (SceneManager.sceneCountInBuildSettings))
        {
            SceneManager.LoadScene(nextScene);
        }
        else
        {
            SceneManager.LoadScene(0);
        }
    }

protected void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    protected void AllowScreenRotation(bool b)
    {
        Screen.autorotateToLandscapeLeft = b;
        Screen.autorotateToLandscapeRight = b;
        Screen.autorotateToPortraitUpsideDown = b;
    }

    protected void ShowMouse(bool b)
    {
        if (b) { Cursor.lockState = CursorLockMode.None; } else { Cursor.lockState = CursorLockMode.Locked; }
    }


    public abstract void Shake();


}
