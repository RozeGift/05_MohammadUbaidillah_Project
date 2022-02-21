using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemycontroller : MonoBehaviour
{
    public NavMeshAgent Enemy;

    GameObject target;

    float MaxDist = 2f;

    public Animator Enemyani;

    public int maxHealth = 30;
    public int currentHealth;

    bool isdead = false;

    bool hasSpawned = false;

    // Start is called before the first frame update
    void Start()
    {
        //find player
        target = GameObject.Find("Player");
        //Health 
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        //health death;
        if (currentHealth <= 0)
        {
            isdead = true;
        }
        //when near or far from player
        if (isdead == false)
        {
            FocusingPlayer();
        }
    }
    /*
    void FixedUpdate()
    {
        if (FirstPersonController.PlayerDeath == false && isdead == false && PauseMenu.Gameispaused == false)
        {
            Enemy.SetDestination(target.transform.position);
        }
    }
    */
    void FocusingPlayer()
    {
        //near player
        if (Vector3.Distance(transform.position, target.transform.position) <= MaxDist)
        {
            Enemy.isStopped = true;
        }
        //not near player
        else if (Vector3.Distance(transform.position, target.transform.position) >= MaxDist)
        {
            Enemy.isStopped = false;
            Enemy.SetDestination(target.transform.position);
        }
    }
}
