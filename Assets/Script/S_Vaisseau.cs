using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Vaisseau : MonoBehaviour
{
    public float speed = 2f;

    private Rigidbody2D rb;

    private Vector2 movementDirection;

    private int life = 3;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movementDirection = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector3(movementDirection.x, movementDirection.y, 0f) * speed;
    }

    public void OnTriggerEnter2D(Collider2D other)
    { 
        if (other.transform.tag == "enemy")
            {
            life = TakeDamage(life, other);

            if (life == 0)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
            }
        }
    }

    public int TakeDamage(int life, Collider2D other)
    {
        life--;
        Debug.Log(life);
        Destroy(other.gameObject);
        Destroy(GameObject.Find("coeur" + life));
        return life;
    }
 }