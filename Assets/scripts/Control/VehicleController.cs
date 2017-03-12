using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleController : MonoBehaviour
{

    private Vector3 targetPosition = new Vector3(0,-2,0);

    private GameObject vehicle;

    [Range(1, 50)]
    public float speed;

    void Start()
    {
        vehicle = GameObject.Find("Vehicle");
    }


    void Update()
    {
        #region GetTarget
        if (Input.GetMouseButton(0))
        {
            //  input.mouseposition     targetposition
            //  0                        -2
            //  Screen.width*0.3         -2
            //  Screen.width/2           0
            //  Screen.width*0.7f        2
            //  Screen.width             2

            float newX = Input.mousePosition.x;
            newX = (10f*newX)/ Screen.width-5;
            newX = Mathf.Clamp(newX,-2,2);

            targetPosition = new Vector3(newX,-2,0);
        }
        #endregion

        #region MoveVehicle
        float distance = (targetPosition - vehicle.transform.position).magnitude;
        vehicle.transform.position = Vector3.Lerp(vehicle.transform.position, targetPosition, Time.deltaTime * Mathf.Pow(distance,1.5f) * speed);
        #endregion
    }
}
