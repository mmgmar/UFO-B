using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrPlayer : MonoBehaviour
{
    float x, y; // variables per guardar lectura dels cursos

    [SerializeField]
    float forsa = 3;
    // Per accedir al component RigidBody:
    Rigidbody2D rb;
    ScrPickup scrP;

    // [SerializeField]
    // float velocitat = 3;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // ara rb apunta al component RigidBody2D del player
        print("En questa escena: " + ScrControlGame.pickups);
    }

    // Update is called once per frame
    void Update()
    {
        // float x, y; // per llegir gamepad
        x = Input.GetAxis("Horizontal"); // llegim moviment horizontal
        y = Input.GetAxis("Vertical"); //llegim moviment vertical


        // print("Horizontal : " + x + " / Vertical: " + y); //mostrem x e y
        // transform.Translate(x *Time.deltaTime*velocitat, y*Time.deltaTime*velocitat, 0);

    }

    private void FixedUpdate()
    {
        rb.AddForce(new Vector2(x * forsa, y * forsa));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // print(collision.name);
        // if (collision.tag == "pickup") Destroy(collision.gameObject);
        // if (collision.CompareTag("pickup")) Destroy(collision.gameObject);
        if (collision.CompareTag("pickup"))
        {
            scrP = collision.GetComponent<ScrPickup>();
            ScrControlGame.punts += scrP.valor; // accedir al valor del pickup
            ScrControlGame.pickupRestants--;
            Destroy(collision.gameObject);
            ScrControlGame.pickups--;
            

        }

    }

}


