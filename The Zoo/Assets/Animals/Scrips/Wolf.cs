using UnityEngine;

public class Wolf : Animal
{
    public GameObject wolf;
    bool isHowling;
    bool inRange = false;

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
                Debug.Log("Awoooo!");
            }

        }
        else
        {
            isSleeping = true;
            Debug.Log("snore");
        }
    }
    private void Update()
    {
        if (inRange)
        {
            Howl();
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