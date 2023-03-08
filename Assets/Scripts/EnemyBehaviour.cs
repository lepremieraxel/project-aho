using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{

    private Vector3 prevPos;
    private Animator anim;
    private AIPath aiPath;
    void Start()
    {
        anim = GetComponent<Animator>();
        aiPath= GetComponent<AIPath>();
    }

    void FixedUpdate()
    {
        EnemyAnim();
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        aiPath.canMove= false;
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        aiPath.canMove= true;
    }

    private void EnemyAnim()
    {
        if(transform.position.x < prevPos.x)
        {
            anim.SetFloat("Walk", -1);
        }
        else anim.SetFloat("Walk", 1);

        prevPos = transform.position;
    }
}
