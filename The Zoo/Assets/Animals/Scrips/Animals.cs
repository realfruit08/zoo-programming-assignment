using UnityEngine;

public abstract class Animals
{
    public float hunger;
    public float hungerSpeed;
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
        isHowling = true;

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
