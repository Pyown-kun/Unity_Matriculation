using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneBController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        dataLoad();
    }

    void dataLoad()
    {
        Debug.Log(playerData.Nickname);
        Debug.Log(GameShooterManager.instance.score = 100);
    }
}
