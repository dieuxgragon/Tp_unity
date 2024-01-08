using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;

public class Asteroide : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "mort")
        {
            Debug.Log(" Message pour tester la collision ");
            Destroy(GameObject.FindWithTag("enemy"));
        }
    }
}
