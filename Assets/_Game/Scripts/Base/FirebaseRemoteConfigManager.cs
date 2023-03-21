using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using System;
// using Firebase;
// using Firebase.Extensions;
// using Firebase.Analytics;

public class FirebaseRemoteConfigManager : MonoSingleton<FirebaseRemoteConfigManager>
{
    // Start is called before the first frame update
    #region Không dùng - stuck game
    // Firebase.DependencyStatus dependencyStatus = Firebase.DependencyStatus.UnavailableOther;
    // // Use this for initialization
    // protected override void Awake()
    // {
    //     Firebase.FirebaseApp.CheckAndFixDependenciesAsync().ContinueWith(async task =>
    //     {
    //         dependencyStatus = task.Result;
    //         if (dependencyStatus == Firebase.DependencyStatus.Available)
    //             InitializeFirebase();
    //         else
    //             Debug.LogError("Could not resolve all Firebase dependencies: " + dependencyStatus);
    //     });

    // }
    // async void InitializeFirebase()
    // {
    //     System.Collections.Generic.Dictionary<string, object> defaults =
    //         new System.Collections.Generic.Dictionary<string, object>();
    //     // These are the values that are used if we haven't fetched data from the
    //     // server
    //     // yet, or if we ask for values that the server doesn't have:
    //     // defaults.Add("config_test_string", "default local string");
    //     // defaults.Add("config_test_int", 1);
    //     // defaults.Add("config_test_float", 1.0);
    //     defaults.Add("isAllowToSpamAds", false);
    //     defaults.Add("gapTimeInter", 45);
    //     await Firebase.RemoteConfig.FirebaseRemoteConfig.DefaultInstance.SetDefaultsAsync(defaults);
    //     Debug.Log("Remote config ready!");

    // }
    #endregion
    // Firebase.RemoteConfig.FirebaseRemoteConfig remoteConfigInstance;
    // private void Start()
    // {
    //     remoteConfigInstance = Firebase.RemoteConfig.FirebaseRemoteConfig.GetInstance(FirebaseApp.DefaultInstance);
    //     FetchDataAsync();
    // }
    // // Start a fetch request.
    // public Task FetchDataAsync()
    // {
    //     Debug.Log("Fetching data...");
    //     System.Threading.Tasks.Task fetchTask = remoteConfigInstance.FetchAsync(TimeSpan.Zero);
    //     return fetchTask.ContinueWith(FetchComplete);
    // }

    // void FetchComplete(Task fetchTask)
    // {
    //     if (fetchTask.IsCanceled)
    //     {
    //         Debug.Log("Fetch canceled.");
    //     }
    //     else if (fetchTask.IsFaulted)
    //     {
    //         Debug.Log("Fetch encountered an error.");
    //     }
    //     else if (fetchTask.IsCompleted)
    //     {
    //         Debug.Log("Fetch completed successfully!");
    //     }

    //     var info = Firebase.RemoteConfig.FirebaseRemoteConfig.DefaultInstance.Info;
    //     switch (info.LastFetchStatus)
    //     {
    //         case Firebase.RemoteConfig.LastFetchStatus.Success:
    //             remoteConfigInstance.ActivateAsync().ContinueWithOnMainThread(task =>
    //             {
    //                 Debug.Log(String.Format("Remote data loaded and ready (last fetch time {0}).",
    //                                     info.FetchTime));
    //                 Constant.isAllowToSpamAds = Firebase.RemoteConfig.FirebaseRemoteConfig.DefaultInstance.GetValue("isAllowToSpamAds").BooleanValue;
    //                 Debug.LogError("is allowed to spam Ads: " + Constant.isAllowToSpamAds);
    //                 Constant.gapTimeInter = Firebase.RemoteConfig.FirebaseRemoteConfig.DefaultInstance.GetValue("gapTimeInter").LongValue;
    //                 Debug.LogError("play time to show inter: " + Constant.gapTimeInter);
    //             });
    //             break;
    //         case Firebase.RemoteConfig.LastFetchStatus.Failure:
    //             switch (info.LastFetchFailureReason)
    //             {
    //                 case Firebase.RemoteConfig.FetchFailureReason.Error:
    //                     Debug.Log("Fetch failed for unknown reason");
    //                     break;
    //                 case Firebase.RemoteConfig.FetchFailureReason.Throttled:
    //                     Debug.Log("Fetch throttled until " + info.ThrottledEndTime);
    //                     break;
    //             }
    //             FetchDataAsync();
    //             break;
    //         case Firebase.RemoteConfig.LastFetchStatus.Pending:
    //             Debug.Log("Latest Fetch call still pending.");
    //             FetchDataAsync();

    //             break;
    //             // default:
    //             //     Debug.LogError("deo vao cai nao");
    //             //     break;
    //     }
    // }
}

