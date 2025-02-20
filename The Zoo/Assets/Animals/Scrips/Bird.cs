using UnityEngine;

public class Bird : Animal
{
    public GameObject bird;
    bool isFlying;
    bool isPerch;
    public void Fly()
    {
        moveSpeed = 2.0f;
        if (Input.GetKeyDown(KeyCode.E))
        {
            isFlying = true;
            transform.position = Vector3.MoveTowards(transform.position, targetpoint, moveSpeed * Time.deltaTime);
            if (Vector3.Distance(transform.position, pointA.position) < 14.0f)
            {
                targetpoint = pointB.position;
            }
            else if (Vector3.Distance(transform.position, pointB.position) < 23.0f)
            {
                targetpoint = pointA.position;
            }
        }
        else
        {
            isPerch = true;
        }
    }
}

