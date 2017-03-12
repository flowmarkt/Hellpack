using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWave_a : Wave {

    public override void GenerateWave(float deltaZ)
    {
        Instantiate(collectible, new Vector3(2, -2, deltaZ), collectible.transform.rotation);

        GameObject newObject;

        newObject = Instantiate(enemy, new Vector3(2, -2, deltaZ), Quaternion.identity);
        newObject.GetComponent<CirculatePattern>().period = 3.5f;
        newObject.GetComponent<CirculatePattern>().offset = 0f;
        newObject.GetComponent<EnemyFire>().period = 3.5f;
        newObject.GetComponent<EnemyFire>().offset = 0f;

        newObject = Instantiate(enemy, new Vector3(-2, -2, deltaZ), Quaternion.identity);
        newObject.GetComponent<CirculatePattern>().period = 3.5f;
        newObject.GetComponent<CirculatePattern>().offset = 3.5f;
        newObject.GetComponent<EnemyFire>().period = 3.5f;
        newObject.GetComponent<EnemyFire>().offset = 3.5f;
    }
}
