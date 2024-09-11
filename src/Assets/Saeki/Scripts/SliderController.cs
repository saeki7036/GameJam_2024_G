using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderController : MonoBehaviour
{
    [SerializeField]
    Slider slider;
    [SerializeField]
    PlayerParameter parameter;
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = parameter.GetHitPoint();
    }
}