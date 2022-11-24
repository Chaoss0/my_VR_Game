using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponIk : MonoBehaviour
{
    public UnityEngine.AI.NavMeshAgent agent;
    public Transform player;




    private void Awake() {
        player=GameObject.Find("Player").transform;
        agent.updatePosition = false;

    }

    private void Update() {
        agent.SetDestination(player.position);
    }
    


}
