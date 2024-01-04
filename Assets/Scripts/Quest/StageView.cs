using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageView : MonoBehaviour
{
    public  class StageView : MonoBehaviour
    {
        [SerializeField] GameObject monsterViewPrefab;
        
        public void SpawnMonster()
        {
            GameObject monster = Instantiate(monsterViewPrefab);
            monster.transform.SetParent(transform,false);
        }
            
        
    }
}

//解説
//Instantiate：Prefabをオブジェクトとして生成するための関数
//SetParent：オブジェクトの親要素を設定するための関数（今回はStageViewを親としたいので自分自身のtransformを設定した）
