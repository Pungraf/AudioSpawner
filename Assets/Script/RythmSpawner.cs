using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class RythmSpawner : MonoBehaviour
{
    public GameObject objectPrefab;
    public float spawnThreshold = 0.0005f;
    public int frequency = 0;
    public FFTWindow fftWindow;
    
    private float[] samples = new float[1024];
    
    void Update ()
    {
        AudioListener.GetSpectrumData(samples,0,fftWindow);


        if(samples[frequency] > spawnThreshold)
        {
            Instantiate(objectPrefab,transform.position,transform.rotation);
        }
    }
}
