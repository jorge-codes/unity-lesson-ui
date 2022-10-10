using UnityEngine;
using UnityEngine.UI;

public class HealthBarImpComponent : MonoBehaviour
{
    [SerializeField] private Image imageForeground = null;
    [Space(20)]
    [SerializeField] private Color colorFull = Color.green;
    [SerializeField] private Color colorHalf = Color.yellow;
    [SerializeField] private Color colorWarn = Color.red;
    [SerializeField] private float valueHalf = 0.51f;
    [SerializeField] private float valueWarn = 0.21f;
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
        imageForeground.color = GetColor(imageForeground.fillAmount);
    }

    private Color GetColor(float fillAmount)
    {
        if (fillAmount < valueWarn) return colorWarn;
        if (fillAmount < valueHalf) return colorHalf;
        
        return colorFull;
    }
}

