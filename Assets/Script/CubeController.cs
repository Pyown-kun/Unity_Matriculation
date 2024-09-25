using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    private CubeBehiviour cubeBehiviour;

    private void Awake()
    {
        cubeBehiviour = gameObject.AddComponent<CubeBehiviour>();
    }
}
