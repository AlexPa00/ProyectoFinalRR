using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBall : MonoBehaviour
{
    [SerializeField]
    private float speedZ;


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(speedZ * Time.deltaTime, 0, 0);
        if (transform.position.z > -5f)
        {
            Destroy(gameObject);
        }
    }

}