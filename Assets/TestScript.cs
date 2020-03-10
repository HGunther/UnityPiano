using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NAudio;
using NAudio.Wave;

public class TestScript : MonoBehaviour
{
    NAudio.Wave.WaveOutEvent waveOutEvent;
    NAudio.Wave.ISampleProvider sound;


    // Start is called before the first frame update
    void Start()
    {
        waveOutEvent = new NAudio.Wave.WaveOutEvent();
        sound = new NAudio.Wave.SampleProviders.SignalGenerator()
        {
            Gain = 0.2,
            Frequency = 500,
            Type = NAudio.Wave.SampleProviders.SignalGeneratorType.Sin
        }
        .Take(System.TimeSpan.FromSeconds(20));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlaySound()
    {
            waveOutEvent.Init(sound);
            waveOutEvent.Play();
        
    }

    public void StopSound()
    {
        waveOutEvent.Stop();
    }
}

