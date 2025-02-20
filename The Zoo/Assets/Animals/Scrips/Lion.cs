using UnityEngine;

public class Lion : Animal
{
    public GameObject lion;
    public void Wander()
    {
        Vector3 direction = Vector3.zero;
        moveSpeed = 2.0f;
        if (Input.GetKeyDown(KeyCode.E))
        {
            isMoving = true;
            direction = Vector3.up;
            Debug.Log("Moving");
        }
        else
        {
            Debug.Log("Sleeping");
            isSleeping = true;
        }
    }

    void Update()
    {
        Wander();
    }
}