using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    private Animator playerAnim;
    public ParticleSystem explosionParticle;
    public ParticleSystem trailParticle;
    public AudioClip jumpSound;
    public AudioClip crashSound;
    private AudioSource playerAudio;
    public float jumpForce = 10;
    public float gravityModifier = 1;
    public bool isOnGround = true;
    public bool gameOver;
    private static readonly int JumpTrig = Animator.StringToHash("Jump_trig");
    private static readonly int DeathB = Animator.StringToHash("Death_b");
    private static readonly int DeathTypeINT = Animator.StringToHash("DeathType_int");

    private void Start()
    {
        playerAudio = GetComponent<AudioSource>();
        playerRb = GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();
        Physics.gravity *= gravityModifier;
    }

    private void Update()
    {
        if (gameOver || !Input.GetKeyDown(KeyCode.Space) || !isOnGround) return;

        playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        playerAnim.SetTrigger(JumpTrig);
        isOnGround = false;
        trailParticle.Stop();
        playerAudio.PlayOneShot(jumpSound);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (gameOver) return;
        
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
            trailParticle.Play();
        }
        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            gameOver = true;
            Debug.Log("Game Over!");
            trailParticle.Stop();
            playerAnim.SetInteger(DeathTypeINT, 1);
            playerAnim.SetBool(DeathB, true);
            explosionParticle.Play();
            playerAudio.PlayOneShot(crashSound);
        }
    }
}