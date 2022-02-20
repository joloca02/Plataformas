using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D PlayerRB;
    Animator myAnimator;
    // Start is called before the first frame update
    void Start()
    {
        PlayerRB = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float movimiento = Input.GetAxis("Horizontal");
        if (movimiento < 0)
        {
            GetComponent<SpriteRenderer>().flipX=true;
        }
        else if (movimiento > 0)
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }
        PlayerRB.velocity = new Vector2(movimiento * 3, PlayerRB.velocity.y);
        myAnimator.SetFloat("Velocidad",Mathf.Abs(movimiento));
    }
}
