using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// デバッグ用ツール類をここにぶち込む。UI使うがUI生成周りは面倒なのでPrefabで済ます
/// </summary>
public class DebugTools : MonoBehaviour {
    int frameCount;
    float prevTime;
    
    GameObject text;

    void Start()
    {
        //変数初期化
        frameCount = 0;
        prevTime = 0.0f;

        //表示用UIの取得
        

    }

    void Update()
    {
        ++frameCount;
        float time = Time.realtimeSinceStartup - prevTime;

        if (time >= 0.5f)
        {
            Debug.LogFormat("{0}fps", frameCount / time);

            frameCount = 0;
            prevTime = Time.realtimeSinceStartup;
        }
    }
}
