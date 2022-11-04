using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float speed; //Nos sirve para indicar la velocidad de movimiento del Player.
    private float speedRotation;
    private float jump;
    private Rigidbody physicBody; //Permite detectar cuando el Player colisiona con otro cuerpo fisico.

    // Start is called before the first frame update
    void Start()
    {
    speed =5f;
    speedRotation=1000f;
    jump=5f;
    physicBody= GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       
      float posX = Input.GetAxis("Horizontal"); //Nos indica que se va a transladar de izquierda a derecha solo en el eje "x" a la velocidad indicada y normalizado a travez de Time.deltaTime.
      float posZ = Input.GetAxis("Vertical");  //Nos indica que se va a transladar de adelante hacia atras solo en el eje "z" a la velocidad indicada y normalizado a travez de Time.deltaTime.
      float rotationY = Input.GetAxis("Mouse X");

      transform.Translate(new Vector3(posX,0,posZ)*speed*Time.deltaTime);
      transform.Rotate(new Vector3(0,rotationY,0)*speedRotation*Time.deltaTime);

      if(Input.GetKeyDown(KeyCode.Space)) //Una vez que presionemos la barra espaciadora...
      {
        physicBody.AddForce(Vector3.up*jump,ForceMode.Impulse); //Al rigidbody del Player , le asigno un vector up y le multiplico por la fuerza de 4 unidades en el eje Y .. el impulse simula un salto.
      }
    }
}
