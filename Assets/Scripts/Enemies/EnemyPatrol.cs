using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; // Make sure to include this library when coding on the NavMesh

public class EnemyPatrol : MonoBehaviour
{
    public Transform[] points;

    private NavMeshAgent impAgent;
    private int currentIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        impAgent = GetComponent<NavMeshAgent>();

        GoToNextPoint();
    }

    // Update is called once per frame
    void Update()
    {
        if (!impAgent.pathPending && impAgent.remainingDistance < impAgent.stoppingDistance)
        {
            GoToNextPoint();
        }
    }

    void GoToNextPoint()
    {
        // Do nothing if no waypoints are set up
        if (points.Length == 0)
            return;
        
        // Go to next destination
        impAgent.destination = points[currentIndex].position;
        
        // Get the next index
        // When at the end of the points array
        // Go back to the index of 0
        currentIndex = (currentIndex + 1) % points.Length;
        
        
        
    }
}
