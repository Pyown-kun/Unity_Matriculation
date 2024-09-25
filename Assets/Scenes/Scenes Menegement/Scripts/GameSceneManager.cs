using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneManager : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        { 
            SceneManager.LoadScene("SceneB");
        }
    }

    void LoadSceneSyc(string targetScene)
    {
        SceneManager.LoadScene(targetScene);
    }

    void LoadSceneSyc(int targetSceneIndex)
    {
        SceneManager.LoadScene(targetSceneIndex);
    }

    IEnumerator LoadSceneAsync()
    {
        AsyncOperation loadingScene = SceneManager.LoadSceneAsync("SceneB");

        while(!loadingScene.isDone);
        {

        }

        yield return null;
    }
}
