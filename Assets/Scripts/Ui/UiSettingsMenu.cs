using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class UiSettingsMenu : MonoBehaviour
{
    [SerializeField] private AudioMixer mixer;
    [SerializeField] private Button exit;
    [SerializeField] private GameObject mainMenuPanel;
    [SerializeField] private GameObject settingsMenuPanel;
    [SerializeField] private Slider volumeMaster;
    [SerializeField] private Slider volumeBackground;
    [SerializeField] private Slider volumeSFX;
    [SerializeField] private Slider volumeUi;
    [SerializeField] private TMP_Text volumeMasterNumber;
    [SerializeField] private TMP_Text volumeBackgroundNumber;
    [SerializeField] private TMP_Text volumeSFXNumber;
    [SerializeField] private TMP_Text volumeUiNumber;
    private void Awake()
    {
        exit.onClick.AddListener(OnExitButtonClicked);
        volumeMaster.onValueChanged.AddListener(OnVolumeMasterChanged);
        volumeBackground.onValueChanged.AddListener(OnVolumeBackgroundChanged);
        volumeSFX.onValueChanged.AddListener(OnVolumeSFXChanged);
        volumeUi.onValueChanged.AddListener(OnVolumeUiChanged);
    }

    private void OnDestroy()
    {
        exit.onClick.RemoveListener(OnExitButtonClicked);
        volumeMaster.onValueChanged.RemoveListener(OnVolumeMasterChanged);
        volumeBackground.onValueChanged.RemoveListener(OnVolumeBackgroundChanged);
        volumeSFX.onValueChanged.RemoveListener(OnVolumeSFXChanged);
        volumeUi.onValueChanged.RemoveListener(OnVolumeUiChanged);
    }

    private void OnExitButtonClicked()
    {
        settingsMenuPanel.SetActive(false);
        mainMenuPanel.SetActive(true);
    }

    private void OnVolumeMasterChanged(float value)
    {
        volumeMasterNumber.text = value.ToString("f0");
        mixer.SetFloat("VolumeMaster", value);
    }
    private void OnVolumeBackgroundChanged(float value)
    {
        volumeBackgroundNumber.text = value.ToString("f0");
        mixer.SetFloat("VolumeBackground", value);
    }
    private void OnVolumeSFXChanged(float value)
    {
        volumeSFXNumber.text = value.ToString("f0");
        mixer.SetFloat("VolumeSFX", value);
    }
    private void OnVolumeUiChanged(float value)
    {
        volumeUiNumber.text = value.ToString("f0");
        mixer.SetFloat("VolumeUi", value);
    }



}
