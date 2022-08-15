using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square2TriggerEvent : MonoBehaviour
{
    public GameObject NewSquare2;
    Vector3 NewObjLocation;

    private void OnTriggerEnter2D(Collider2D other)
    {
        float X= Random.value * 8.4f,
              Y= Random.value * 4f,
              Z =0;

        if (Random.value < 0.5)
        {
            X = X * -1;
        }

        if (Random.value < 0.5)
        {
            Y = Y * -1;
        }

        NewObjLocation = new Vector3(X,Y,Z);

        if (other.gameObject.name == "Square1")
        {
            //Destroy(gameObject);
            transform.localScale = new Vector3(transform.localScale.x / 1.5f, transform.localScale.y / 1.5f, transform.localScale.z);
            transform.position = NewObjLocation;
        }
    }
}
