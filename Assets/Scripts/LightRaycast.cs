using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightRaycast : MonoBehaviour
{
    public int rango;
    public Camera camara;

    void Update()
    {
        RaycastHit hit;
        if(Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, rango))
        {
            if(hit.collider.GetComponent<LightInteraction>() == true)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    if(hit.collider.GetComponent<LightInteraction>().luz == true)
                    {
                        hit.collider.GetComponent<LightInteraction>().OnOffLuz();
                    }
                }
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawRay(Camera.main.transform.position, Camera.main.transform.forward * rango);

    }
}
