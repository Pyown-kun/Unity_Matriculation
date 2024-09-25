using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehiviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            UpdatePositon(new Vector3(1, 0, 0));
        }
    }

    void UpdatePositon(Vector3 newPosition)
    {
        transform.position = transform.position + newPosition;
    }

    void UpdateColor (Color newColor)
    {

    }
}
