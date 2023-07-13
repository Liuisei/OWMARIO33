using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static DataManager instance = null;

    [SerializeField] int _coin = 111; // �R�C���̐�
    [SerializeField] int _mario = 10; // �}���I�̐�
    [SerializeField] int _score = 10; // �X�R�A

    public event Action<int> ChangedScore; // �X�R�A�ύX���̃C�x���g
    public event Action<int> ChangedCoin; // �R�C���ύX���̃C�x���g
    public event Action<int> ChangedMario; // �}���I�ύX���̃C�x���g

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

    /// <summary>          �X�R�A�̒l��+-                    </summary>///

    public void ChangeCoin(int value)    // �R�C���̕ύX

    {
        _coin += value;
        ChangedCoin?.Invoke(_coin); // �R�C���ύX�C�x���g�𔭉�
    }
    public void ChangeMario(int value)    // �}���I�̕ύX

    {
        _mario += value;
        ChangedMario?.Invoke(_mario); // �}���I�ύX�C�x���g�𔭉�
    }
    public void ChangeScore(int value)
    {
        _score += value;
        ChangedScore?.Invoke(_score); // �X�R�A�ύX�C�x���g�𔭉�
    }


    /// <summary>         �l���Q�b�g            </summary>///

    // ���݂̃R�C�������擾
    public int GetCoin()
    {
        return _coin;
    }

    // ���݂̃}���I�����擾
    public int GetMario()
    {
        return _mario;
    }

    // ���݂̃X�R�A���擾
    public int GetScore()
    {
        return _score;
    }


}
