using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Navmesh : MonoBehaviour
{
    public Transform primaryGoal;
    public Transform secondaryGoal;
    public Transform tertiaryGoal;

    private Vector3 destination;
    private int useGoalIndex = 0;

    void Start()
    {
        SetupNavMeshAgentGoal();
    }

    void SetupNavMeshAgentGoal()
    {
        switch(useGoalIndex)
        {
            case 0:
                destination  = primaryGoal.position;
                useGoalIndex = 1;
                break;
            case 1:
                destination = secondaryGoal.position;
                useGoalIndex = 2;
                break;
            case 2:
                destination = tertiaryGoal.position;
                useGoalIndex = 0;
                break;
        }

        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = destination;
    }

    // Update is called once per frame
    void Update ()
    {
        if (Vector3.Distance(destination, transform.position) < 0.2f)
        {
            SetupNavMeshAgentGoal();
        }
    }
}
