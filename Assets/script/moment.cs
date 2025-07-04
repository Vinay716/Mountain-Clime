using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEditor.Tilemaps;
using UnityEngine;

public class moment : MonoBehaviour
{
    [SerializeField]
    float momenta = 10f;
    [SerializeField]
    float jump = 10f;
    private Rigidbody2D rb;
    private Animator anime;
    private SpriteRenderer image;
    private string walk = "walk";
    private float hid;

    void Start()

    {
        
    }
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        anime = GetComponent<Animator>();
        image = GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        playermoment();
        animetionn();
        jumplayer();
    }
    
    void playermoment()
    {
        hid= Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(hid, 0f, 0f) * Time.deltaTime *momenta;

    }
    void animetionn()
    {
        if (hid > 0) {
            anime.SetBool(walk, true);
            image.flipX = false;
        }
        else if(hid < 0)
        {
            anime.SetBool(walk, true);
            image.flipX = true;
        }
        else
        {
            anime.SetBool(walk, false);
        }
    }
    void jumplayer()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(new Vector2(0f,jump), ForceMode2D.Impulse);
        }
        
    
    }
    /* void Update()
     {
         float h = Input.GetAxis("Horizontal");
         float v = Input.GetAxis("Vertical");

     Vector2 possis = transform.position;// possis take 2 vector components from position in transform  

         possis.x += h * Time.deltaTime * speed;
         possis.y += v*Time.deltaTime * speed; // here the possis is filling the of x and y  

         transform.position = possis;// here the possis is giving the data to position in transform
     }*/
}
