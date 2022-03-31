using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private float speed = 5.0f;
    private float _rotationSpeed = 180;
    private Vector3 rotation;
    private bool rotating = false;

    private void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(horizontal, 0, vertical) * (speed * Time.deltaTime));

        
        rotation = new Vector3(0, Input.GetAxisRaw("Horizontal") * _rotationSpeed * Time.deltaTime, 0);
        transform.Rotate(rotation);

        //Rotation
        if (Input.GetKey(KeyCode.R))
        {
            rotating = true;
            gameObject.GetComponent<Animator>().SetTrigger("Tornado");
        }
        else if (Input.GetKeyUp(KeyCode.R))
        {
            rotating = false;
            gameObject.GetComponent<Animator>().SetTrigger("Idle");
        }

        //Walking
        if (horizontal != 0 || vertical != 0 && !Input.GetKey(KeyCode.R))
        {
            gameObject.GetComponent<Animator>().SetTrigger("Run");
        }
        else gameObject.GetComponent<Animator>().SetTrigger("Idle");

    }
}
