using UnityEngine;

public abstract class Animals
{
    public float hunger;
    public float hungerCount;
    public float move;
    public float moveSpeed;
    public float sleep;

}

public class Lion : Animals
{
    public void Wander()
    {
        moveSpeed = 1.0f;
    }
}

public class Wolf : Animals
{
    bool isHowling;
    public void Howl()
    {
        hunger = 5;
        hungerCount = hunger;
        if (Input.GetKeyUp(KeyCode.E))
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
    bool isFlying;
    public void Fly()
    {
        isFlying = true;
        moveSpeed = 2.0f;
    }
}

public class I : Animals
{

}
