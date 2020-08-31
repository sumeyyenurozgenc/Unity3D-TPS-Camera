using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TPSCamera : MonoBehaviour
{
    public float turnSpeed;
    public Transform player;
    public float distanceY, distanceZ;
    private float firstY, firstZ;
    private Vector3 cameraDistance;

    void Start()
    {
        distanceY = 5f;
        firstY = distanceY;
        distanceZ = 5f;
        firstZ = distanceZ;
        cameraDistance = new Vector3(player.position.x, player.position.y + distanceY, player.position.z + distanceZ);
    }
    void LateUpdate()
    {
        if(distanceY != firstY)
        {
            cameraDistance = new Vector3(player.position.x, player.position.y + distanceY, player.position.z + distanceZ);
            firstY = distanceY;
        }
        if (distanceZ != firstZ)
        {
            cameraDistance = new Vector3(player.position.x, player.position.y + distanceY, player.position.z + distanceZ);
            firstZ = distanceZ;
        }
        cameraDistance = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * turnSpeed, Vector3.up) * cameraDistance;
        transform.position = player.position + cameraDistance;
        transform.LookAt(player.position);
    }
}
