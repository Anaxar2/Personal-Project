using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public int LifeTotal = 2;
    public int EnemySpeed = 2;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
     rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = transform.right * EnemySpeed;
    }
}