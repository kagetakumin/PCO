using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnController : MonoBehaviour
{
    /// <summary> プレイヤータイプ </summary>
    public enum PlayerType
    {
        Player,
        Opponent,
    }

    /// <summary> ターン保持者 </summary>
    private PlayerType turnHolder;
    public PlayerType TurnHolder
    {
        get { return turnHolder; }
        private set
        {
            if((int) value >= Enum.GetNames(typeof(PlayerType)).Length)
            {
                turnHolder = value - Enum.GetNames(typeof(PlayerType)).Length;
            }
            else turnHolder = value;
        }
    }

    /// <summary> フェーズ </summary>
    private BattlePhase phase = BattlePhase.Draw;
    public BattlePhase Phase
    {
        get { return phase; }
        private set
        {
            if((int) value >= Enum.GetNames(typeof(BattlePhase)).Length)
            {
                phase = value - Enum.GetNames(typeof(BattlePhase)).Length;
            }
            else phase = value;
        }
    }

    /// <summary> ターン数 </summary>
    private int[] turnCount = new int[Enum.GetNames(typeof(PlayerType)).Length];
    public int TurnCount { get { return turnCount[(int) turnHolder]; } }

    /// <summary> フェーズ遷移 </summary>
    public void ToNextPhase()
    {
        this.Phase += 1;
        if(this.Phase == BattlePhase.None)
        {
            TurnHolder += 1;
        }
    }

    /// <summary> ターン数取得 </summary>
    public int GetTurnCount(PlayerType type) { return turnCount[(int) type]; }
}
