using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningEnenmy : MonoBehaviour {
    public GameObject enemy;
    public float timeSpawn;
    public float maxX;

	// Use this for initialization
	void Start () {
        startSpawning();
        //stopSpawning();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    /*void stopSpawning()
    {
        CancelInvoke("spawnEnemy");
    }*/
    void startSpawning()
    {
        InvokeRepeating("spawnEnemy", 0.9f, timeSpawn);
    }
    void spawnEnemy()
    {
        Instantiate(enemy,new Vector3(Random.Range(-5f,0f),transform.position.y,0),Quaternion.identity);
    }
}
