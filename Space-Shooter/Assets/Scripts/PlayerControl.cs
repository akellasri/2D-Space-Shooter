﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

	private Transform player;
	public float speed;
	public float maxBound, minBound;

	public GameObject shot; // Later drag laser into this but in Unity
	public Transform shotSpwan; //Player Trasnform drag in Unity
	public float fireRate;

	private float nextFire;

    // healt to determine death
    public static float health = 3;


    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Transform> ();
    }


    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");

        if (player.position.x < minBound && h < 0)
        	h = 0;
        else if (player.position.x > maxBound && h > 0)
        	h = 0;

        player.position += Vector3.right * h * speed;

    }

    void Update()
    {
    	if(Input.GetButton("Fire1") && Time.time > nextFire)
    	{
    		nextFire = Time.time + fireRate;
    		Instantiate(shot, shotSpwan.position, shotSpwan.rotation);
    	}
    }
}
