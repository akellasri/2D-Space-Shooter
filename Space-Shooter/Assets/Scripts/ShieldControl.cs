using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldControl : MonoBehaviour
{
	private Transform shield;
	public float speed;
	public float maxBound, minBound;

	// color changes on hits by enemy, dies after 5 hits
    public Renderer shieldRenderer;
    public Color shieldColor;
    public float rFloat = 0.06243324f; 
    public float gFloat = 0.2169811f; 
    public float bFloat = 0.1111494f; 
    public float aFloat = 1; 

    public static float hit = 0;


    // Start is called before the first frame update
    void Start()
    {
        shield = GetComponent<Transform> ();
    }

    void FixedUpdate()
    {
        float h = Input.GetAxis("Vertical");

        if (shield.position.x < minBound && h < 0)
        	h = 0;
        else if (shield.position.x > maxBound && h > 0)
        	h = 0;

        shield.position += Vector3.right * h * speed;

    }

    public void UpdateColor()
    {
        if(hit == 1){
            rFloat = 0.5f; 
            gFloat = 0.5f; 
            bFloat = 0.5f;
        }
        if(hit == 2){
            rFloat = 0.06243324f; 
            gFloat = 0.2169811f; 
            bFloat = 0.1111494f;
        }
        if(hit == 3){
            rFloat = 0.06243324f; 
            gFloat = 0.2169811f; 
            bFloat = 0.1111494f;
        }
        if(hit == 4){
            rFloat = 0.06243324f; 
            gFloat = 0.2169811f; 
            bFloat = 0.1111494f;
        }

        shieldColor = new Color(rFloat, gFloat, bFloat, aFloat);
        shieldRenderer.material.color = shieldColor;
    }

}
