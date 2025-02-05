using UnityEngine;

public class WASDControls : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float movespeed = 5;
        Input.GetKey(KeyCode.W);
        Input.GetKey(KeyCode.A);
        Input.GetKey(KeyCode.S);
        Input.GetKey(KeyCode.D);

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.up * Time.deltaTime * movespeed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * Time.deltaTime * movespeed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.down * Time.deltaTime * movespeed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * Time.deltaTime * movespeed;
        }
    }
}
