using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // veranderen naar meerdere enemies, script werk al, maar met 1 vaste enemy nu.
    public GameObject enemy;
    public float spawnRate = 2f;
    float nextSpawn = 0.0f;
    public float timer;
    public GameObject[] prefabs;
    public Transform spawnPos;

    void Start()
    {
        prefabs = Resources.LoadAll<GameObject>("moles");
        timer = 0;
    }

   
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 5)
        {
            if (timer > nextSpawn)
            {
                nextSpawn = timer + spawnRate - Random.Range(0.4f, 1.2f);
                Instantiate(prefabs[Random.Range(0, prefabs.Length)], spawnPos.position, spawnPos.rotation);
            }
        }
    }
}