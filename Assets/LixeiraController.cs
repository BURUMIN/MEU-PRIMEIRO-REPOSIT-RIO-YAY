using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LixeiraController : MonoBehaviour
{
    public float velocity;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        this.transform.position += new Vector3(horizontalInput * velocity, 0, 0);
        this.transform.position += new Vector3(0 , verticalInput * velocity, 0);
        if (this.transform.position.x > 10)
        {
            this.transform.position = new Vector3(10, this.transform.position.y, this.transform.position.z);
        }
        else if (this.transform.position.x < -10)
        {
            this.transform.position = new Vector3(-10, this.transform.position.y, this.transform.position.z);
        }

        if (this.transform.position.y > 7)
        {
            this.transform.position = new Vector3(this.transform.position.x, 1, this.transform.position.z);
        }   else if (this.transform.position.y < 1)
        {
            this.transform.position = new Vector3(this.transform.position.x, 1, this.transform.position.z);
        }
     }
}

