using UnityEngine;
using System.Collections;

public class EnvSpawn : MonoBehaviour {
	public GameObject floorTile;
	public GameObject spawn;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}
	void OnTriggerExit2D (Collider2D col)
	{
		Instantiate(floorTile ,transform.position, Quaternion.identity);
	}
}
