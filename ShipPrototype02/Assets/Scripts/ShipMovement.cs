using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    public float speed = 5.0f;
    public float turnSpeed;
    public float verticalInput;
    public float horizontalInput;
    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
       //Vertical Input
       verticalInput = Input.GetAxis("Vertical");
       //HorizontalInput
       horizontalInput = Input.GetAxis("Horizontal");

       //Move plane forward at constant speed
       transform.Translate(Vector3.left*Time.deltaTime*speed);

       //Tile Plane up and down
       transform.Rotate(-Vector3.forward, turnSpeed * verticalInput * Time.deltaTime);
       //Tilts left and right
       transform.Rotate(Vector3.right * Time.deltaTime * speed * horizontalInput);

       if (Input.GetKeyDown(KeyCode.Space)){
           Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
       }
    }
}
