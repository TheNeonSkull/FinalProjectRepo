using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    public float speed = 5.0f;

    public float horizontalInput;
    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
      
       //HorizontalInput
       horizontalInput = Input.GetAxis("Horizontal");
       transform.Translate(Vector3.forward * horizontalInput * Time.deltaTime * speed);

       //Move plane forward at constant speed
       transform.Translate(Vector3.left*Time.deltaTime*speed);

      

       if (Input.GetKeyDown(KeyCode.Space)){
           Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
       }
    }
}
