using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Transform tf;
    public float speed;
    public float distance;
    private Vector3 refSpeed;
    private Vector3 targetPosition;
    void MoveUp()
    {
        targetPosition = new Vector3(transform.position.x, transform.position.y + distance, transform.position.z);
        gameObject.transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref refSpeed,1);
    }
}
