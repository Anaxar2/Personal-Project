using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleProjectile : MonoBehaviour
{
    public float speed = 10f;
    private float rightBound = 20;
    private float leftBound = -20;
    private PlayerControls pc;


    // Start is called before the first frame update
    void Start()
    {
        pc = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControls>();
        if (pc.isFacingRight == true) // checks if player is facing right is true.
            speed = 5; //Moves right.
        else // checks if player isn't facing right.
        {
            speed = -5; //Moves left
        }
    }


    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime); //Projectile.
      
        if (transform.position.x > rightBound) //if projectile goes beyond rightbound (x axis).
        {
            Destroy(gameObject); //Destroys projectile.
        }
        else if (transform.position.x < leftBound) //if projectile goes beyond leftbound (x axis).
        {
            Destroy(gameObject); //Destroys projectile.
        }
    }
}
 