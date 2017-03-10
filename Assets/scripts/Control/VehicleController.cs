using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleController : MonoBehaviour
{

    private Vector3 targetPosition;

    private GameObject vehicle;

    [Range(1, 50)]
    public float speed;

    void Start()
    {
        vehicle = GameObject.Find("Vehicle");
    }


    void Update()
    {
        #region GetInput
        if (Input.GetMouseButton(0))
        {
            targetPosition = new Vector3(Mathf.Clamp(Input.mousePosition.x/80f,-2f,2f), -2, 0);//TODO resolution független
        }
        #endregion

        #region MoveVehicle
        float distance = (targetPosition - vehicle.transform.position).magnitude;
        vehicle.transform.position = Vector3.Lerp(vehicle.transform.position, targetPosition, Time.deltaTime * distance * speed);
        #endregion
    }
}
