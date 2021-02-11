using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldControl : MonoBehaviour
{
	private Transform shield;
	public float speed;
	public float maxBound, minBound;

	// could also have a health so it can be destroyed by enemys?

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

}
