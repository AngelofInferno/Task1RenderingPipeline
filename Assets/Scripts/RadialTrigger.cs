using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
public class RadialTrigger : MonoBehaviour
{
    [SerializeField] private Transform targetPoint;
    [SerializeField] private float radius;
    private void OnDrawGizmos()
    {
        Vector3 vectorToTarget = targetPoint.position - transform.position;

        Handles.color = Color.red;
        
        var distance = Mathf.Sqrt(vectorToTarget.x * vectorToTarget.x + vectorToTarget.y * vectorToTarget.y);
        
        if (distance < radius)
        {
            Handles.color = Color.cyan;
        }
        Handles.DrawWireDisc(transform.position, Vector3.forward, radius);
    }
    
    
}
