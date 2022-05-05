using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SliderValue : MonoBehaviour
{

    // Slider
    public Slider _Slider;

    // Text
    public TextMeshProUGUI _SliderValue;

    // Start is called before the first frame update
    void Start()
    {
        // Set the slider's value to the text
        _Slider.value = float.Parse(_SliderValue.text);
    }

    // Update is called once per frame
    void Update()
    {
        // Set the text to the slider's value
        _SliderValue.text = _Slider.value.ToString();
    }

}
