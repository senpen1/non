using UnityEngine;
using UnityEngine.UI;

public class PlayerStatusView : MonoBehaviour
{
    [SerializeField] Text hpText;
    [SerializeField] Text atText;

    public void UpdateText(PlayerModel playerModel)
    {
        hpText.text = string.Format("HP：{0}/{1}", playerModel.HP, playerModel.MaxHP);
        atText.text = string.Format("AT：{0}", playerModel.AT);
    }
}

