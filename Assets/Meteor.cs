using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{
    public GameObject prefab;
    public GameObject positionpoint;
    public float nextSpawnTime;
    public float spawnInterval;

    private void Start()
    {
        nextSpawnTime = Time.time;
    }
    void Update()
    {
        if (Time.time > nextSpawnTime)
        {
            Spawn();
            nextSpawnTime += spawnInterval;
        }

    }



    void Spawn()
    {
        Vector3 pos = positionpoint.transform.position;
        pos.x = Random.Range(-17f, 17f);
        pos.y = Random.Range(13.5f, 20f);
        var rot = Quaternion.Euler(0, 0, 0);
        Instantiate(prefab, pos, rot);
    }
}
