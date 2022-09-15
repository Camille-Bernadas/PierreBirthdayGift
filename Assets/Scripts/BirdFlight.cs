using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class BirdFlight : MonoBehaviour
{
    public float velocity = 1f;
    public bool isAlive = true;
    private Rigidbody2D rb;
    public ParticleSystem particles;
    void Start(){
        rb = GetComponent<Rigidbody2D>();
    }


    public void Flap(InputAction.CallbackContext ctx){
        if(ctx.performed && isAlive){
            particles.Stop();
            particles.Play();
            rb.velocity = Vector2.up * velocity;
        }
    }
    public void OnCollisionEnter2D(Collision2D collision2D){
        GameManager.GetInstance().GameOver();
    }

    void Update(){
        transform.rotation = Quaternion.Euler(0f, 0f, Mathf.Clamp(rb.velocity.y, -4f, 4f)*11.25f);

    }
}
