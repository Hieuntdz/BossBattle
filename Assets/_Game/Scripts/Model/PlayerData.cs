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
    private int m_unlock_skin0;
    private int m_unlock_skin1;
    private int m_unlock_skin2;
    private int m_unlock_skin3;
    private int m_unlock_skin4;
    private int m_unlock_skin5;
    private int m_unlock_skin6;
    private int m_skin_equipped;
    public int Coin{
        get{
            return this.m_coin;
        }
        set{
            this.m_coin = value;
            PlayerPrefs.SetInt("Coin", value);
        }
    }
    public int Skin_Equipped{
        get{
            return this.m_skin_equipped;
        }
        set{
            this.m_skin_equipped = value;
            PlayerPrefs.SetInt("skin_equipped", value);
        }
    }
    public int Unlock_Skin00{
        get{
            return this.m_unlock_skin0;
        }
        set{
            this.m_unlock_skin0 = value;
            PlayerPrefs.SetInt("Unlock_Skin00", value);
        }
    }
    public int Unlock_Skin01{
        get{
            return this.m_unlock_skin1;
        }
        set{
            this.m_unlock_skin1 = value;
            PlayerPrefs.SetInt("Unlock_Skin01", value);
        }
    }
    public int Unlock_Skin02{
        get{
            return this.m_unlock_skin2;
        }
        set{
            this.m_unlock_skin2 = value;
            PlayerPrefs.SetInt("Unlock_Skin02", value);
        }
    }
    public int Unlock_Skin03{
        get{
            return this.m_unlock_skin3;
        }
        set{
            this.m_unlock_skin3 = value;
            PlayerPrefs.SetInt("Unlock_Skin03", value);
        }
    }
    public int Unlock_Skin04{
        get{
            return this.m_unlock_skin4;
        }
        set{
            this.m_unlock_skin4 = value;
            PlayerPrefs.SetInt("Unlock_Skin04", value);
        }
    }
    public int Unlock_Skin05{
        get{
            return this.m_unlock_skin5;
        }
        set{
            this.m_unlock_skin5 = value;
            PlayerPrefs.SetInt("Unlock_Skin05", value);
        }
    }
    public int Unlock_Skin06{
        get{
            return this.m_unlock_skin6;
        }
        set{
            this.m_unlock_skin6 = value;
            PlayerPrefs.SetInt("Unlock_Skin06", value);
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
    protected override void Awake(){
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
        m_unlock_skin0 = PlayerPrefs.GetInt("Unlock_Skin00", 1);
        m_unlock_skin1 = PlayerPrefs.GetInt("Unlock_Skin01", 0);
        m_unlock_skin2 = PlayerPrefs.GetInt("Unlock_Skin02", 0);
        m_unlock_skin3 = PlayerPrefs.GetInt("Unlock_Skin03", 0);
        m_unlock_skin4 = PlayerPrefs.GetInt("Unlock_Skin04", 0);
        m_unlock_skin5 = PlayerPrefs.GetInt("Unlock_Skin05", 0);
        m_unlock_skin6 = PlayerPrefs.GetInt("Unlock_Skin06", 0);
        m_skin_equipped = PlayerPrefs.GetInt("skin_equipped", 0);

        #if UNITY_EDITOR
            RemoveAds = 1;
        #endif
    }
}
