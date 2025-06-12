using UnityEngine;

public class ParticleRules : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        var rb = gameObject.AddComponent<Rigidbody2D>();
        var cd = gameObject.AddComponent<CircleCollider2D>();
        rb.gravityScale = 0f;
        rb.collisionDetectionMode = CollisionDetectionMode2D.Continuous;
        rb.linearDamping = 0f;
        rb.angularDamping = 0f;
        rb.constraints = RigidbodyConstraints2D.FreezeRotation;

        float xVel = Random.Range(-10f, 10f);
        float yVel = Random.Range(-10, 10);
        rb.linearVelocity = new Vector2(xVel, yVel);
        
        cd.sharedMaterial = Resources.Load<PhysicsMaterial2D>("BouncyMat");
 
    }
}
