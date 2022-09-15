using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public float maxTime = 1f;
    public GameObject obstacle;
    public float height = 1f;
    private float timer = 0f;
    // Start is called before the first frame update
    void Start()
    {
        timer = maxTime + 10f;
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > maxTime){
            GameObject spawnedObstacle = Instantiate(obstacle);
            spawnedObstacle.transform.position = transform.position + new Vector3(0f, Random.Range(-height, height), 0f);
            Destroy(spawnedObstacle, 10f);
            timer = 0f;
        }
        timer += Time.deltaTime;
    }
}
