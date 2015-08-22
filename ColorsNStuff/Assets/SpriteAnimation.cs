using UnityEngine;
using System.Collections;

public class SpriteAnimation : MonoBehaviour {

    public Sprite[] walkAnimation;
    SpriteRenderer sRenderer;
    public float spriteFramesPerSecond;
    float time = 0;
    int animationIndex = 0;

	// Use this for initialization
	void Start () {
        sRenderer = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;
        if(time >= 1 / spriteFramesPerSecond)
        {
            time = 0;
            animationIndex++;
            if(animationIndex == walkAnimation.Length)
                animationIndex = 0;
            sRenderer.sprite = walkAnimation[animationIndex];
        }
    }
}
