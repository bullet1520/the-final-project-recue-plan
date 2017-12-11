using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour {



    public IEnumerator ChangeLevel(/*string sceneToChangeTo*/)
    {
        float fadeTime = GameObject.Find("PlayButton").GetComponent<SceneChange>().BeginFade(1);
        yield return new WaitForSeconds(fadeTime);
        SceneManager.LoadScene(/*sceneToChangeTo*/ "Hetoc");

    }

}
