using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    bool trapped;
    float trapTimer; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameObject.Find("Player").GetComponent<PlayerScript>().hidden && !trapped)
        {
            transform.position = Vector2.MoveTowards(transform.position, GameObject.Find("Player").transform.position, 3 * Time.deltaTime);
        }

        if(trapped && trapTimer < 5)
        { 
            trapTimer += Time.deltaTime;    
        }
        else if (trapTimer >= 5)
        {
            trapped = false;
            trapTimer = 0;
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Trap")
        {
            Destroy(collision.gameObject);
            trapped = true;
        }
    }
}
