using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameObject.Find("Player").GetComponent<PlayerScript>().hidden)
        {
            transform.position = Vector2.MoveTowards(transform.position, GameObject.Find("Player").transform.position, 3 * Time.deltaTime);
        }
        
    }
}
