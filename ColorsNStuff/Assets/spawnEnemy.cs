using UnityEngine;
using System.Collections;

public class spawnEnemy : MonoBehaviour {
	public GameObject enemyObject;
	float respawnTime =  3;
	float time = 0;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		if (time >= respawnTime) 
		{
		Instantiate(enemyObject ,transform.position , Quaternion.identity);
		time = 0;
			if (respawnTime > 0.5f)
			{
				respawnTime = respawnTime - 0.1f;
			}
		}
	}
}
