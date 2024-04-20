using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMover : Mover
{
    [SerializeField] private List<Vector3> _wayPoints;
    
    private void Awake()
    {
        int minPointsCount = 2;

        if (_wayPoints.Count >= minPointsCount)
        {
            Move();
        }
    }

    protected override void Move()
    {
        StartCoroutine(StartMoving());
    }

    private IEnumerator StartMoving()
    {
        bool isMoving = true;
        float minDistance = 0;
        int currentWayPointIndex = 1;

        while (isMoving)
        {
            Vector3 currentWayPoint = _wayPoints[currentWayPointIndex];
            transform.position = Vector3.MoveTowards(transform.position, currentWayPoint, Speed * Time.deltaTime);

            if (Vector3.Distance(transform.position, currentWayPoint) == minDistance)
            {
                int nextIndex = currentWayPointIndex + 1;
                int startingIndex = 0;

                if (nextIndex < _wayPoints.Count)
                {
                    currentWayPointIndex++;
                }
                else
                {
                    currentWayPointIndex = startingIndex;
                    _wayPoints.Reverse();
                }
            }

            yield return null;
        }
    }
}