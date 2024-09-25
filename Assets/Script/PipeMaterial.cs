using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMaterial : MonoBehaviour
{
     public Color color;

    // Start is called before the first frame 

    void Start()
    {
        var pipeRenderer = gameObject.GetComponent<Renderer>();

        pipeRenderer.material.SetColor("color", color);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
