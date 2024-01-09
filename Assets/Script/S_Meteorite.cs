using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class S_Meteorite : MonoBehaviour
{

    public float gravity;
    public Rigidbody2D rb;
    public float randomGravity;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        randomGravity = Random.Range(1,20);
    }

    public void FixedUpdate()
    {
        rb.AddForce(new Vector3(0, -1.0f, 0) * rb.mass * randomGravity);
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "destroyed")
        {
            Debug.Log("Objet detruit");
            Destroy(gameObject);
        }

    }
}
