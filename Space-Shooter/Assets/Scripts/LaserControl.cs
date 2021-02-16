using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserControl : MonoBehaviour
{
	private Transform laser;
	public float speed;

    // Start is called before the first frame update
    void Start()
    {
        laser = GetComponent<Transform> ();

        //set gravity to 0 to not make it fall down?
        Physics2D.gravity = Vector2.zero;
    }
    
    // move at set period at time
    void FixedUpdate()
    {
    	laser.position += Vector3.up * speed;

    	if(laser.position.y >= 10)
    		Destroy (gameObject);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Enemy")
        {
        	Destroy (other.gameObject);
        	Destroy (gameObject);
        	PlayerScore.playerScore += 1;
        }
        else if (other.tag == "Shield")
        	Destroy (gameObject);
        // reaction to shield?
        
    }
}
