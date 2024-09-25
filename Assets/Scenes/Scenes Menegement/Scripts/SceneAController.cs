using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SceneAController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        setData("Umi");
    }

    void setData(string nickName)
    {
        Debug.Log(playerData.Nickname = nickName);
        playerData.Nickname = nickName;

        Debug.Log(GameShooterManager.instance.score = 100);
        GameShooterManager.instance.score = 100;
    }
}
