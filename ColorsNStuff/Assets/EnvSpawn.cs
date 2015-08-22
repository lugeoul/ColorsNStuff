using UnityEngine;
using System.Collections;

public class EnvSpawn : MonoBehaviour {
	public GameObject floorTile;
	public GameObject spawn;
	void Start () {
		Instantiate(floorTile ,transform.position, Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
	}
	void OnTriggerExit2D (Collider2D col)
	{
		GameObject temp = Instantiate(floorTile ,transform.position , Quaternion.identity) as GameObject;
		temp.GetComponentInChildren<SpriteRenderer> ().color = new Color (Random.Range (0.0f, 1.0f), Random.Range (0.0f, 1.0f), Random.Range (0.0f, 1.0f));
	}
}
