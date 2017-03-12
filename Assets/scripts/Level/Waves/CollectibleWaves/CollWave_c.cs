using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollWave_c : Wave {

    public override void GenerateWave(float deltaZ)
    {
        Instantiate(collectible, new Vector3(2, -2, deltaZ), collectible.transform.rotation);
        Instantiate(collectible, new Vector3(2, -2, deltaZ + 1), collectible.transform.rotation);
        Instantiate(collectible, new Vector3(2, -2, deltaZ + 2), collectible.transform.rotation);
        Instantiate(collectible, new Vector3(2, -2, deltaZ + 3), collectible.transform.rotation);
        Instantiate(collectible, new Vector3(2, -2, deltaZ + 4), collectible.transform.rotation);
    }
}
