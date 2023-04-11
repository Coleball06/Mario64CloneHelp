using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SmallsAI : MonoBehaviour
{
    public GameObject player;
    UnityEngine.AI.NavMeshAgent agent;
    public float Deg;
    private Animator anim;
    public GameObject object1;
    public GameObject object2;
    public float distance;
    public float speed = 4.5f;

    void Start()
    {
        anim = GetComponent<Animator>();
        agent = gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    void Update()
    {
        Vector3 dir = player.transform.position - transform.position;
        if(Mathf.Abs(Vector3.Angle(transform.forward,dir))<Deg)
        {
            agent.SetDestination(player.transform.position);   
        }

        distance = Vector3.Distance(object1.transform.position, object2.transform.position);
        anim.SetFloat("Distance", distance);

        Vector3 movement = Vector3.zero;
        anim.SetFloat("Speed", movement.sqrMagnitude);
    }
}
