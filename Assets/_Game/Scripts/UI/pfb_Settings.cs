using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class pfb_Settings : UIBehavior
{
    [SerializeField] private Button btnMusic, btnSound, btnVibrate, btnClose;
    [SerializeField] private Image MusicOff, SoundOff, VibrateOff;

    private void Start() {
        btnMusic.onClick.AddListener(OnClickBtnMusic);
        btnSound.onClick.AddListener(OnClickBtnSound);
        btnVibrate.onClick.AddListener(OnClickBtnVibrate);
        btnClose.onClick.AddListener(delegate{
            ActiveNormalPopup(false);
        });
    }

    protected override void OnEnable()
    {
        base.OnEnable();
        UpdateUI();
    }
    protected override void UpdateUI()
    {
        base.UpdateUI();
        if (Facade.Instance.PlayerData.MusicState == 1)
        {
            SoundManager.Instance.SwitchMusic(true);
            btnMusic.GetComponent<Image>().ChangeAlpha(1);
            MusicOff.ChangeAlpha(0);
        }
        else
        {
            SoundManager.Instance.SwitchMusic(false);
            btnMusic.GetComponent<Image>().ChangeAlpha(0);
            MusicOff.ChangeAlpha(1);
        }

        if (Facade.Instance.PlayerData.SoundState == 1)
        {
            SoundManager.Instance.SwitchSound(true);
            btnSound.GetComponent<Image>().ChangeAlpha(1);
            SoundOff.ChangeAlpha(0);
        }
        else
        {
            SoundManager.Instance.SwitchSound(false);
            btnSound.GetComponent<Image>().ChangeAlpha(0);
            SoundOff.ChangeAlpha(1);
        }

        if (Facade.Instance.PlayerData.VibrateState == 1)
        {
            btnVibrate.GetComponent<Image>().ChangeAlpha(1);
            VibrateOff.ChangeAlpha(0);
        }
        else
        {
            btnVibrate.GetComponent<Image>().ChangeAlpha(0);
            VibrateOff.ChangeAlpha(1);
        }
    }
    private void OnClickBtnMusic()
    {
        SoundManager.Instance.PlayAudioClip(SoundManager.SoundType.CLICK);
        if (Facade.Instance.PlayerData.MusicState != 1)
        {
            Facade.Instance.PlayerData.MusicState = 1;
            SoundManager.Instance.SwitchMusic(true);
            btnMusic.GetComponent<Image>().DOFade(1, 1f).SetUpdate(true);
            MusicOff.DOFade(0, 1f).SetUpdate(true);
        }
        else
        {
            Facade.Instance.PlayerData.MusicState = -1;
            SoundManager.Instance.SwitchMusic(false);
            btnMusic.GetComponent<Image>().DOFade(0, 1f).SetUpdate(true);
            MusicOff.DOFade(1, 1f).SetUpdate(true);
        }
    }
    private void OnClickBtnSound()
    {
        SoundManager.Instance.PlayAudioClip(SoundManager.SoundType.CLICK);
        if (Facade.Instance.PlayerData.SoundState != 1)
        {
            Facade.Instance.PlayerData.SoundState = 1;
            SoundManager.Instance.SwitchSound(true);
            btnSound.GetComponent<Image>().DOFade(1, 1f).SetUpdate(true);
            SoundOff.DOFade(0, 1f).SetUpdate(true);
        }
        else
        {
            Facade.Instance.PlayerData.SoundState = -1;
            SoundManager.Instance.SwitchSound(false);
            btnSound.GetComponent<Image>().DOFade(0, 1f).SetUpdate(true);
            SoundOff.DOFade(1, 1f).SetUpdate(true);
        }
    }
    private void OnClickBtnVibrate()
    {
        SoundManager.Instance.PlayAudioClip(SoundManager.SoundType.CLICK);
        if (Facade.Instance.PlayerData.VibrateState != 1)
        {
            Facade.Instance.PlayerData.VibrateState = 1;
            Facade.Instance.Vibrate();
            btnVibrate.GetComponent<Image>().DOFade(1, 1f).SetUpdate(true);
            VibrateOff.DOFade(0, 1f).SetUpdate(true);
        }
        else
        {
            Facade.Instance.PlayerData.VibrateState = -1;
            btnVibrate.GetComponent<Image>().DOFade(0, 1f).SetUpdate(true);
            VibrateOff.DOFade(1, 1f).SetUpdate(true);
        }
    }
}
