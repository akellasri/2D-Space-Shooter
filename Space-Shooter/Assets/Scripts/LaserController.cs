using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserController : MonoBehaviour
{
	private Transform laser;
	private float speed;

    // Start is called before the first frame update
    void Start()
    {
        laser = GetComponent<Transform> ();
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
        if(other.tag == 'Enemy')
        {
        	Destroy (other.gameObject);
        	Destroy (gameObject);
        	// Increase Score?
        }
        else if (other.tag == 'Base')
        	Destroy (gameObject);
        // reaction to shield?
        
    }
}
