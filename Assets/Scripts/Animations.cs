using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations : MonoBehaviour
{
    public string animName;
    public string animNameExit;
    public string gameObjectName;
    public int quantity;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="PlayerTrigger")
        {
            for (int i=0; i<quantity;i++)
            {
                GameObject.Find(gameObjectName + "_"+ i.ToString()).GetComponent<Animator>().SetTrigger(animName);
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "PlayerTrigger")
        {
            for (int i = 0; i < quantity; i++)
            {
                GameObject.Find(gameObjectName + "_" + i.ToString()).GetComponent<Animator>().SetTrigger(animNameExit);
            }
        }
    }
}
