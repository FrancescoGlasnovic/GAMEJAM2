using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delete : MonoBehaviour
{
    public GameObject plane;
   
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
        
    }
}
