using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnHit : MonoBehaviour
{
    Color32 Brown = new Color32(101,52,2,255);
private void OnCollisionEnter(Collision other)
{
    if (other.gameObject.tag == "Player")
    {
    gameObject.tag = "Obstacle";
    }
}
}
