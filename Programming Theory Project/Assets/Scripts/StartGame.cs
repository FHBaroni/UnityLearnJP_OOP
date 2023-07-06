using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public TMP_InputField ambientNameInput;
    public string ambientName;
    public static StartGame Instance;
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    public void LoadGameScene()
    {       
            ambientName = ambientNameInput.text;
            SceneManager.LoadScene(1);
    }
}


