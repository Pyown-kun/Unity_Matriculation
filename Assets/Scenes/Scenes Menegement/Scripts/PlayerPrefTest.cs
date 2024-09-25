using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class PlayerPrefTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        loadData();
        saveData("ElKecepatan", 10, 999f);
        loadData();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void saveData(string nickName, int level, float score)
    {
        PlayerPrefs.SetString("nickName", nickName);
        PlayerPrefs.SetInt("level", level);
        PlayerPrefs.SetFloat("score", score);
        Debug.Log("Save Success11");
    }

    void loadData ()
    {
        string nick = PlayerPrefs.GetString("nickName", "nickName tidak ada");
        int level = PlayerPrefs.GetInt("level", 0);
        float score = PlayerPrefs.GetFloat("score", 1f);

        Debug.Log(nick);
        Debug.Log(level);
        Debug.Log(score);
    }
}
