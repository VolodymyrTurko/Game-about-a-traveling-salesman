using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioClick : MonoBehaviour
{
    public AudioSource touchSource1;
    public AudioClip touchClip1;

    public void ClickSound()
    {
        touchSource1.PlayOneShot(touchClip1);
    }
}
