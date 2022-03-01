using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionTrigger : MonoBehaviour
{
    [Range(0f, 1f)][SerializeField] private float threshold;
    [SerializeField] private Transform targetPos;
    private void OnDrawGizmos()
    {
        //Vector3 sight = transform.position + Vector3.right;
        Vector3 range = (targetPos.position - transform.position).normalized;
        if (Vector3.Dot(transform.right, range) >= threshold)
        {
            Gizmos.color = Color.red;
        }
        else
        {
            Gizmos.color = Color.green;
        }
        Gizmos.DrawRay(transform.position, transform.right);
    }
}
