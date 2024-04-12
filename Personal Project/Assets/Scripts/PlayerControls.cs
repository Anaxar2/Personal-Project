using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    private float horizontaLInput;
    private float verticalInput;
    public float speed = 7f;
    GameObject circleProjectile;

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
            
        }
        
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            //Instantiate(circleProjectile, transform.position, + new Vector3., circleProjectile.transform.rotation);
        }

    }

}
