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
        Rennkei();
    }


    private void Rennkei()
    {
        if(DataManager.instance != null)
        {
            DataManager.instance.ChangedScore += OnScoreChanged;
            DataManager.instance.ChangedCoin += OnCoinChanged;
            DataManager.instance.ChangedMario += OnMarioChanged;
            UpdateTexts();

        }
        else
        {
            Invoke("Rennkei", 1);
        }


    }

    private void OnDestroy()
    {
        // �C�x���g�̍w�ǉ���
        DataManager.instance.ChangedScore -= OnScoreChanged;
        DataManager.instance.ChangedCoin -= OnCoinChanged;
        DataManager.instance.ChangedMario -= OnMarioChanged;
    }

    // �X�R�A�ύX���̃C�x���g�n���h��
    private void OnScoreChanged(int score)
    {
        _TMPScore.text = score.ToString();
    }

    // �R�C���ύX���̃C�x���g�n���h��
    private void OnCoinChanged(int coin)
    {
        _TMPCoin.text = coin.ToString();
    }

    // �}���I�ύX���̃C�x���g�n���h��
    private void OnMarioChanged(int mario)
    {
        _TMPMario.text = mario.ToString();
    }

    // �e�L�X�g���X�V����
    private void UpdateTexts()
    {
        _TMPScore.text = DataManager.instance.GetScore().ToString();
        _TMPCoin.text = DataManager.instance.GetCoin().ToString();
        _TMPMario.text = DataManager.instance.GetMario().ToString();
    }
}
