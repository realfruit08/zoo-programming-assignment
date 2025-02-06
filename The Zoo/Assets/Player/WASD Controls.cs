using UnityEngine;

public class WASDControls : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float movespeed = 5;
        float sprint = 13f;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            movespeed = sprint;
        }
        Input.GetKey(KeyCode.W);
        Input.GetKey(KeyCode.A);
        Input.GetKey(KeyCode.S);
        Input.GetKey(KeyCode.D);
        Input.GetKey(KeyCode.LeftShift);

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.up * Time.deltaTime * movespeed;
          
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * Time.deltaTime * movespeed;
            spriteRenderer.flipX = false;
        }
       
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.down * Time.deltaTime * movespeed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * Time.deltaTime * movespeed;
            spriteRenderer.flipX = true;
        }
       
    }
}
