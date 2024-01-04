using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Town : MonoBehaviour
{
    void Start() 
    {
        
    }
    public void OnTitleButton()
    {
        SceneManager.LoadScene("Title");
    }

    public void OnQuestButton()
    {
        SceneManager.LoadScene("Quest");
    }
}
    //このコードは、TitleとQuestの2つのシーン間を移動するためのメソッドを提供しています。
    
    //OnTitleButton() メソッドはTitleシーンに移動します。
    
    //OnQuestButton() メソッドはQuestシーンに移動します。
    
    //シーンの移動にはSceneManager.LoadScene() を使用しています。

