using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GizmosExample : MonoBehaviour
{
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawCube(transform.position, Vector3.one);
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.magenta;
        Gizmos.DrawCube(transform.position, Vector3.one);
    }
}
