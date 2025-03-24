using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PlayerController : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    private float moveInput;
    private Rigidbody2D rb;
    private bool facingRight = true;
    private bool isGrounded;
    public Transform feetPos;
    public float checkRadius;
    public LayerMask whatIsGround;
    private Animator anim;
    public GameObject died;
    public GameObject finish;
    public Joystick joystick;
    public Text text;
    public GameObject Jump;
    private void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();

    }
     void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag=="Respawn" || other.tag=="Vrag")
        {
            speed = 0;
            jumpForce = 0;
            Coins.coins = 0;
            Coins.diedint += 1;
            died.SetActive(true);
        }
        if(other.tag=="Finish")
        {
            speed = 0;
            jumpForce = 0;
            float c = Coins.coins;          
            string text1= "Ïîçäðàâëÿþ, âû çàâåðøèëè èãðó è ñîáðàëè " + System.Environment.NewLine + Mathf.Round(c / 38 * 100).ToString() + "% ìîíåò" + System.Environment.NewLine + "Óìåðëè " + Coins.diedint.ToString();
            text.text = text1;
            Coins.diedint = 0;
            Jump.SetActive(false);
            finish.SetActive(true);
            
        }
    }
    private void FixedUpdate()
    {
        moveInput = joystick.Horizontal;
        //moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
        if (facingRight==false && moveInput>0)
        {
            Flip();
        }
        else if (facingRight == true && moveInput < 0)
        {
            Flip();
        }
        if(moveInput==0)
        {
            anim.SetBool("isRun", false);
        }
        else
        {
            anim.SetBool("isRun", true);
        }
    }
    public void onJumpButton()
    {
        if ((isGrounded == true))
        {
            rb.velocity = Vector2.up * jumpForce;
            anim.SetTrigger("TakeOf");
        }
    }
    private void Update()
    {

        //float verticalMove = joystick.Vertical;
        //Input.GetKeyDown(KeyCode.Space);

        isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, whatIsGround);      
        if (isGrounded==true)
        {
            anim.SetBool("isJump", false);
        }
        else
        {
            anim.SetBool("isJump", true);
        }
        if(transform.position.y<-5.25)
        {
            speed = 0;
            jumpForce = 0;
            Coins.coins = 0;
            died.SetActive(true);
        }
    }
    void Flip()
    {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;      
    }

}
