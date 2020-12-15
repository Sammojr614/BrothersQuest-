using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    public Dropdown ResSelect;
    public Button FullscreenButton;
    public Text buttonText;
    Resolution[] res;
    public bool isFullscreen;


    void Start()
    {
        FullscreenButton.onClick.AddListener(SwitchFull);
        res = Screen.resolutions;
        ResSelect.ClearOptions();

        List<string> options = new List<string>();
        int currentResIndex = 0;

        for (int i = 0; i < res.Length; i++)
        {
            string option = res[i].width + " x " + res[i].height;
            options.Add(option);

            if (res[i].width == Screen.currentResolution.width && res[i].height == Screen.currentResolution.height) ;

        }
        ResSelect.AddOptions(options);
        ResSelect.value = currentResIndex;
        ResSelect.RefreshShownValue();
    }

    public void SetResolution(int resolutionIndex)
    {
        Resolution resolution = res[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }
    private void Update()
    {
        FullScreenCheck();
    }
    void SwitchFull()
    {
        if(isFullscreen == true)
        {
            Screen.fullScreen = false;
        }else if(isFullscreen == false)
        {
            Screen.fullScreen = true;
        }
    }
    void FullScreenCheck()
    {
        if (Screen.fullScreen == true)
        {
            buttonText.text = "Windowed";
            isFullscreen = true;
        }else
        {
            buttonText.text = "FullScreen";
            isFullscreen = false;
        }
    }
}