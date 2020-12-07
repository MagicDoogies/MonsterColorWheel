using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

[System.Serializable]
public class Sound 
{
    public string name;//Space to assign name to audio clip.

    public AudioClip clip; //Where I place my audioclips.

    [Range(0f, 1f)]
    public float volume;//Controls the volume of the audio
    [Range(.1f, 3f)]
    public float pitch;//Controls the audio pitch.

    [HideInInspector]
    public AudioSource source;

    public bool loop;
}
