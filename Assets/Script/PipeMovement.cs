using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    public float moveSpeed = 1.0f;
    public float moveSpeedUp = 1.0f;
    public float SpeedUpDelay = 1.0f;
    private float SpeedUpTime = 1.0f;
    private bool hasBeenSpeedUp= false;

    // Update is called once per frame
    void Update()
    {
        var nextPotition = transform.position + Vector3.left * moveSpeed * Time.deltaTime;
        transform.SetLocalPositionAndRotation(nextPotition,transform.rotation);

        if (hasBeenSpeedUp)
        {
            SpeedUpTime += Time.deltaTime;
            if (SpeedUpTime <= 0)
            {
                SpeedUp();
            }
        }
    }

    private void SpeedUp()
    {
        moveSpeed += moveSpeedUp;
        hasBeenSpeedUp = true;
    }
}
