using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemycontroller : MonoBehaviour
{
    public NavMeshAgent Enemy;

    GameObject target;

    float MaxDist = 0f;

    public int maxHealth = 30;
    public int currentHealth;

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
            FocusingPlayer();
       
    }
    
    void FixedUpdate()
    {
        /*
        if (PauseMenu.Gameispaused == false)
        {
            Enemy.SetDestination(target.transform.position);
        }
        */
    }
    
    void FocusingPlayer()
    {
            Enemy.SetDestination(target.transform.position);
    }

}
