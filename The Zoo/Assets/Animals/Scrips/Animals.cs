using UnityEngine;

public abstract class Animals
{
    public float hunger;
    public float hungerCount;
    public bool isMoving;
    public float moveSpeed;
    public bool isSleeping;
    public Transform pointA;
    public Transform pointB;

    public Vector3 targetpoint;

    void Start()
    {
        targetpoint = pointA.position;
    }
}

public class Lion : Animals
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
        }
        else
        {
            isSleeping = true; 
        }
    }
}

public class Wolf : Animals
{
    public GameObject wolf;
    bool isHowling;
    public void Howl()
    {
        hunger = 5;
        hungerCount = hunger;
        if (Input.GetKeyDown(KeyCode.E))
        {
            hungerCount--;
            if (hungerCount <= 0)
            {
                isHowling = true;
            }
            
        }
    }
}

public class Bird : Animals
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
            if (Vector3.Distance(transform.position, pointA.positon) < 14.0f)
            {
                targetpoint = pointB.positon;
            }
            else if (Vector3.Distance(transform.position, pointB.positon) < 23.0f)
            {
                targetpoint = pointA.positon;
            }
        }
        else
        {
            isPerch = true;
        }
    }
}

public class Alligator : Animals
{

}
