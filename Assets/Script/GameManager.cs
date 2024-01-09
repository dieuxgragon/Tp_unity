using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject prefab;
    public float delai;

    private float prochainTemps;



    private void Update()
    {
        if (Time.time >= prochainTemps)
        {
            UnityEngine.Vector3 vector = new UnityEngine.Vector3(Random.Range(-10, 9), 6, 0);
            Instantiate(prefab, vector, transform.rotation);
            prochainTemps = Time.time + delai;
        }
    }
}
