using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using NAudio.CoreAudioApi;

public class AudioClipFromFileProvider : MonoBehaviour {

    public StringReference url;
    public AudioSource source;

    public void loadNewSong() {
        source.Stop();

        WWW www = new WWW(url.Value.Replace("\\", "/"));


        if (url.Value.Contains(".mp3")) {
            source.clip = NAudioPlayer.FromMp3Data(www.bytes);
        } else {

            source.clip = www.GetAudioClip();
        }
    }

    void Update() {

        if (!source.isPlaying && source.clip.loadState == AudioDataLoadState.Loaded)
            source.Play();

    }
}