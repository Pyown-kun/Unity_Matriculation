using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField]
    private AudioSource BounceSFX;


    // Update is called once per frame

    private void OnCollisionEnter(Collision other)
    {
        BounceSFX.Play();
    }
}
