using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLaserControl : MonoBehaviour
{
	private Transform laser;
	public float speed;

    //public ShieldControl shield;

    public Color shieldColor;
    public float rFloat = 0.06243324f; 
    public float gFloat = 0.2169811f; 
    public float bFloat = 0.1111494f; 
    public float aFloat = 1; 

    // Start is called before the first frame update
    void Start()
    {
        laser = GetComponent<Transform> ();
        //shield = GetComponent<ShieldControl>();
    }

    // move at set period at time
    void FixedUpdate()
    {
    	laser.position += Vector3.up * -speed;

    	if(laser.position.y <= -10)
    		Destroy (gameObject);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            if(PlayerControl.health > 1){
                Destroy(gameObject);
                PlayerControl.health -= 1;
            }
            else{
            	Destroy (other.gameObject);
            	Destroy (gameObject);
            	GameOver.isPlayerDead = true;
            }
        }
        else if (other.tag == "Shield")
        {
        	Destroy (gameObject);

            ShieldControl.hit += 1;
            //Debug.Log(ShieldControl.hit);
            if (ShieldControl.hit <= 4){
                UpdateColor(other);
            }
            else{
                Destroy (other.gameObject);
            }
        }
        // reaction to shield?
        
    }

    public void UpdateColor(Collider2D other)
    {
        if(ShieldControl.hit == 1){
            rFloat = 0.09772159f; 
            gFloat = 0.3396226f; 
            bFloat = 0.1721527f;
        }
        if(ShieldControl.hit == 2){
            rFloat = 0.1590869f; 
            gFloat = 0.5188679f; 
            bFloat = 0.267f;
        }
        if(ShieldControl.hit == 3){
            rFloat = 0.244f; 
            gFloat = 0.650f; 
            bFloat = 0.355f;
        }
        if(ShieldControl.hit == 4){
            rFloat = 0.317f; 
            gFloat = 0.811f; 
            bFloat = 0.469f;
        }

        shieldColor = new Color(rFloat, gFloat, bFloat, aFloat);

        other.GetComponent<Renderer>().material.color = shieldColor;
    }
}
