using UnityEngine;

public class LifespanController : MonoBehaviour
{
    public float lifespan = 3f;
    private float timer;
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
    }
}
