using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstWave_b : Wave
{
    public override void GenerateWave(float deltaZ)
    {
        Instantiate(collectible, new Vector3(0, -2, deltaZ), collectible.transform.rotation);
        Instantiate(obstacle, new Vector3(0, -2, deltaZ + 1), obstacle.transform.rotation);
        Instantiate(obstacle, new Vector3(0, -2, deltaZ + 2), obstacle.transform.rotation);
        Instantiate(obstacle, new Vector3(0, -2, deltaZ + 3), obstacle.transform.rotation);
        Instantiate(obstacle, new Vector3(-1, -2, deltaZ + 4), obstacle.transform.rotation);
    }
}
