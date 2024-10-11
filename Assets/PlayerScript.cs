using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
	// Normal Movements Variables
	public float curSpeed;
	public bool hidden;

	void Start()
	{

	}

	void FixedUpdate()
	{

		GetComponent<Rigidbody2D>().velocity = new Vector2(Mathf.Lerp(0, Input.GetAxis("Horizontal") * curSpeed, 0.8f),
											 Mathf.Lerp(0, Input.GetAxis("Vertical") * curSpeed, 0.8f));

		if (Input.GetKey(KeyCode.Space))
        {
			hidden = true;
			GetComponent<SpriteRenderer>().color = Color.blue;
        }
		else
        {
			hidden = false;
			GetComponent<SpriteRenderer>().color = Color.white;
		}
	}
}
