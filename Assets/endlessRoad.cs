using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endlessRoad : MonoBehaviour
{
    public Transform yol1;
    public Transform yol2;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "duvar1")
        {
            yol2.position = new Vector3(yol1.position.x, yol1.position.y, yol1.position.z + 25.0f);
        }
        if (other.gameObject.name == "duvar2")
        {
            yol1.position = new Vector3(yol2.position.x, yol2.position.y, yol2.position.z + 25.0f);
        }
    }
    private void Update()
    {
        transform.Translate(Vector3.forward * 0.02f);
    }
}
