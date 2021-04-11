using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    
    public float speed = 10.0F;
    public float rotationSpeed = 100.0F;
    Rigidbody rb;
    //public GameObject _PlayerCamera;
    public Vector3 inputVector;

    // Update is called once per frame

    private void Start()
    {   
        rb = GetComponent<Rigidbody>();
        //_PlayerCamera = GameObject.FindGameObjectWithTag("MainCamera");
        //_PlayerCamera.transform.parent = transform;
    }

 

    void Update()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        Vector3 lookDir = translation * transform.forward;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        rotation *= Time.deltaTime;
        transform.Rotate(0, rotation, 0);
    

        //inputVector = new Vector3(0, 0, Input.GetAxis("Vertical")) ;
        rb.velocity = lookDir;
        //transform.LookAt(transform.position + new Vector3(Input.GetAxis("Horizontal"),0,0));


    
        /*  float translation = Input.GetAxis("Vertical") * speed;
          float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
          translation *= Time.deltaTime;
          rotation *= Time.deltaTime;
          transform.Translate(0, 0, translation);
          transform.Rotate(0, rotation, 0);*/
    }



}