using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoSingleton<PlayerData>
{
    private int m_coin;
    private int m_CurrentLevel;
    private int m_SoundState;
    private int m_MusicState;
    private int m_VibrateState;
    private int m_RemoveAds;
    private int m_LosingVirginity;
    private int m_number_Timer;
    private int m_number_Size;
    private int m_number_Power;
    public int Coin{
        get{
            return this.m_coin;
        }
        set{
            this.m_coin = value;
            PlayerPrefs.SetInt("Coin", value);
        }
    }
    public int CurrentLevel{
        get{
            return this.m_CurrentLevel;
        }
        set{
            this.m_CurrentLevel = value;
            PlayerPrefs.SetInt("CurrentLevel", value);
        }
    }
    public int SoundState{
        get{
            return this.m_SoundState;
        }
        set{
            this.m_SoundState = value;
            PlayerPrefs.SetInt("SoundState", value);
        }
    }
    public int MusicState{
        get{
            return this.m_MusicState;
        }
        set{
            this.m_MusicState = value;
            PlayerPrefs.SetInt("MusicState", value);
        }
    }
    public int VibrateState{
        get{
            return this.m_VibrateState;
        }
        set{
            this.m_VibrateState = value;
            PlayerPrefs.SetInt("VibrateState", value);
        }
    }
    public int RemoveAds{
        get{
            return this.m_RemoveAds;
        }
        set{
            this.m_RemoveAds = value;
            PlayerPrefs.SetInt("RemoveAds", value);
        }
    }
    public int LosingVirginity{
        get{
            return this.m_LosingVirginity;
        }
        set{
            this.m_LosingVirginity = value;
            PlayerPrefs.SetInt("LosingVirginity", value);
        }
    }
    public int NumberSize{
        get{
            return this.m_number_Size;
        }
        set{
            this.m_number_Size = value;
            PlayerPrefs.SetInt("NumberSize", value);
        }
    }
    public int NumberTimer{
        get{
            return this.m_number_Timer;
        }
        set{
            this.m_number_Timer = value;
            PlayerPrefs.SetInt("NumberTimer", value);
        }
    }
    public int NumberPower{
        get{
            return this.m_number_Power;
        }
        set{
            this.m_number_Power = value;
            PlayerPrefs.SetInt("NumberPower", value);
        }
    }
    protected virtual void Awake(){
        if(!PlayerPrefs.HasKey("BundleVersion")){
            PlayerPrefs.SetString("BundleVersion", Application.version);
        }
        m_coin = PlayerPrefs.GetInt("Coin",1000);
        m_CurrentLevel = PlayerPrefs.GetInt("CurrentLevel", 1);
        m_SoundState = PlayerPrefs.GetInt("SoundState", 1);
        m_MusicState = PlayerPrefs.GetInt("MusicState", 1);
        m_VibrateState = PlayerPrefs.GetInt("VibrateState", 1);
        m_RemoveAds = PlayerPrefs.GetInt("RemoveAds", 0);
        m_LosingVirginity = PlayerPrefs.GetInt("LosingVirginity", 1);
        m_number_Size = PlayerPrefs.GetInt("NumberSize", 1);
        m_number_Timer = PlayerPrefs.GetInt("NumberTimer", 1);
        m_number_Power = PlayerPrefs.GetInt("NumberPower", 1);

        #if UNITY_EDITOR
            RemoveAds = 1;
        #endif
    }
}
