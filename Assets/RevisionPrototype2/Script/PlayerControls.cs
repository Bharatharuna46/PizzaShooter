using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    // Start is called before the first frame update
    // The GO should be able to move left and right
    // GO should stop at the left and right boundary.
    public float horizontalMovement;
    public int moveSpeed;
    public int horizontalRange = 20;

    public GameObject bulletPrefab;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMovement = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * moveSpeed * horizontalMovement);
        Boundary();

        if (Input.GetKey(KeyCode.Space))
        {
            Instantiate(bulletPrefab,transform.position, bulletPrefab.transform.rotation);
        }
    }

    void Boundary()
    {
        if (transform.position.x < -horizontalRange)
        {
            transform.position = new Vector3(-horizontalRange, transform.position.y, transform.position.z);
        }
        else if(transform.position.x > horizontalRange)
        {
            transform.position = new Vector3(horizontalRange, transform.position.y, transform.position.z);
        }
    }
}
