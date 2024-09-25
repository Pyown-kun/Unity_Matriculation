using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PipeSpawn : MonoBehaviour
{

    public GameObject pipePreFeb;
    public float spawnDelay = 1.5f;
    public float pipeMinY = -2f;
    public float pipeMaxY = 2f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(SpawnPipe), 0f, spawnDelay);
    }

    private void SpawnPipe()
    {
        var pipeY = Random.Range(pipeMinY, pipeMaxY);
        var position = transform.position;
        position.y = pipeY;

        Instantiate(pipePreFeb, transform.position, Quaternion.identity);
    }
}
