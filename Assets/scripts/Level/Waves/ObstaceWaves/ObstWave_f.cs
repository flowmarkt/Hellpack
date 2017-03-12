using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstWave_f : Wave
{
    public override void GenerateWave(float deltaZ)
    {
        Instantiate(obstacle, new Vector3(0, -2, deltaZ + 1), obstacle.transform.rotation);
        Instantiate(obstacle, new Vector3(-2, -2, deltaZ + 3), obstacle.transform.rotation);
    }
}
