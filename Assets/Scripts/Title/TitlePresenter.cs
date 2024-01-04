using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitlePresenter : MonoBehaviour
/// <summary>
/// タイトル画面のプレゼンター。
/// Start()で初期化を行う。
/// OnNewGameButton()は新規ゲームボタンを押した時に呼ばれ、Townシーンに遷移する。 
/// OnContinueButton()は続きからボタンを押した時に呼ばれ、Townシーンに遷移する。
/// </summary>
{
    void Start()
    {

    }
    public void OnNewGameButton()
    {
        SceneManager.LoadScene("Town");//指定したシーンに移動
    }
    public void OnContinueButton()
    {
        SceneManager.LoadScene("Town");//指定したシーンに移動
    }
}
