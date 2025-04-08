using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.UI;

public class VolumeControl : MonoBehaviour
{
    public AudioSource musicSource;
    public Slider volumeSlider;
    // Start is called before the first frame update
    private void Start()
    {
        volumeSlider.value = musicSource.volume;
        volumeSlider.onValueChanged.AddListener(AdjustVolume);
    }

    // Update is called once per frame
    public void AdjustVolume(float newVolume)
    {
        musicSource.volume = newVolume;
    }
}
