using System.Linq;
using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System.IO;
using Newtonsoft.Json;

public class Facade : MonoSingleton<Facade>
{
    public PlayerData PlayerData;
    public GameManager GameManager;
    protected override void Awake()
    {
        Application.targetFrameRate = 60;
        base.Awake();
        ClearData();
        PlayerData = new GameObject("PlayerData").AddComponent<PlayerData>();
    }
    void Start()
    {
        Initialize();
        //Set bg
    }
    public void Vibrate()
    {
        if (PlayerData.VibrateState != 1)
            return;
        Taptic.Vibrate();
    }
    private void Initialize()
    {
        Instantiate(Utils.ResourcesLoad<GameObject>("CreateController"));
        new GameObject("UIManager").AddComponent<UIManager>();
        UIManager.Instance.Initialize();
        GameManager = Instantiate<GameManager>(Utils.ResourcesLoad<GameManager>("GameManager"));
        DontDestroyOnLoad(GameManager);
    }
    private void ClearData()
    {
        // if (!PlayerPrefs.HasKey("BundleVersion"))
        // {
        //     string path = DataController.GetFilePath(Config.key_skin_cat);
        //     string path2 = DataController.GetFilePath(Config.key_skin_cage);
        //     string path3 = DataController.GetFilePath(Config.key_skin_background);
        //     Debug.LogError("paths: " + path);
        //     if (File.Exists(path))
        //         File.Delete(path);
        //     if (File.Exists(path2))
        //         File.Delete(path2);
        //     if (File.Exists(path3))
        //         File.Delete(path3);
        // }
    }

}
