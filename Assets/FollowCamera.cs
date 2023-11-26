using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{

    [SerializeField] GameObject Cars;

    void LateUpdate()
    {
        followerCamera();
    }

    void followerCamera()
    {
        transform.position = Cars.transform.position + new Vector3(0, 0, -10);

    }
}
