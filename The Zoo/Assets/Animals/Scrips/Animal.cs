using UnityEngine;

public abstract class Animal : MonoBehaviour
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
