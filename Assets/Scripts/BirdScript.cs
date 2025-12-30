using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength = 10;
    public LogicScript logic;
    public bool birdIsAlive = true;

    public AudioSource wingFlapSFX;

    public Animator animator;          // NEW
    public SpriteRenderer spriteRenderer;  // NEW
    public Sprite deadSprite;          // NEW – assign default frame

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();

        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && birdIsAlive)
        {
            myRigidbody.linearVelocity = Vector2.up * flapStrength;
            wingFlapSFX.Play();
        }

        Vector3 viewPos = Camera.main.WorldToViewportPoint(transform.position);
        if (birdIsAlive && (viewPos.y > 1.1f || viewPos.y < -0.1f))
        {
            Die();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Die();
    }

    void Die()
    {
        if (!birdIsAlive) return;

        birdIsAlive = false;
        logic.gameOver();              // Call logic code

        animator.enabled = false;      // Stop wing animation
        spriteRenderer.sprite = deadSprite; // Freeze on default frame
    }
}
