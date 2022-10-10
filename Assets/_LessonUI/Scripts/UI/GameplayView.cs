using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameplayView : MonoBehaviour
{
    [Header("Objects")]
    [SerializeField] private WallController wall = null;

    [Header("UI Elements")]
    [SerializeField] private TextMeshProUGUI labelWallHealth = null;
    [SerializeField] private HealthBarComponent healthBar01 = null;
    [SerializeField] private HealthBarComponent healthBar02 = null;
    [SerializeField] private HealthBarImpComponent healthBar03 = null;
    
    // Start is called before the first frame update
    void Start()
    {
        UpdateLabelWallHealth(wall.Health, wall.HealthMax);
        healthBar01.SetValues(wall.HealthMax, wall.Health);
        healthBar02.SetValues(wall.HealthMax, wall.Health);
        healthBar03.SetValues(wall.HealthMax, wall.Health);
    }

    // Update is called once per frame
    void Update()
    {
        UpdateLabelWallHealth(wall.Health, wall.HealthMax);
        healthBar01.Set(wall.Health);
        healthBar02.Set(wall.Health);
        healthBar03.Set(wall.Health);
    }

    private void UpdateLabelWallHealth(int healthNow, int healthMax)
    {
        labelWallHealth.text = $"{healthNow}/{healthMax}";
    }
}
