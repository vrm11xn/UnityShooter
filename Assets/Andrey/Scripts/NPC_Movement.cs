using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPC_Movement : MonoBehaviour {
    public Transform target; // „W„u„|„, „{ „{„€„„„€„‚„€„z „q„…„t„u„„ „t„r„y„s„p„„„„ƒ„‘ NPC
    private NavMeshAgent agent;

    [Header("Health Settings")]
    public int maxHealth = 100; // „M„p„{„ƒ„y„}„p„|„„~„€„u „x„t„€„‚„€„r„„u
    private int currentHealth;  // „S„u„{„…„‹„u„u „x„t„€„‚„€„r„„u

    [Header("Texture Change")]
    public Renderer npcRenderer; // „R„ƒ„„|„{„p „~„p „‚„u„~„t„u„‚„u„‚ NPC
    public Material damagedMaterial; // „M„p„„„u„‚„y„p„|, „{„€„„„€„‚„„z „q„…„t„u„„ „„‚„y„}„u„~„‘„„„„ƒ„‘ „„‚„y 0 HP
    private bool isDead = false; // „U„|„p„s „ƒ„}„u„‚„„„y

    void Start() {
        agent = GetComponent<NavMeshAgent>();
        currentHealth = maxHealth; // „T„ƒ„„„p„~„p„r„|„y„r„p„u„} „„€„|„~„€„u „x„t„€„‚„€„r„„u „„‚„y „ƒ„„„p„‚„„„u
    }

    void Update() {
        if (target != null && !isDead) {
            agent.SetDestination(target.position); // „T„ƒ„„„p„~„p„r„|„y„r„p„u„} „ˆ„u„|„ „t„|„‘ „t„r„y„w„u„~„y„‘
        }
    }

    public void TakeDamage(int damage) {
        if (isDead) return; // „E„ƒ„|„y „…„w„u „}„u„‚„„„r, „y„s„~„€„‚„y„‚„…„u„} „…„‚„€„~

        currentHealth -= damage;
        if (currentHealth <= 0) {
            Die();
        }
    }

    void Die() {
        isDead = true;
        agent.isStopped = true; // „O„ƒ„„„p„~„p„r„|„y„r„p„u„} NPC
        npcRenderer.material = damagedMaterial; // „M„u„~„‘„u„} „„„u„{„ƒ„„„…„‚„…
    }

    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.CompareTag("Bullet")) { // „P„‚„€„r„u„‚„‘„u„}, „„€„„p„|„p „|„y „„…„|„‘
            TakeDamage(20); // „N„p„„‚„y„}„u„‚, „„…„|„‘ „€„„„~„y„}„p„u„„ 20 HP
        }
    }
}
