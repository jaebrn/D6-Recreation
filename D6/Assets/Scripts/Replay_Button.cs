using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Replay_Button : MonoBehaviour
{
    public Button replayButton;
    // Start is called before the first frame update
    void Start()
    {
        Button replay = replayButton.GetComponent<Button>();
        replay.onClick.AddListener(StartScene);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
