using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public GameObject base_;
    private Slider healthSlider;
    private Base baseHealth;
    // Start is called before the first frame update
    void Start()
    {
        baseHealth = base_.GetComponent<Base>();
        healthSlider = GetComponent<Slider>();
        healthSlider.minValue = 0;
        healthSlider.maxValue = baseHealth.Hp;
        healthSlider.value = healthSlider.maxValue;
    }

    // Update is called once per frame
    void Update()
    {
        healthSlider.value = baseHealth.Hp;
    }
}
