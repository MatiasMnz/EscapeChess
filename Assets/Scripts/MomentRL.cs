using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MomentRL : MonoBehaviour
{
    [SerializeField] float speed = 2;
    [SerializeField] float distance = 5;

    private UnityEngine.Vector3 startPosition;
    private UnityEngine.Vector3 limitRight;
    private UnityEngine.Vector3 limitLeft;
    private bool MovementTrue = true;

    void Start()
    {
        startPosition = transform.position;
        limitRight = startPosition + UnityEngine.Vector3.right * distance;
        limitLeft = startPosition - UnityEngine.Vector3.right * distance;
    }

    void Update()
    {
        float movement = speed * Time.deltaTime;
        if(MovementTrue)
        {
            transform.Translate(UnityEngine.Vector3.right * movement);
            if(transform.position.x >= limitRight.x)
            {
                MovementTrue = false;
            }
        }
        else
        {
            transform.Translate(UnityEngine.Vector3.left * movement);
            if(transform.position.x <= limitLeft.x)
            {
                MovementTrue = true;
            }
        }
    }
}
