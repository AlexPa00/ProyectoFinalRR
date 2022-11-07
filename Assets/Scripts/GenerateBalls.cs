using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateBalls : MonoBehaviour
{
    [SerializeField]
    private GameObject enemy1;
    [SerializeField]
    private float initTime;
    [SerializeField]
    private float repeatTime;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("GenerateEnemy", initTime, repeatTime);
    }


    public void GenerateEnemy()
    {
        Instantiate(enemy1,new Vector3(Random.Range(3.37f, -2.51f), transform.position.y,-15.61f), transform.rotation);
        
    }
}
