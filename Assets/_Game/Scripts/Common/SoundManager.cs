using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoSingleton<SoundManager>
{
    public enum SoundType
    {
        CLICK = 0,
        WIN = 1,
        CLAIM = 2,
        WARNING = 3,
        BG_SOUND_MENU = 4, 
        BG_SOUND_GAMEPLAY1 = 5,
        BG_SOUND_GAMEPLAY2 = 6,
        DEAD_BY_BLUE = 7,
        DEAD_BY_ORANGE = 8,
        DEAD_BY_GREEN = 9,
        DEAD_BY_PURPLE = 10,
        CUBE_DISAPPEAR = 11,
        TEXTING = 12,
        MONSTER_WITNESS = 13,
        CHANGE_SCENE = 14,
        LOSE = 15,
        RETURN_ITEM = 16,
        RETURN_FULL = 17,
        PICK_FUSE,
        PICK_TESSERACT,
        PICK_FOODBOX,
        PICK_PIN,
        BOXING
    }   
    [System.Serializable]
    public class SoundAudioClip
    {
        public SoundType type;
        public AudioClip clip;
    }
    [Header("Sounds")]
    [SerializeField] private AudioSource SoundProcessor;
    [SerializeField] private AudioSource BackgroundProcessor;
    public List<SoundAudioClip> AudioClips = new List<SoundAudioClip>();

    void Start()
    {
        if (PlayerData.Instance.SoundState != 1)
            SoundProcessor.mute = true;
        if (PlayerData.Instance.MusicState != 1)
            BackgroundProcessor.mute = true;
        else
            BackgroundProcessor.Play();
    }
    public void SwitchMusic(bool b)
    {
        BackgroundProcessor.mute = !b;
    }
    public void SwitchSound(bool b)
    {
        EventHandler.ExecuteEvent(EventID.m_change_sound_state);
        SoundProcessor.mute = !b;
    }
    public void PlayAudioClip(SoundType type, bool isContinue = true)
    {
        if (SoundProcessor.isPlaying && !isContinue)
            return;
        SoundProcessor.PlayOneShot(getAudioClip(type));
    }
    public void StopSoundProcessor()
    {
        if (SoundProcessor.isPlaying)
            SoundProcessor.Stop();
    }
    private AudioClip getAudioClip(SoundType _type)
    {
        return AudioClips.Find(x => x.type == _type).clip;
    }

    public void PlayBackgroundSound(SoundType _type){
        BackgroundProcessor.Stop();
        BackgroundProcessor.clip = AudioClips.Find(x => x.type == _type).clip;
        BackgroundProcessor.Play();
    }
}
