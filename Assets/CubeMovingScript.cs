using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovingScript : MonoBehaviour
{
    public float startMoveDistance;
    float currentMovePoint;

    public float moveSpeed;
    public GameObject destroyParticle;
    void Start()
    {

    }


    void Update()
    {
        if (currentMovePoint < Mathf.Abs(startMoveDistance))
        {
            transform.position = new Vector3(transform.position.x + moveSpeed * Time.deltaTime, 0, 0);
            currentMovePoint = transform.position.x;
        }
        else
        {
            DestroyCube();
        }
    }
    void DestroyCube()
    {
        Instantiate(destroyParticle, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
