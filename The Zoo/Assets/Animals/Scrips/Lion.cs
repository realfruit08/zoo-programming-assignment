using UnityEngine;
using UnityEngine.U2D;

public class Lion : Animal
{
    public GameObject lion;
    public GameObject steak;
    bool inRange = false;

    public void Wander()
    {
        hunger = 0;
        hungerCount = hunger;
        moveSpeed = 2.0f;
        if (Input.GetKeyDown(KeyCode.E))
        {
            isMoving = true;
            transform.position = Vector3.MoveTowards(transform.position, targetpoint, moveSpeed * Time.deltaTime);
            hungerCount++;
            Debug.Log("Moving");
            Debug.Log("food" + hungerCount);
        }
        else
        {
            Debug.Log("Sleeping");
            isSleeping = true;
        }
    }

    private void Update()
    {
        if (inRange)
        {
            Wander();
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