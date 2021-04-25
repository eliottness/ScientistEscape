using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioMixer audioMixer;
    public new string name;

    public void SetVolume(float volume)
    {
        audioMixer.SetFloat(name, volume);
    }
}
