using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCylinder : MonoBehaviour
{
    [SerializeField]
    private float SpeedX = 3; //Velocidad de movimiento de los cilindros.

    // Update is called once per frame
    void Update()
    {
       transform.Rotate(SpeedX*Time.deltaTime,0,0) ; //Los cilindros rotaran con respecto al eje "x".
        
    }
 
}
