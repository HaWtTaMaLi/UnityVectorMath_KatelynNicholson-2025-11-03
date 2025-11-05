using UnityEngine;
using System;

public class MoveTwoObjectsUsingSine : MonoBehaviour
{
    //SCENE 1
    //choose axis in inspector
    // use Sine 
    private Vector3 startPos;

    [SerializeField] 
    private float frequency = 5f;

    [SerializeField]
    private float magnitude = 5f;

    [SerializeField]
    private float offset = 0f;


    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        transform.position = startPos + transform.up * Mathf.Sin(Time.time + frequency + offset) * magnitude;
    }

}
