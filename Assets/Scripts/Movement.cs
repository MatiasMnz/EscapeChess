using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
public class MoveObject : MonoBehaviour
{
    [SerializeField]float speed = 2;
    [SerializeField]float distance = 5;

    private UnityEngine.Vector3 startPosition;
    private UnityEngine.Vector3 limitForward;
    private UnityEngine.Vector3 limitBackward;

    private bool MovementTrue = true;

    void Start()
    {
    startPosition = transform.position;
    limitForward = startPosition + UnityEngine.Vector3.forward * distance;
    limitBackward = startPosition - UnityEngine.Vector3.forward * distance;
    }

    void Update()
    {
        float movement = speed * Time.deltaTime;
        if(MovementTrue)
        {
            transform.Translate(UnityEngine.Vector3.forward * movement);
            if(transform.position.z >= limitForward.z)
            {
            MovementTrue = false;
            }
        }
        else
        {
        transform.Translate(UnityEngine.Vector3.back * movement);
        if(transform.position.z <= limitBackward.z)
        {
            MovementTrue = true;
        }
        }
    }
}

