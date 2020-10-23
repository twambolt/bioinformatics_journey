using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaylistScript : MonoBehaviour
{
    public AudioClip[] audioClips;
    public AudioSource source;

    public float timer;
    public float newClip;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;


        if (timer < newClip + 1)
        {
            GetNewClip();
            timer = 0;
        }
    }

    void GetNewClip()
    {
        int clipNum = Random.Range(0, audioClips.Length);

        if (!source.isPlaying)
        {
            source.loop = true;
            source.PlayOneShot(audioClips[clipNum]);
        }

        newClip = audioClips[clipNum].length;
    }


}
