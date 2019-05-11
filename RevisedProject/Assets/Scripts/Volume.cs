using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
          
public class Volume : MonoBehaviour

{

    public AudioMixer audiomixer;

    public void SetVolume(float volume)
    {

       audiomixer.SetFloat("volume", volume);

    }
}