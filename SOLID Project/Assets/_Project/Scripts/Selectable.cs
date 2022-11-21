using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Selectable : MonoBehaviour
{
    //[SerializeField] private TextMeshProUGUI lookPercentageLabel;
    [HideInInspector] public float lookPercentage;

    private void Update()
    {
        //lookPercentageLabel.text = lookPercentage.ToString();
    }
}
