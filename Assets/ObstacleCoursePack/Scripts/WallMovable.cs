using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMovable : MonoBehaviour
{
	//INICIALIZAMOS LAS VARAIBLES

	public bool isDown = true; 
	public bool isRandom = true; 
	public float speed = 2f;

	private float height; 
	private float posYDown; 
	private bool isWaiting = false; 
	private bool canChange = true; 

	
	//METODO DE INICIALIZACION
	void Awake()
    {
		height = transform.localScale.y; // la variable height toma un nuevo valor
		if(isDown)
			posYDown = transform.position.y; // si se cumple la condicion posyDown toma una nueva variable
		else
			posYDown = transform.position.y - height; // si no se cumple ninguna de las condiciones posYdown toma un nuevo valor
	}

    // Update is called once per frame
    void Update()
    {
		if (isDown)
		{
			if (transform.position.y < posYDown + height)
			{
				transform.position += Vector3.up * Time.deltaTime * speed; // si se cumple estas condicion ira subiendo de posicion y 
			}
			else if (!isWaiting)
				StartCoroutine(WaitToChange(0.25f)); // si se cumple esta condicion inicia una corrutina
		}
		else
		{
			if (!canChange) //Si no se cumple ninguna de las condicionesa anteriores reentornara
				return;

			if (transform.position.y > posYDown)
			{
				transform.position -= Vector3.up * Time.deltaTime * speed; // bajara la posicion del objeto en Y
			}
			else if (!isWaiting)
				StartCoroutine(WaitToChange(0.25f)); // incializa una corrutina
		}
	}

	//Function that wait before go down or up
	IEnumerator WaitToChange(float time)
	{
		isWaiting = true;
		yield return new WaitForSeconds(time);
		isWaiting = false;
		isDown = !isDown;

		if (isRandom && !isDown) //If is wall up and is random
		{
			int num = Random.Range(0, 2);
			//Debug.Log(num);
			if (num == 1)
				StartCoroutine(Retry(1.5f));
		}
	}

	//Function that checks every 1.25secs if can go down the wall
	IEnumerator Retry(float time)
	{
		canChange = false;
		yield return new WaitForSeconds(time);
		int num = Random.Range(0, 2);
		//Debug.Log("2-"+num);
		if (num == 1)
			StartCoroutine(Retry(1.25f));
		else
			canChange = true;
	}
}
