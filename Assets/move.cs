using UnityEngine;

public class move : MonoBehaviour
{
    public float velocity = 1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        this.transform.position += new Vector3(horizontalInput * velocity, 0, 0);
    }
}
