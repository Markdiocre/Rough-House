using System.Collections.Generic;
using UnityEngine;

public class Trajectory : MonoBehaviour
{
    public LineRenderer lineRenderer;
    public int maxSteps = 30;
    public float timeStep = 0.1f;
    public LayerMask collisionMask;

    public void DrawLine(Vector3 startPos, Vector3 velocity)
    {
        List<Vector3> points = new List<Vector3>();
        Vector3 currentPos = startPos;
        Vector3 direction = velocity.normalized;
        float speed = velocity.magnitude;

        for (int i = 0; i < maxSteps; i++)
        {
            points.Add(currentPos);
            Vector3 nextPos = currentPos + direction * speed * timeStep;

            currentPos = nextPos;
        }

        lineRenderer.positionCount = points.Count;
        lineRenderer.SetPositions(points.ToArray());
    }

    public void ClearLine()
    {
        lineRenderer.positionCount = 0;
    }
}
