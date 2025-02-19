using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDoor : MonoBehaviour
{
    [SerializeField]
    private GameObject m_Door;

    private void OnTriggerEnter(Collider other)
    {
        //print("Something is close to the door.");
        if (other.gameObject.CompareTag("Player"))
        {
            //this.gameObject.transform.Translate(new Vector3(-4,0,0));
            m_Door.transform.Translate(new Vector3(-4, 0, 0));
        }
    }

    private void OnTriggerExit(Collider other)
    {
        //print("It has left");
        if (other.gameObject.CompareTag("Player"))
        {
            //this.gameObject.transform.Translate(new Vector3(4, 0, 0));

            m_Door.transform.Translate(new Vector3(4, 0, 0));
        }

    }

}
