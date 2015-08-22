using UnityEngine;
using System.Collections;

public class SpawnEnv : MonoBehaviour {
	public int maxTime;
	public Sprite[] envPieces;
	public GameObject envObject;
	float time = 0;
	float rndTime = 0;
	void Start () {
	
	}

	void Update () {
		time += Time.deltaTime;
		if (time >= rndTime) {
			rndTime = Random.Range(0.4f, maxTime);
			GameObject temp = Instantiate(envObject ,transform.position , Quaternion.identity) as GameObject;
			temp.GetComponent<SpriteRenderer>().sprite = envPieces[Random.Range(0, envPieces.Length)];
			time = 0;
		}
	}

}
