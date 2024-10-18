using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerScript : MonoBehaviour
{
	// Normal Movements Variables
	public float curSpeed;
	public bool hidden;
	public Sprite[] sprites;
	public TMP_Text materialsText;
	public int materials;


	void FixedUpdate()
	{

		GetComponent<Rigidbody2D>().velocity = new Vector2(Mathf.Lerp(0, Input.GetAxis("Horizontal") * curSpeed, 0.8f),
											 Mathf.Lerp(0, Input.GetAxis("Vertical") * curSpeed, 0.8f));

		if (Input.GetKey(KeyCode.W))
        {
			GetComponent<SpriteRenderer>().sprite = sprites[0];
			GetComponent<SpriteRenderer>().flipX = false;
		}
		else if (Input.GetKey(KeyCode.A))
		{
			GetComponent<SpriteRenderer>().sprite = sprites[1];
			GetComponent<SpriteRenderer>().flipX = false;
		}
		else if (Input.GetKey(KeyCode.S))
		{
			GetComponent<SpriteRenderer>().sprite = sprites[2];
			GetComponent<SpriteRenderer>().flipX = false;
		}
		else if (Input.GetKey(KeyCode.D))
		{
			
			GetComponent<SpriteRenderer>().sprite = sprites[3];
			GetComponent<SpriteRenderer>().flipX = true;
		}

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
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Item")
        {
			Destroy(collision.gameObject);
			UpdateItems(1);
        }
    }

    public void UpdateItems(int amt)
    {
		materials += amt;
		materialsText.text = "Materials: " + materials;

    }
}
