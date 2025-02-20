using UnityEngine;

public class Wolf : Animal
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