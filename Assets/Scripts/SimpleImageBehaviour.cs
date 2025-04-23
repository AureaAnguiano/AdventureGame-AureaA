using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Image))]

public class SimpleImageBehaviour : MonoBehaviour
{
    private Image imageObj;
    public SimpleFloatData dataObj;

    private void Start()
    {
        imageObj = GetComponent<Image>();
    }
    
    public void UpdateWithFloatData()
    {
        imageObj.fillAmount = dataObj.value;
        
        if (dataObj.value <= 0)
        {
            SceneManager.LoadScene(2);
        }
    }
}
