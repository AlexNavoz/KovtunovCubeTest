using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnerScript : MonoBehaviour
{
    public InputField DistanceInput;
    public InputField SpeedInput;
    public InputField SpawnTimeInput;

    float spawnTimeCount = 0;

    public GameObject Cube;
    public bool cubeIsAlive;
    float SpawnTime, Speed, Distance;

    void Start()
    {
        
    }
    public void SpawnTimeChanging()
    {
        SpawnTime = float.Parse(SpawnTimeInput.text);
    }
    public void SpeedChanging()
    {
        Speed = float.Parse(SpeedInput.text);
    }
    public void DistanceChanging()
    {
        Distance = float.Parse(DistanceInput.text);
    }
    private void Update()
    {
        
        if (SpawnTimeInput.text == null && SpawnTimeInput.text.Length == 0)
        {
            return;
        }
        if (SpeedInput.text == null && SpeedInput.text.Length == 0)
        {
            return;
        }
        if (DistanceInput.text == null && DistanceInput.text.Length == 0)
        {
            return;
        }


        if (SpawnTime > 0 && Speed != 0 && Distance > 0)
        {
            spawnTimeCount += Time.deltaTime;
            if (spawnTimeCount > SpawnTime)
            {
                SpawnCube(Distance, Speed);
            }
        }
    }

    public void SpawnCube (float Distance, float Speed)
    {
        CubeMovingScript cubeScript = Instantiate(Cube).GetComponent<CubeMovingScript>();
        cubeScript.startMoveDistance = Distance;
        cubeScript.moveSpeed = Speed;
        spawnTimeCount = 0;
    }

}
