using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarBehaviour : MonoBehaviour
{
    //Variable to hold our players health
    [SerializeField]
    private HealthBehaviour _health;

    //Variable to hold our health gradient
    [SerializeField]
    private Gradient _healthGradient;

    //Variable to hold our fill image
    [SerializeField]
    private Image _fill;

    //Variable to hold the slider for our health and fill
    private Slider _slider;

    void Start()
    {
        //setting the variables equal to the components they are
        _slider = GetComponent<Slider>();
        _slider.maxValue = _health.Health;
        _fill.color = _healthGradient.Evaluate(1f);
    }

    void Update()
    {
        //setting the slider equal to health so that it changes when health changes
        _slider.value = _health.Health;
        //setting the fill equal to healthgradient so that the health visibly changes in game as it gets lower
        _fill.color = _healthGradient.Evaluate(_slider.value / _slider.maxValue);
    }
}
