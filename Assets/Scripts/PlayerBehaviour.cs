using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{

    public float speed;
    public int hp;
    private Animator anim;
    private Rigidbody2D rb2d;

    void Start()
    {
        anim = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f)
        {
            MovePlayer("Horizontal");
        }
        if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f)
        {
            MovePlayer("Vertical");
        }
        anim.SetFloat("MoveX", Input.GetAxisRaw("Horizontal"));
        anim.SetFloat("MoveY", Input.GetAxisRaw("Vertical"));


    }
    
    private void MovePlayer(string axe)
    {
        switch (axe)
        {
            case "Horizontal":
                rb2d.MovePosition(new Vector2(transform.position.x + Input.GetAxisRaw("Horizontal") * speed * Time.fixedDeltaTime , transform.position.y));
               // transform.Translate(new Vector2(Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime, 0f));
                break;
            case "Vertical":
                rb2d.MovePosition(new Vector2(transform.position.x, transform.position.y + Input.GetAxisRaw("Vertical") * speed * Time.fixedDeltaTime));
                //transform.Translate(new Vector2(0f, Input.GetAxisRaw("Vertical") * speed * Time.deltaTime));
                break;
        }
    }
}