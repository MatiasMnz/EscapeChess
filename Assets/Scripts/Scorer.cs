using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Scorer : MonoBehaviour
{
    //private bool returning = false;
    private UnityEngine.Vector3 StartPosition = new UnityEngine.Vector3(-20.25f,-6.2249999f,-22.5300007f);
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            // Obtén todos los componentes MeshRenderer en este GameObject y sus hijos
            MeshRenderer[] renderers = GetComponentsInChildren<MeshRenderer>();
            foreach (MeshRenderer renderer in renderers)
            {
                renderer.material.color = Color.red;
            }
            Invoke("ReturnHome", 0.3f);
        }
        if (other.gameObject.tag == "Player")
    {
    GetComponent<MeshRenderer>().material.color = Color.white;
    }
    }


    void ReturnHome()
{
    transform.position = StartPosition;
    MeshRenderer[] renderers = GetComponentsInChildren<MeshRenderer>();
    foreach (MeshRenderer renderer in renderers)
    {
        renderer.material.color = Color.white;
    }
    //returning = false;
}
}


