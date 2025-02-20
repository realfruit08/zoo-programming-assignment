using UnityEngine;

public abstract class Animals
{
    public float hunger;
    public float hungerCount;
    public bool isMoving;
    public float moveSpeed;
    public bool isSleeping;
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
    public void Fly()
    {
        Vector3 direction = Vector3.zero;
        moveSpeed = 2.0f;
        if (Input.GetKeyDown(KeyCode.E))
        {
            direction = Vector3.right;
            isFlying = true;
        }
    }
}

public class Alligator : Animals
{

}
