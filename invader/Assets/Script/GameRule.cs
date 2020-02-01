using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameRule : MonoBehaviour
{
    public GameObject GameOverMessageObj;
    public GameObject CongraMessageObj;
    private bool isGameOver;
    private bool isCongraturation;

    // Start is called before the first frame update
    void Start()
    {
        isGameOver = false;
        isCongraturation = true;
        GameOverMessageObj.SetActive(false);
        CongraMessageObj.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.Find("Player") == null) {
            isGameOver = true;
            GameOverMessageObj.SetActive(true);
        }

        if(GameObject.FindGameObjectWithTag("Enemy") == null) {
            isGameOver = true;
            isCongraturation = true;
            CongraMessageObj.SetActive(true);
        }

        if(isGameOver) {
            if (Input.GetKey (KeyCode.Space)) {
                SceneManager.LoadScene ("Title");
            }
        }
    }
}
