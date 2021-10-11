using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioSystem : MonoBehaviour
{
    AudioSource ASource = null;

    public float timer = 0f;
    public float timermx = .5f;
    public AudioClip[] aClips = null; // array for the clips
    // Start is called before the first frame update
    void Start()
    {
        ASource = GetComponent<AudioSource>();
        timer = timermx;
    }

    // Update is called once per frame
    void Update()
    {
        int aIndex = Random.Range(0, aClips.Length);// random.range excludes the max value
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            timer += timermx;
            ASource.clip = aClips[aIndex];
            ASource.Play();
            /* PlayAudio(aClips[aIndex]);*/
        }
    }
    void PlayAudio(AudioClip clip)
    {
        ASource.PlayOneShot(clip);
    }
}
