using UnityEngine;
using System.Collections;

public class DespawnEnv : MonoBehaviour {
	void Start () {
	}

	void Update () {
	}
	void OnTriggerExit2D (Collider2D col)
	{
		DestroyObject (col.gameObject.transform.parent.gameObject);
	}
}
