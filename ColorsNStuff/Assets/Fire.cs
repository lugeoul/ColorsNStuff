using UnityEngine;
using System.Collections;

public class Fire : MonoBehaviour {
	public GameObject Splatter;
	public Sprite[] splatterArray;
	SpriteRenderer sR;
	void Start () {
		sR = GetComponent <SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		Vector3 pz = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		pz.z = 0;
		if (Input.GetMouseButtonDown (0)) {
			GameObject go = Instantiate (Splatter, pz, Quaternion.identity) as GameObject ;
			go.GetComponent <SpriteRenderer> ().sprite = splatterArray[Random.Range(0, splatterArray.Length)];
		}
	}
}

