using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeScene : MonoBehaviour
{

    [SerializeField]
    private Button playButton, quitButton;

    // Start is called before the first frame update
    void Start()
    {
        playButton.onClick.AddListener(LoadLevel);
        quitButton.onClick.AddListener(exitGame);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadLevel()
    {
        SceneManager.LoadScene("BasementMain");
    }

    public void exitGame()
    {
        Application.Quit();
    }

}
