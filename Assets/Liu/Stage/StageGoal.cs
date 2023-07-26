using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageGoal : MonoBehaviour
{
    
    Rigidbody2D _rb2D;
    [SerializeField]int sceneNum = 0;
    // Start is called before the  first frame update
    void Start()
    {
        _rb2D = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<PlayerController>(out PlayerController pc))
        {
            Debug.Log("goal");
            SceneManager.LoadScene(sceneNum);
        }
    }
}
