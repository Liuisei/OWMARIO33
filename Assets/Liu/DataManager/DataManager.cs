using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static DataManager instance = null;

    [SerializeField] int _coin = 111; // コインの数
    [SerializeField] int _mario = 10; // マリオの数
    [SerializeField] int _score = 10; // スコア

    public event Action<int> ChangedScore; // スコア変更時のイベント
    public event Action<int> ChangedCoin; // コイン変更時のイベント
    public event Action<int> ChangedMario; // マリオ変更時のイベント

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    /// <summary>          スコアの値の+-                    </summary>///

    public void ChangeCoin(int value)    // コインの変更

    {
        _coin += value;
        ChangedCoin?.Invoke(_coin); // コイン変更イベントを発火
    }
    public void ChangeMario(int value)    // マリオの変更

    {
        _mario += value;
        ChangedMario?.Invoke(_mario); // マリオ変更イベントを発火
    }
    public void ChangeScore(int value)
    {
        _score += value;
        ChangedScore?.Invoke(_score); // スコア変更イベントを発火
    }


    /// <summary>         値をゲット            </summary>///

    // 現在のコイン数を取得
    public int GetCoin()
    {
        return _coin;
    }

    // 現在のマリオ数を取得
    public int GetMario()
    {
        return _mario;
    }

    // 現在のスコアを取得
    public int GetScore()
    {
        return _score;
    }


}
