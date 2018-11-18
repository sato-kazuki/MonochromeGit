using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : SingletonMonoBehaviour<SoundController> 
{

    /// <summary>
    /// SE名リスト
    /// </summary>
    public enum SENames
    {
    }

    private AudioSource audioSource;

    [SerializeField]
    private AudioClip[] SEList;

    private void start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    /// <summary>
    /// 名前で指定してSEを再生する
    /// </summary>
    /// <param name="name">SE名</param>
    public void SEPlay(SENames _name, bool _isPlayCheck = false)
    {
        if (_isPlayCheck && audioSource.isPlaying) return;
        audioSource.PlayOneShot(SEList[(int)_name]);
    }
}
