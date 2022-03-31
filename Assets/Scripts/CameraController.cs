using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{
    /**
    public float cameraDistance = 3f;

    void LateUpdate()
    {
        transform.LookAt(GameObject.FindGameObjectWithTag("Player").transform.position);
        transform.position = GameObject.FindGameObjectWithTag("Player").transform.position - GameObject.FindGameObjectWithTag("Player").transform.forward * cameraDistance;
        
        transform.position = new Vector3(transform.position.x, 94f, transform.position.z);
    }
    **/

    
    public float cameraDistance = 3f;


    void LateUpdate()
    {

        transform.position = GameObject.FindGameObjectWithTag("Player").transform.position - GameObject.FindGameObjectWithTag("Player").transform.forward * cameraDistance;
        transform.LookAt(GameObject.FindGameObjectWithTag("Player").transform.position);
        transform.position = new Vector3(transform.position.x, 94f, transform.position.z);

        transform.rotation = (GameObject.FindGameObjectWithTag("Player").transform.rotation * Quaternion.Euler(25, 0, 0));
    }
    


    /**
    private GameObject target;
    private float speed = 5;

    Vector3 offset;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player");
        offset = target.transform.position - transform.position;
    }

    void LateUpdate()
    {
        // Look
        var newRotation = Quaternion.LookRotation(target.transform.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, newRotation, speed * Time.deltaTime);

        // Move
        Vector3 newPosition = target.transform.position - target.transform.forward * offset.z - target.transform.up * offset.y;
        transform.position = Vector3.Slerp(transform.position, newPosition, Time.deltaTime * speed);
    }
    **/
}