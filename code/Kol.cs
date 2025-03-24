using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kol : MonoBehaviour
{
    public GameObject kol;
    public Camera camera;
    public void Pip()
    {
        Vector3 a = camera.transform.position;
        a.z = 0;
        Instantiate(kol, a, Quaternion.identity);
    }
}
