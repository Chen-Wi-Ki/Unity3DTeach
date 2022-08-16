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
            if (transform.position.y <= 3.8)
            {
                transform.position = new Vector3(transform.position.x , transform.position.y + Time.deltaTime * 25, transform.position.z);
            }
        }

        if (Input.GetKey("down"))
        {
            if (transform.position.y >= -4.5)
            {
                transform.position = new Vector3(transform.position.x , transform.position.y - Time.deltaTime * 25, transform.position.z);
            }
        }
    }
}
