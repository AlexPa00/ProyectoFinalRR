using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallPlat : MonoBehaviour
{
	public float fallTime = 0.5f;


	void OnCollisionEnter(Collision collision)
	{
		foreach (ContactPoint contact in collision.contacts)
		{
			//Debug.DrawRay(contact.point, contact.normal, Color.white);
			if (collision.gameObject.tag == "Player") // al entrar en colision el objeto con el tag player
			{
				StartCoroutine(Fall(fallTime));  // entra en una corrutina
			}
		}
	}

	IEnumerator Fall(float time) //función declarada con un tipo de retorno
	{
		yield return new WaitForSeconds(time); // es un interrupcion en la que tambien xe le puede asugnar un retardo	
		Destroy(gameObject); //se destruye el objeto
	}
}
