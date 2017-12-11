using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayGame : MonoBehaviour
{
    /*IEnumerator*/
    public void ChangeLevel(int sceneToChangeTo)
    {
        //float fadeTime = GameObject.Find("PlayButton").GetComponent<SceneChange>().BeginFade(1);
        //yield return new WaitForSeconds(fadeTime);
        SceneManager.LoadScene(sceneToChangeTo /*SceneManager.sceneCountInBuildSettings + 1*/);

    }

}
