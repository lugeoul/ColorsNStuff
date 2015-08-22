using UnityEngine;
using System.Collections;

public class Fire : MonoBehaviour {

	public GameObject colorShot;
    GameObject player;
    Vector2 destination;
    public AnimationCurve positionOverTime;
    public float flyDuration;
    float flyTime = 0;

	void Start () {
    }
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetMouseButtonDown (0))
        {
		    Vector3 pz = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		    pz.z = 0;
			GameObject go = Instantiate (colorShot, pz, Quaternion.identity) as GameObject;
        }
	}
}

