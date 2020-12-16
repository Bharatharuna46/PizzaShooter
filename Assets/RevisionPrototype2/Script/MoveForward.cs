using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float forwardSpeed;
    private int topBound = 19;
    private int bottomBound = -25;
    // Start is called before the first frame update
    //if bullet has passed the top of the screen, destroy it.
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * forwardSpeed);
        ObjectDisappear();    
    }
    void ObjectDisappear()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < bottomBound)
        {
            Destroy(gameObject);
        }

    }
}
