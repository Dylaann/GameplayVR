using UnityEngine;
using System.Collections;

public class HeadMovement : MonoBehaviour
{
    void Start()
    {
        Input.gyro.enabled = true;
    }

    void Update()
    {
        var moveX = Input.acceleration.x;

        var x = Input.gyro.rotationRateUnbiased.x;
        var y = Input.gyro.rotationRateUnbiased.y;
        var z = Input.gyro.rotationRateUnbiased.z;

        transform.Rotate(-x, -y, z);
        

    }
}
