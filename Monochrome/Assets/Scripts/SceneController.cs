using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// シーン遷移管理クラス
/// </summary>
public class SceneController : MonoBehaviour {

    public enum transScenes
    {
        title,
        main
    }

    public void SceneChange(transScenes name)
    {
        SceneManager.LoadScene(name.ToString());
    }
}
