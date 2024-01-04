using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModel
{
    int maxHp;
    int hp;
    int at;
    int currentStage;

    public int MaxHP
    {
        get { return maxHp; }
    }
    public int HP
    {
        get { return hp; }
    }
    public int AT
    {
        get { return at; }
    }
    public int CurrentStage
    {
        get { return currentStage; }
    }
    public PlayerModel()
    {
        maxHp = 100;
        hp = maxHp;
        at = 5;
        currentStage = 0;
    }

    public void NextStage()
    {
        currentStage++;
    }
    public void BackToTown()
    {
        currentStage = 0;
    }
}


