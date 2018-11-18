using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : SingletonMonoBehaviour<MusicController>
{


    /// <summary>
    /// BGM名リスト
    /// </summary>
    public enum BGMNames
    {
    }

    [SerializeField]
    private AudioClip[] BGMList;

    private AudioSource musicPlayer;

    private void start()
    {
        musicPlayer = this.GetComponent<AudioSource>(); 
        
    }

    /// <summary>
    /// 名前で指定してBGMを再生する
    /// </summary>
    /// <param name="name">BGM名</param>
    public void BGMPlay(BGMNames name)
    {
        if (musicPlayer.isPlaying) { musicPlayer.Stop(); }
        musicPlayer.clip =BGMList[(int)name];
        musicPlayer.loop = true;
        musicPlayer.Play();
    }
}
