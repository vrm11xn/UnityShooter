using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPC_Movement : MonoBehaviour
{
    public Transform target; // �W�u�|��, �{ �{�����������z �q���t�u�� �t�r�y�s�p�������� NPC

    private NavMeshAgent agent;

    void Start() {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update() {
        if (target != null) {
            agent.SetDestination(target.position); // �T�����p�~�p�r�|�y�r�p�u�} ���u�|�� �t�|�� �t�r�y�w�u�~�y��
        }
    }
}
