using UnityEngine;

public class WallController : MonoBehaviour
{
    [SerializeField] private int healthNow = 0;
    [SerializeField] private int healthMax = 10;
    [SerializeField] private ExplosionController explosion = null;

    public int HealthMax => healthMax;
    public int Health => healthNow;

    private void Awake()
    {
        healthNow = healthMax;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Bullet"))
        {
            healthNow--;
            healthNow = Mathf.Clamp(healthNow, 0, healthMax);
        }

        if (healthNow == 0)
        {
            if (explosion != null) explosion.Explode(explosion.NumOfParticles);
            gameObject.SetActive(false);
            
        }
        
        
        
        // switch (collision.gameObject.tag)
        // {
        //     case "Bullet":
        //         healthNow--;
        //         break;
        //     case "Ball":
        //         break;
        //     default:
        //         break;
        // }
    }
}
