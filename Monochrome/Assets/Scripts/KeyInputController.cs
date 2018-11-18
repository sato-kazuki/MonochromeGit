using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// これ本当にいる？
/// 一応各キー押された時その状態を保持する。ここでやる必要性には疑問
/// </summary>
public class KeyInputController : SingletonMonoBehaviour<KeyInputController> {
    //各桁予備LRABXYキーに対応
    private byte keyFlag = 0;
    //0=x,1=y
    private float[] keyStick = new float[2];

    void InputUpdate()
    {
        if (Input.GetButton("A")) { keyFlag += 8; }
    }
}
