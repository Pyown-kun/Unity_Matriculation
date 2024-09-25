using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputControlDemo : MonoBehaviour
{
    [SerializeField]
    private Transform cubeTransform;

    [SerializeField]
    private MeshRenderer cubeMeshRenderer;



    // Start is called before the first frame update
    void Start()
    {
        cubeTransform.position = new Vector3(3, 4, 1);
        cubeTransform.localEulerAngles = new Vector3(50, 50, 0);
        cubeTransform.localScale = new Vector3(2, 1, 2);
    }

    // Update is called once per frame
    void Update()
    {
        var HorzontalInput = Input.GetAxis("Horizontal");

        Debug.Log(HorzontalInput);
    }
}
