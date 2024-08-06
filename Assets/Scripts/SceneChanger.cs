using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    [SerializeField] GameObject TutorialsPanel;
    [SerializeField] GameObject AccountPanel;
    [SerializeField] GameObject SettingsPanel;
    [SerializeField] GameObject LoginPanel;
    [SerializeField] GameObject ProfilePanel;

    public void MainPage()
    {
        TutorialsPanel.SetActive(false);
        AccountPanel.SetActive(false);
        SettingsPanel.SetActive(false);
    }

    public void Play()
    {
        SceneManager.LoadScene(1);
    }

    public void Help()
    {
        TutorialsPanel.SetActive(true);
    }

    public void Settings()
    {
        SettingsPanel.SetActive(true);
    }

    public void MyAccount()
    {
        AccountPanel.SetActive(true);
    }
}
