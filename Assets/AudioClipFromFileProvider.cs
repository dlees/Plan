using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioClipFromFileProvider : MonoBehaviour {

    public StringReference url;
    public AudioSource source;

    public void loadNewSong() {
        source.Stop();

        WWW www = new WWW("file://" + url.Value.Replace("\\", "/"));

        while (!www.isDone) { }

        #if UNITY_ANDROID
            source.clip = www.GetAudioClip();
        #else
            if (url.Value.Contains(".mp3")) {
                source.clip = NAudioPlayer.FromMp3Data(www.bytes);
            } else {
                source.clip = www.GetAudioClip();
            }
    #endif

        source.Play();
    }

    void Update() {
    }
}