using UnityEngine;
using UnityEngine.Audio;

public class SettingsManager : MonoBehaviour
{
    public AudioMixer masterMixer;
    
    public void SetFullScreen(bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;
    }

    public void SetQualitylevel(int index)
    {
        QualitySettings.SetQualityLevel(index);
    }

    public void Setvolume(float volume)
    {
        masterMixer.SetFloat(name:"Volume", volume);
    }
}
