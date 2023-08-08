using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour
{
    [SerializeField] private GameObject controlsPanel;
    [SerializeField] private GameObject storyPanel;

    private bool controlsPanelActive;
    private bool storyPanelActive;
    void Start()
    {
        controlsPanel.SetActive(false);
        controlsPanelActive = false;

        storyPanel.SetActive(false);
        storyPanelActive = false;
    }

    public void StartButton()
    {
        SceneManager.LoadScene(1);
    }

    public void ControlsButton()
    {
        if (!storyPanelActive)
        {
            controlsPanel.SetActive(true);
            controlsPanelActive = true;
        }
    }

    public void ControlsBackButton()
    {
        controlsPanel.SetActive(false);
        controlsPanelActive = false;
    }

    public void StoryButton()
    {
        if (!controlsPanelActive)
        {
            storyPanel.SetActive(true);
            storyPanelActive = true;
        }
    }

    public void StoryBackButton()
    {
        storyPanel.SetActive(false);
        storyPanelActive = false;
    }
}
