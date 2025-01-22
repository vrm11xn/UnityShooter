using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPC_Movement : MonoBehaviour
{
    public Transform target; // „W„u„|„Ž, „{ „{„€„„„€„‚„€„z „q„…„t„u„„ „t„r„y„s„p„„„Ž„ƒ„‘ NPC

    private NavMeshAgent agent;

    void Start() {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update() {
        if (target != null) {
            agent.SetDestination(target.position); // „T„ƒ„„„p„~„p„r„|„y„r„p„u„} „ˆ„u„|„Ž „t„|„‘ „t„r„y„w„u„~„y„‘
        }
    }
}
