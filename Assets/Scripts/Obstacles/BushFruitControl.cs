using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BushFruitControl : MonoBehaviour
{
    public float moveDistance; 
    public float moveSpeed; 
    private bool moveRight = true; 

    private Vector3 initialPosition; 

    void Start()
    {
        initialPosition = transform.position;
    }

    void Update()
    {
        if (moveRight)
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime); 
        }
        else
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime); 
        }
        
        if (Vector3.Distance(transform.position, initialPosition) >= moveDistance)
        {
            moveRight = !moveRight;
        }
    }
}
