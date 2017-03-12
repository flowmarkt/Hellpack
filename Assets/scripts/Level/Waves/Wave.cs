using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Wave : MonoBehaviour {

    protected GameObject enemy;
    protected GameObject collectible;
    protected GameObject obstacle;


    void Start()
    {
        enemy = Resources.Load<GameObject>("Prefabs/Enemy");
        collectible = Resources.Load<GameObject>("Prefabs/Collectible");
        obstacle = Resources.Load<GameObject>("Prefabs/Obstacle");
    }

  
    
    public virtual void GenerateWave(float deltaZ)
    {
        return;
    }
    
}
