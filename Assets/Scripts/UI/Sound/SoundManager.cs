using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioMixer audioMixer;
    public string name;

    public void SetVolume(float volume)
    {
        audioMixer.SetFloat(name, volume);
    }
}
