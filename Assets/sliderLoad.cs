using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class sliderLoad : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI textvalue;
    public Button increase;
    public Button decrease;
    public void Startloding(float value)
    {
        textvalue.text=value.ToString();
       
    }
    public void OnBecameInvisible()
    {
        
    }
}
