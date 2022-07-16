using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pomicanje : MonoBehaviour
{
    int speed = 30  ;
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(new Vector3(-10f, 0f, 0f) * Time.deltaTime, Space.Self);
        }
         if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(new Vector3(10f, 0f, 0f) * Time.deltaTime, Space.Self);
        }
         if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(new Vector3(0f, 10f, 0f) * Time.deltaTime, Space.Self);
        }
       if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(new Vector3(0f, -10f, 0f) * Time.deltaTime, Space.Self);
        }
    }
}
