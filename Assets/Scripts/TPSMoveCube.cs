using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TPSMoveCube : MonoBehaviour
{
    public float speed;
    private void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        transform.Translate(horizontal * speed * Time.deltaTime, 0, vertical * speed*Time.deltaTime);
    }
}
