using UnityEngine;

public class Bird : Animal
{
    public GameObject bird;
    bool isFlying;
    bool isPerch;
    bool inRange = false;

    public void Fly()
    {
        hunger = 3;
        hungerCount = hunger;
        moveSpeed = 2.0f;
        if (Input.GetKeyDown(KeyCode.E))
        {
            hungerCount++;
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
            isSleeping = true;
            Debug.Log("coo...coo...");
        }
    }
    private void Update()
    {
        if (inRange)
        {
            Fly();
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        inRange = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        inRange = false;
    }
}

