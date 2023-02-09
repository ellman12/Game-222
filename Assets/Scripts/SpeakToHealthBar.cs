using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeakToHealthBar : MonoBehaviour
{
    [SerializeField] [Range(0, 1)] private float slider;

    // public static Action<float> UpdateHealthBar = delegate { };
    //
    // private void Update()
    // {
    //     UpdateHealthBar(slider);
    // }
}