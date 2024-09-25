using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using UnityEngine;


public class SoaceShipController : MonoBehaviour
{
    [SerializeField]
    private Transform SpaceShip;

    [SerializeField]
    private float MoveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var HorizontalInput = Input.GetAxis("Horizontal");
        var VerticalInput = Input.GetAxis("Vertical");
        SpaceShip.Translate(new Vector3(VerticalInput, 0,HorizontalInput) * MoveSpeed * Time.deltaTime);
    
        if (Input.GetMouseButton(0))
        {
            var mouseX = Input.GetAxis("Mouse X");
            var mouseY = Input.GetAxis("Mouse Y");

            var rot = new Vector3(mouseX,mouseY, 0);
            SpaceShip.localEulerAngles = SpaceShip.localEulerAngles + rot;
        }
    }
}
