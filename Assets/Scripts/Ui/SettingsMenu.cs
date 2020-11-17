using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    public Text fullScreenText;
    public Button fullScreenButton;
    public bool isFullScreen;
    public Text QualityText;
    public Button QualityButton;
    public Dropdown resolutionDropDown;
    Resolution[] resolutions;
    //public Button Apply;
    private void Start()
    {
        resolutions = Screen.resolutions;
        fullScreenButton.onClick.AddListener(FullScreenClick);
        QualityButton.onClick.AddListener(qualityClick);
        resolutions = Screen.resolutions;

        resolutionDropDown.ClearOptions();

        List<string> options = new List<string>();

        int currentResIndex = 0;

        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(option);

            if (resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height) ;
        }

        resolutionDropDown.AddOptions(options);
        resolutionDropDown.value = currentResIndex;
        resolutionDropDown.RefreshShownValue();
}
    private void Update()
    {
        if(QualitySettings.GetQualityLevel() <= 2)
        {
            QualityText.text = "Low";
        }else if(QualitySettings.GetQualityLevel() == 4)
        {
            QualityText.text = "Med";
        }else if(QualitySettings.GetQualityLevel() >= 5)
        {
            QualityText.text = "High";
        }
        if(isFullScreen == true)
        {
            fullScreenText.text = "Windowed";
        }else if(isFullScreen == false)
        {
            fullScreenText.text = "FullScreen";
        }
    }
    void FullScreenClick()
    {
        if(isFullScreen == false)
        {
            Screen.fullScreenMode = FullScreenMode.Windowed;
            isFullScreen = true;
        }else if(isFullScreen == true)
        {
            Screen.fullScreenMode = FullScreenMode.FullScreenWindow;
            isFullScreen = false;
        }
    }
    void qualityClick()
    {
        if(QualitySettings.GetQualityLevel() <= 2)
        {
            QualitySettings.SetQualityLevel(4);
        }else if (QualitySettings.GetQualityLevel() == 4)
        {
            QualitySettings.SetQualityLevel(5);
        }
        else if (QualitySettings.GetQualityLevel() >= 5)
        {
            QualitySettings.SetQualityLevel(1);
        }
    }
}
