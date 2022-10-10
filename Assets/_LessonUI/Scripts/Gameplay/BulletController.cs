using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float speed = 3f;
    public float lifespan = 10f;
    private float timer;

    public void SetDirection(Vector3 direction)
    {
        transform.forward = direction.normalized;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        timer = lifespan;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Destroy(gameObject);
        }

        var velocity = speed * Time.deltaTime * transform.forward;
        transform.Translate(velocity, Space.World);
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
