using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PipeDestroyer : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        var gameObject = collision.gameObject;
        Destroy(gameObject);
    }
}
