using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigBullet : MonoBehaviour
{

    public Rigidbody2D monRigidBody;
    public float speed;
    public GameObject coin;
    public Joueur monJoueur;

    // Start is called before the first frame update
    void Start()
    {
        monRigidBody.velocity = Vector3.up * speed;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        Destroy(collision.gameObject);
        Destroy(gameObject);

        Instantiate(coin, transform.position, transform.rotation); //problème : si on tire sur la pièce ça refait une pièce 
    }
}
