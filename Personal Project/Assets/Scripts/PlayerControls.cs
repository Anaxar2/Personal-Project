using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    [Header("Movement")]
    Rigidbody2D rb;
    private float horizontaLInput;
    public float speed = 7f;
    public bool isFacingRight;

    [Header("Jump")]
    public float jumpForce;
    public float gravity;
    bool grounded = true;
    public int jump = 2;

    [Header("Projectile")]
    public GameObject projectile;
    public float timer;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Physics2D.gravity *= gravity;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontaLInput = Input.GetAxis("Horizontal"); //left and right movement
        rb.velocity = new Vector2(horizontaLInput * speed, rb.velocity.y);

        //flips character right when moving.
        if (horizontaLInput > 0.01f)
        { transform.localScale = Vector3.one;
            isFacingRight = true;
        }
        //flips character left when moving.
        else if (horizontaLInput < -0.01f)
        { transform.localScale = new Vector3(-1, 1, 1);
            isFacingRight = false;
        }
        //Jump Mechanic.
        if (Input.GetKeyDown(KeyCode.Space) && jump > 0)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode2D.Impulse); 
            grounded = false;
            jump--;           
        }
        // Projectiles
        if (Input.GetKeyDown(KeyCode.B))
        {
            Instantiate(projectile, transform.position, projectile.transform.rotation); //Creates projectiles from player.
        }
        //cooldown per shot.
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "ground") // checks if you are colliding with object with ground tag.
        {
            grounded = true; // sets grounded is true.
            jump = 2; // resets jump count.
        }
    }
}