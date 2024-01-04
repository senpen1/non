// QuestPresenterはクエストシーンのプレゼンテーションロジックを担当するクラスです。
// MonoBehaviourを継承してUnityのライフサイクルと連動させています。
// 
// Start()でPlayerModelとStageTableModelを初期化し、
// 現在のステージ数を表示したり、プレイヤーのステータスを更新します。
// 
// OnNextButton()で次のステージに進み、
// クリアか敵の出現をチェックします。 
// 
// OnBackButton()で前のシーンに戻ります。
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuestPresenter : MonoBehaviour
{
    [SerializeField] Text StageText;
    [SerializeField] PlayerStatusView playerStatusView;

    PlayerModel playerModel;
    StageTableModel stageTableModel;
    void Start()
    {
        playerModel = new PlayerModel();
        stageTableModel = new StageTableModel();

        StageText.text = string.Format("STAGE:{0}", playerModel.CurrentStage);
        playerStatusView.UpdateText(playerModel);
    }

    void SetupMonster()
    {
        // StageTableModelからMonsterModelを生成
        MonsterModel monsterModel = stageTableModel.GetMonster(playerModel.CurrentStage);

        // MonsterModelを描画
    }

    public void OnNextButton()
    {
        playerModel.NextStage();
        StageText.text = string.Format("STAGE:{0}", playerModel.CurrentStage);
        // 以下を追加
        if (stageTableModel.HasGameCleared(playerModel.CurrentStage))
        {
            Debug.Log("クリア");
        }
        else if (stageTableModel.IsEnemyPointAt(playerModel.CurrentStage))
        {
            Debug.Log("敵の出現");
            SetupMonster();
        }
    }

    public void OnBackButton()
    {
        playerModel.BackToTown();
        SceneManager.LoadScene("Town");
    }
}










// QuestPresenterクラスはQuestシーンのプレゼンテーションロジックを担当します。
// MonoBehaviourを継承してUnityのライフサイクルと連動させています。
// 
// StageTextに現在のステージ数を表示します。
// OnNextButtonで次のステージに進みます。
// OnBackButtonで前のシーンに戻ります。
