using UnityEngine;
using System.Collections;

public class EnvMove : MonoBehaviour {

	public float Speed;

	void Start () {

	}
	// Update is called once per frame
	void Update () {
		transform.position -= new Vector3(Speed, 0, 0);
	}
}
