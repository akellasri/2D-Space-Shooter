using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLaserControl : MonoBehaviour
{
	private Transform laser;
	public float speed;
    // Start is called before the first frame update
    void Start()
    {
        laser = GetComponent<Transform> ();
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
        	Destroy (other.gameObject);
        	Destroy (gameObject);
        	GameOver.isPlayerDead = true;
        }
        else if (other.tag == "Shield")
        	Destroy (gameObject);
        // reaction to shield?
        
    }
}
