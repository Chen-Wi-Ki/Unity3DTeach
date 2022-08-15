using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor1MoveEvent : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("up"))
        {
            if (transform.position.y <= 4.75)
            {
                transform.position = new Vector3(transform.position.x , transform.position.y + 0.02f, transform.position.z);
            }
        }

        if (Input.GetKey("down"))
        {
            if (transform.position.y >= -5.1)
            {
                transform.position = new Vector3(transform.position.x , transform.position.y - 0.02f, transform.position.z);
            }
        }
    }
}
