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
        Instantiate(enemy1,new Vector3(Random.Range(3.61f, -2.83f), transform.position.y,-15.80f), transform.rotation);
        
    }
}
