using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshCalabaza : MonoBehaviour
{
    public Transform objetivo; // se colocara en Objetico que seguira
    private NavMeshAgent agente;

    void Start()
    {
        agente = GetComponent<NavMeshAgent>();
        // Le asignaremos a la variable agente el componente que queremos acceder "NavMeshAgent"

    }

    void Update()
    {
        agente.destination = objetivo.position;
        // Dentro del metodo Update constantemente estara buscando el objetivo
    }
}
