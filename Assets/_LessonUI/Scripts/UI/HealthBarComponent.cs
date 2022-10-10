using UnityEngine;
using UnityEngine.UI;

public class HealthBarComponent : MonoBehaviour
{
    [SerializeField] private Image imageForeground = null;
    private int barMin;
    private int barMax;
    private int barNow;
    
    public void SetValues(int max, int min = 0)
    {
        barMax = max;
        barMin = min;
    }

    public void Set(int v)
    {
        barNow = v;
    }

    private void Awake()
    {
        barMin = 0;
        barMax = 1;
        barNow = barMax;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        imageForeground.fillAmount = barNow / (float)barMax;
    }
}
