using UnityEngine;
using System.Collections;

public class BackgroundSpawn : MonoBehaviour {
	public GameObject floorTile;
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}
	void OnTriggerExit2D (Collider2D col)
	{
		GameObject temp = Instantiate(floorTile ,transform.position , Quaternion.identity) as GameObject;
	}
}
