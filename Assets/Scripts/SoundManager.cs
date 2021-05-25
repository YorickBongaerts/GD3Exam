using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    [SerializeField]
    private List<AudioSource> sources;
    [SerializeField]
    private Slider slider;

    internal void PlayButtonTap()
    {
        sources[0].Play();
    }
    internal void PlayShoot()
    {
        sources[1].Play();
    }
    internal void PlayTitlescreenBgm()
    {
        sources[2].Play();
    }
    internal void PlayHeavenBgm()
    {
        sources[3].Play();
    }
    internal void PlayHellBgm()
    {
        sources[4].Play();
    }
    internal void PlayPurgatoryBgm()
    {
        sources[5].Play();
    }
    internal void PlayGameBgm()
    {
        sources[6].Play();
    }
    public void OnSliderChange()
    {
        foreach (AudioSource source in sources)
        {
            source.volume = slider.value;
        }
    }
}
