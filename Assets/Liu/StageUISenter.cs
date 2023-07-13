using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StageUISenter : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _TMPScore;
    [SerializeField] TextMeshProUGUI _TMPCoin;
    [SerializeField] TextMeshProUGUI _TMPMario;

    private void Start()
    {

        // DataManagerのイベントとテキストの更新を連携する
        DataManager.instance.ChangedScore += OnScoreChanged;
        DataManager.instance.ChangedCoin += OnCoinChanged;
        DataManager.instance.ChangedMario += OnMarioChanged;
        // 初期状態でテキストを更新
        UpdateTexts();
    }


    private void Rennkei()
    {

    }

    private void OnDestroy()
    {
        // イベントの購読解除
        DataManager.instance.ChangedScore -= OnScoreChanged;
        DataManager.instance.ChangedCoin -= OnCoinChanged;
        DataManager.instance.ChangedMario -= OnMarioChanged;
    }

    // スコア変更時のイベントハンドラ
    private void OnScoreChanged(int score)
    {
        _TMPScore.text = score.ToString();
    }

    // コイン変更時のイベントハンドラ
    private void OnCoinChanged(int coin)
    {
        _TMPCoin.text = coin.ToString();
    }

    // マリオ変更時のイベントハンドラ
    private void OnMarioChanged(int mario)
    {
        _TMPMario.text = mario.ToString();
    }

    // テキストを更新する
    private void UpdateTexts()
    {
        _TMPScore.text = DataManager.instance.GetScore().ToString();
        _TMPCoin.text = DataManager.instance.GetCoin().ToString();
        _TMPMario.text = DataManager.instance.GetMario().ToString();
    }
}
