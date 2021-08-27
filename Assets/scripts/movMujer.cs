using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movMujer : MonoBehaviour
{
    private Rigidbody2D Rigidbody2D;
    private float Horizontal;
    public float Speed;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       Horizontal = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        Rigidbody2D.velocity = new Vector2(Horizontal*Speed, Rigidbody2D.velocity.y);
    }
}
