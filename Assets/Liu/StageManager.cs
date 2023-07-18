using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageManager : MonoBehaviour
{
    public static StageManager instance;
    [SerializeField] int _time = 300;
    [SerializeField] float _timef;
    [SerializeField] int _stageScore;
    [SerializeField] bool _timeStop = false;

    public event Action<int> ChangedTime;

    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        _timef = _time;
    }
    private void Update()
    {
        ChangeTime();


    }


    /// <summary>      Change         </summary>///
    public void ChangeTime()
    {
        if (!_timeStop)
        {
            _timef -= Time.deltaTime;

            _time = (int)_timef;

            ChangedTime?.Invoke(_time);
            if (_time <= 0)
            {
                SetTimeStop();
                Debug.Log("DIE");
            }
        }

    }


    // �^�C�����擾����
    public float GetTime()
    {
        return _time;
    }


    // �^�C�����~����t���O��ݒ肷��
    public void SetTimeStop()
    {
        _timeStop = true;
    }
}
