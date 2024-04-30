using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthBar : MonoBehaviour
{
    private EnemyMove self;
    private Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        self = transform.parent.gameObject.transform.parent.gameObject.GetComponent<EnemyMove>();
        slider = GetComponent<Slider>();
        slider.maxValue = self.hp;
        slider.value = self.hp;
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = self.hp;
    }
}
