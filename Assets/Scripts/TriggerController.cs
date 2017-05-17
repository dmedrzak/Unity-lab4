using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerController : MonoBehaviour {
    public GameObject LightG;
    public GameObject obj;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Collider>().CompareTag("Player"))
        {
            LightG.GetComponent<Light>().color = Color.red;
            for (int i = 0; i < 20; i++)
            {
                Rotate(i);
            }
        }
    }

    void Rotate(int i)
    {
        obj.transform.Rotate(new Vector3(15, 30, 45) *i);
              
    }


    private void OnTriggerExit(Collider other)
    {
        
        if (other.GetComponent<Collider>().CompareTag("Player"))
        {
            LightG.GetComponent<Light>().color = Color.yellow;
        }
    }


}
