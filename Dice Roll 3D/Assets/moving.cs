using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving : MonoBehaviour
{
    int speed = 10;
    void Start()
    {
        
        Vector3 newPosition = transform.position;
        transform.position = newPosition;
    }

    void Update()
    {
        transform.position += new Vector3(0, 0, 1 * -Time.deltaTime*speed);
        
    }
}
