using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnEnemy : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D enemy)
    {
        if (enemy.transform.tag == "Enemy")
        {
        enemy.GetComponent<EnemyController>().EnemySpeed = - enemy.GetComponent<EnemyController>().EnemySpeed;
        }
      
    }
}
