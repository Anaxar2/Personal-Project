using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    private float horizontaLInput;
    private float verticalInput;
    public float speed = 7f;
    public GameObject projectile;

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        horizontaLInput = Input.GetAxis("Horizontal"); //left and right movement
        transform.Translate(Vector3.right * horizontaLInput * speed * Time.deltaTime);

        if (Input.GetKeyDown("space"))
        {
          transform.Translate(Vector3.up * 200 * Time.deltaTime, Space.World);
        }
        
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
          Instantiate(projectile, transform.position, projectile.transform.rotation);
        }

    }

}
