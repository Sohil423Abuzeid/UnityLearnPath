using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    private bool onGround = true;
    public bool gameOver= false;
    private Animator animator;
    public ParticleSystem runParticle;
    public ParticleSystem hitParticle;
    public AudioClip hitSound;
    public AudioClip jumpSound;
    private AudioSource playerAudio;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();
        Physics.gravity *= 1.5f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)&&onGround&&!gameOver)
        {
            playerRb.AddForce(Vector3.up * 700,ForceMode.Impulse);
            animator.SetTrigger("Jump_trig");
            onGround = false;
            runParticle.Stop();
            playerAudio.PlayOneShot(jumpSound);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(TagsEnums.Ground.ToString()))
        {
            onGround = true;
            runParticle.Play();
        }
        else if (collision.gameObject.CompareTag(TagsEnums.Obstacle.ToString()))
        {
            Debug.Log("Game Over");
            gameOver = true;
            hitParticle.Play();
            runParticle.Stop();
            playerAudio.PlayOneShot(hitSound);
            animator.SetBool("Death_b", true);
            animator.SetInteger("DeathType_int",transform.position.y>0.75f?2:1);
        }
    }
}
