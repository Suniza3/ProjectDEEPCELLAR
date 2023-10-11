using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderGraph;
using UnityEngine;
using UnityEngine.AI;


public class EnemyMovement : MonoBehaviour
{
    private Vector3 target;
    NavMeshAgent agent;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }

    void Update()
    {
        SetTargetPosition();
        SetAgentPosition();
    }

    void SetTargetPosition()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
    }

    void SetAgentPosition() 
    {
        agent.SetDestination(new Vector3(target.x, target.y, transform.position.z));
    }
}