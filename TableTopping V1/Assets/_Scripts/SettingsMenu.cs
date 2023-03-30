using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour
{

    public AudioMixer audioMixer;

    //Reference Link: https://youtu.be/YOaYQrN1oYQ?t=73
    //This function sets the game's masterVolume audio parameter equal to the VolumeSlider object value.
    //This slider dictate the the master volume setting

    //VolumeSlider object 'value': Canvas > Options Menu > VolumeSlider > Slider > Value
    //Master Volume Parameter 'masterVolume': Window > Audio > Audio Mixer > MainMixer > Exposed Parameters > masterVolume
    public void SetVolume(float volume)
    {
        //"masterVolume" is the name of the exposed parameter found in the Audio Mixer window
        //volume is defined by the value of VolumeSlider
        audioMixer.SetFloat("masterVolume", volume);
    }


    //Reference Link: https://youtu.be/YOaYQrN1oYQ?t=336
    //This function sets the game's quality level depending on the option selected in the GraphicsDropdown object 

    //GraphicsDropdown object 'options menu': Canvas > Options Menu > GraphicsDropdown > Dropdown-TextMeshPro > Options
    //Quality levels are defined in: Edit > Project Settings > Quality
    public void SetQuality(int qualityIndex)
    {
        //(int qualityIndex) represents the index of the quality level (low = 0, medium = 1, high = 2)

        //qualityIndex is incremented by +1 because the project file has 6 levels of quality settings but for the
            //purposes of the GraphicsDropdown menu only the Low, Medium, and High settings are being used.
        QualitySettings.SetQualityLevel(qualityIndex+1);
    }

    //Reference Link: https://youtu.be/YOaYQrN1oYQ?t=469
    //This function toggles fullscreen mode on and off depending on a checkbox in the FullscreenToggle object
    
    //FullscreenToggle object 'checkbox': Canvas > Options Menu > FullscreenToggle > Toggle > Is On (checkbox)
    //Fullscreen Mode option: Edit > Project Settings > Player > Resolution and Presentation (Not too sure of the exact setting being modified)
    
    public void SetFullscreen(bool isFullscreen)
    {
        //checkbox at time of writting is autoselected to be on meaning fullscreen mode if the default state of the game
        //if checkbox is deselected then the game changes to windowed mode
        Screen.fullScreen = isFullscreen;
    }


}
