using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{

    public GameObject plane;

    private void Start()
    {


        StartCoroutine(spawner());
    }
    IEnumerator spawner()
    {
        for(int i=0;i<1000;i++)
        {
            
            var number1 = Random.Range(-50, 50);
        var number2 = Random.Range(-50, 50);
        Instantiate(plane, new Vector3(number1, number2, 300), Quaternion.identity);
        Debug.Log(number2 + ", " + number1);
           
            if (i==999)
            {
                i = 0;
            }
         yield return new WaitForSeconds(3f);
        }
    }
}
