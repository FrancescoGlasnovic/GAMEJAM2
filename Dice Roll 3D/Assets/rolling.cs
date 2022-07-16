using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rolling : MonoBehaviour
{
    [SerializeField] private float _rollSpeed = 5;
    bool _isMoving;

    public GameObject target;


    private void Update()
    {
        if (_isMoving) return;

       

        void Assemble(Vector3 dir)
        {
            var anchor = target.transform.position;
            var axis = Vector3.Cross(Vector3.back, dir);
            StartCoroutine(Roll(anchor, axis));

        }
        if (Input.GetKey(KeyCode.A)) Assemble(Vector3.left);
        else if (Input.GetKey(KeyCode.D)) Assemble(Vector3.right);
        else if (Input.GetKey(KeyCode.W)) Assemble(Vector3.up);
        else if (Input.GetKey(KeyCode.S)) Assemble(Vector3.down);
        
    }

    private IEnumerator Roll(Vector3 anchor, Vector3 axis)
    {
        _isMoving = true;
        for (var i = 0; i < 90 / _rollSpeed; i++)
        {
            this.transform.RotateAround(this.transform.position, axis, _rollSpeed);
            yield return new WaitForSeconds(0.01f);
        }
        _isMoving = false;
    }
}

