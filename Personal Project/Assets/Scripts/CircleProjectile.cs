using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleProjectile : MonoBehaviour
{
    public float speed = 10f;
    private float rightBound = 10;
    private float leftBound = -10;
    private PlayerControls pc;


    // Start is called before the first frame update
    void Start()
    {
        pc = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControls>();
        if (pc.isFacingRight == true)
            speed = 5;
        else
        {
            speed = -5;
        }
    }


    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
      
        if (transform.position.x > rightBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.x < leftBound)
        {
            Destroy(gameObject);
        }


    }
}
 