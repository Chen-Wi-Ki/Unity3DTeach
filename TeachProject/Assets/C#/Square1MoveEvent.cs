using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square1MoveEvent : MonoBehaviour
{
    int MoveFlag1;

    // Start is called before the first frame update
    void Start()
    {
        MoveFlag1 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (MoveFlag1 == 0)
        {
            if (transform.position.x <= 8.4)
            {
                transform.position = new Vector3(transform.position.x + Time.deltaTime*25, transform.position.y, transform.position.z);
            }
            else
            {
                MoveFlag1 = 1;
            }
        }

        if (MoveFlag1 == 1)
        {
            if (transform.position.x >= -8.4)
            {
                transform.position = new Vector3(transform.position.x - Time.deltaTime * 25, transform.position.y, transform.position.z);
            }
            else
            {
                MoveFlag1 = 0;
            }
        }
    }
}
