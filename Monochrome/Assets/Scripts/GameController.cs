using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// このゲームの根幹のクラス　ごちゃっとしないよう逐次整理が必要とともに、各スクリプトへの参照は保持しておかねば…
/// </summary>
public class GameController : SingletonMonoBehaviour<GameController> {
    [SerializeField]
    private DebugTools debugTools;

    Canvas canvas;

    int flameCount = 0;
    static byte[] receptionBytes;

	//初期化式
	protected override void Awake () {
        //60fps固定
        //Application.targetFrameRate = 60;
        // VSyncをOFFにする
        //QualitySettings.vSyncCount = 0;
        //通信開始→通信先設定後に変更
        //NetworkManager.UDPThreadStart();
	}

    
    private void Update()
    {
        //通信結果受け取り


        //送信

        flameCount++;
        if(flameCount >= 60)
        {
            flameCount = 0;
        }
    }



    /**************************************/
    //デバッグツール生成
    void AddDebugMode()
    {

    }
    
}
