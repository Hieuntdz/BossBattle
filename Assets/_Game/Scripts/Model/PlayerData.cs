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
    private int m_IdSkinCat;
    private int m_NumUndo;
    public int IdSkinCat{
        get{
            return this.m_IdSkinCat;
        }
        set{
            this.m_IdSkinCat = value;
            PlayerPrefs.SetInt("IdSkinCat", value);
            ES3.Save("IdSkinCat", value);
        }
    }
    public int Coin{
        get{
            return this.m_coin;
        }
        set{
            this.m_coin = value;
            // PlayerPrefs.SetInt("Coin", value);
            ES3.Save("Coin", value);
        }
    }
    public int CurrentLevel{
        get{
            return this.m_CurrentLevel;
        }
        set{
            this.m_CurrentLevel = value;
            // PlayerPrefs.SetInt("CurrentLevel", value);
            ES3.Save("CurrentLevel", value);
        }
    }
    public int SoundState{
        get{
            return this.m_SoundState;
        }
        set{
            this.m_SoundState = value;
            // PlayerPrefs.SetInt("SoundState", value);
            ES3.Save("SoundState", value);
        }
    }
    public int MusicState{
        get{
            return this.m_MusicState;
        }
        set{
            this.m_MusicState = value;
            // PlayerPrefs.SetInt("MusicState", value);
            ES3.Save("MusicState", value);
        }
    }
    public int VibrateState{
        get{
            return this.m_VibrateState;
        }
        set{
            this.m_VibrateState = value;
            // PlayerPrefs.SetInt("VibrateState", value);
            ES3.Save("VibrateState", value);
        }
    }
    public int RemoveAds{
        get{
            return this.m_RemoveAds;
        }
        set{
            this.m_RemoveAds = value;
            // PlayerPrefs.SetInt("RemoveAds", value);
            ES3.Save("RemoveAds", value);
        }
    }
    public int LosingVirginity{
        get{
            return this.m_LosingVirginity;
        }
        set{
            this.m_LosingVirginity = value;
            // PlayerPrefs.SetInt("LosingVirginity", value);
            ES3.Save("LosingVirginity", value);
        }
    }
    protected override void Awake(){
        // if(!PlayerPrefs.HasKey("BundleVersion")){
        //     PlayerPrefs.SetString("BundleVersion", Application.version);
        // }
        if(ES3.KeyExists("BundleVersion"))
            ES3.Save("BundleVersion", Application.version);

        m_SoundState = 1;
        m_MusicState = 1;
        m_VibrateState = 1;
        m_RemoveAds = 0;
        m_LosingVirginity = 1;

        if(ES3.KeyExists("IdSkinCat"))
            m_IdSkinCat = ES3.Load<int>("IdSkinCat");
        if(ES3.KeyExists("Coin"))
            m_coin = ES3.Load<int>("Coin");
        if(ES3.KeyExists("CurrentLevel"))
            m_CurrentLevel = ES3.Load<int>("CurrentLevel");
        if(ES3.KeyExists("SoundState"))
            m_SoundState = ES3.Load<int>("SoundState");
        if(ES3.KeyExists("MusicState"))
            m_MusicState = ES3.Load<int>("MusicState");
        if(ES3.KeyExists("VibrateState"))
            m_VibrateState = ES3.Load<int>("VibrateState");
        if(ES3.KeyExists("RemoveAds"))
            m_RemoveAds = ES3.Load<int>("RemoveAds");
        if(ES3.KeyExists("RemoveAds"))
            m_LosingVirginity = ES3.Load<int>("RemoveAds");

        // m_LosingVirginity = PlayerPrefs.GetInt("LosingVirginity", 1);
    }
}
