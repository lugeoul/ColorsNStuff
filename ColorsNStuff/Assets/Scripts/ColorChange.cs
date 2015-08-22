using UnityEngine;
using System.Collections;

public class ColorChange : MonoBehaviour {

    public AnimationCurve colorOverTime;
    public AnimationCurve positionOverTime;
    SpriteRenderer sRenderer;
    public Sprite splatterSprite;
    public float duration;
    float time = 0;
    public float flyDuration;
    float flyTime = 0;
    bool changeColor = false;
    bool flyTowardsSprite = false;
    Color destinationColor = new Color(1,0,0);
    Color startColor = Color.white;
    GameObject impactPoint;
    GameObject impactPointPrefab;
    GameObject projectile;
    public GameObject projectilePrefab;
    GameObject projectileSpawn;

    // Use this for initialization
    void Start () {
        sRenderer = GetComponent<SpriteRenderer>();
        projectileSpawn = GameObject.Find("SplatterSpawn");
        destinationColor = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
    }
	
	// Update is called once per frame
	void Update () {
        if(flyTowardsSprite)
        {
            flyTime += Time.deltaTime;
            Vector3 tempProjectilePosition = new Vector3(0, 0, 0);
            tempProjectilePosition.x = Mathf.Lerp(projectileSpawn.transform.position.x, impactPoint.transform.position.x, positionOverTime.Evaluate(flyTime / flyDuration));
            tempProjectilePosition.y = Mathf.Lerp(projectileSpawn.transform.position.y, impactPoint.transform.position.y, positionOverTime.Evaluate(flyTime / flyDuration));
            tempProjectilePosition.z = 0;


            projectile.transform.position = tempProjectilePosition;

            if (flyTime > flyDuration)
            {
                changeColor = true;
                flyTowardsSprite = false;
                Destroy(projectile);
            }
        }
	    if(changeColor)
        {
            time += Time.deltaTime;
            Color actualColor;
            actualColor.a = 1;
            actualColor.r = Mathf.Lerp(startColor.r, destinationColor.r, colorOverTime.Evaluate(time / duration));
            actualColor.g = Mathf.Lerp(startColor.g, destinationColor.g, colorOverTime.Evaluate(time / duration));
            actualColor.b = Mathf.Lerp(startColor.b, destinationColor.b, colorOverTime.Evaluate(time / duration));
            sRenderer.color = actualColor;
        }
	}

    void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(0))
        {
            flyTowardsSprite = true;
            impactPoint = Instantiate(new GameObject(), Camera.main.ScreenToWorldPoint(Input.mousePosition), Quaternion.identity) as GameObject;
            impactPoint.transform.parent = gameObject.transform;
            projectile = Instantiate(projectilePrefab, projectileSpawn.transform.position, Quaternion.identity) as GameObject;
        }
    }
}
