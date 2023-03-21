using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using GoogleMobileAds.Api;
using System;
public class AppOpenAdsManager : MonoSingleton<AppOpenAdsManager>
{
// #if UNITY_ANDROID
//     private List<string> ListID = new List<string>(){"ca-app-pub-3592666561057448/9717942181", "ca-app-pub-3592666561057448/3611413425", "ca-app-pub-3592666561057448/7359086740","ca-app-pub-3592666561057448/6052180834"};
//     // private List<string> ListID = new List<string>(){"ca-app-pub-3592666561057448/6052180834"};
// #elif UNITY_IOS
//     private const string AD_UNIT_ID = "ca-app-pub-3592666561057448/9717942181";
// #else
//     private const string AD_UNIT_ID = "unexpected_platform";
// #endif

//     #region PROCESSING
//     public static bool isBlockGoogleOpenAdsOnce = false;
//     protected override void Awake()
//     {
//         base.Awake();
//         LoadAd();
//     }
//     public void OnApplicationPause(bool paused)
//     {
//         // Display the app open ad when the app is foregrounded
//         if (!paused)
//         {
//             if (isBlockGoogleOpenAdsOnce)
//             {
//                 isBlockGoogleOpenAdsOnce = false;
//                 return;
//             }
//             ShowAdIfAvailable();
//         }
//     }
//     #endregion
//     private AppOpenAd ad;
//     private bool isShowingAd = false;
//     private bool IsAdAvailable
//     {
//         get
//         {
//             return ad != null;
//         }
//     }
//     //Dùng để xác định open ads cần load, load dần theo thứ tự 
//     int IdIndex = 0;
//     public void LoadAd()
//     {
//         AdRequest request = new AdRequest.Builder().Build();
//         string idAOA = ListID[IdIndex];
//         // Load an app open ad for portrait orientation
//         AppOpenAd.LoadAd(idAOA, ScreenOrientation.Portrait, request, ((appOpenAd, error) =>
//         {
//             if (error != null)
//             {
//                 // Handle the error.
//                 Debug.LogFormat("Failed to load the ad. (reason: {0})", error.LoadAdError.GetMessage());
//                 IdIndex++;
//                 if(IdIndex == ListID.Count)
//                     IdIndex = 0;
//                 LoadAd();
//                 return;
//             }

//             // App open ad is loaded.
//             IdIndex = 0;
//             ad = appOpenAd;
//         }));
//     }
//     public void LoadAdAndShow()
//     {
//         AdRequest request = new AdRequest.Builder().Build();
//         string idAOA = ListID[IdIndex];
//         // Load an app open ad for portrait orientation
//         AppOpenAd.LoadAd(idAOA, ScreenOrientation.Portrait, request, ((appOpenAd, error) =>
//         {
//             if (error != null)
//             {
//                 // Handle the error.
//                 Debug.LogFormat("Failed to load the ad. (reason: {0})", error.LoadAdError.GetMessage());
//                 return;
//             }

//             // App open ad is loaded.
//             IdIndex = 0;
//             ad = appOpenAd;
//             ShowAdIfAvailable();
//         }));
//     }
//     public void ShowAdIfAvailable()
//     {
//         if (!IsAdAvailable || isShowingAd)
//         {
//             return;
//         }

//         ad.OnAdDidDismissFullScreenContent += HandleAdDidDismissFullScreenContent;
//         ad.OnAdFailedToPresentFullScreenContent += HandleAdFailedToPresentFullScreenContent;
//         ad.OnAdDidPresentFullScreenContent += HandleAdDidPresentFullScreenContent;
//         ad.OnAdDidRecordImpression += HandleAdDidRecordImpression;
//         ad.OnPaidEvent += HandlePaidEvent;

//         ad.Show();
//     }

//     private void HandleAdDidDismissFullScreenContent(object sender, EventArgs args)
//     {
//         Debug.Log("Closed app open ad");
//         // Set the ad to null to indicate that AppOpenAdManager no longer has another ad to show.
//         ad = null;
//         isShowingAd = false;
//         LoadAd();
//     }

//     private void HandleAdFailedToPresentFullScreenContent(object sender, AdErrorEventArgs args)
//     {
//         Debug.LogFormat("Failed to present the ad (reason: {0})", args.AdError.GetMessage());
//         // Set the ad to null to indicate that AppOpenAdManager no longer has another ad to show.
//         ad = null;
//         LoadAd();
//     }

//     private void HandleAdDidPresentFullScreenContent(object sender, EventArgs args)
//     {
//         FirebaseManager.LogEvent(FirebaseManager.m_af_AOA);
//         Debug.Log("Displayed app open ad");
//         isShowingAd = true;
//     }

//     private void HandleAdDidRecordImpression(object sender, EventArgs args)
//     {
//         Debug.Log("Recorded ad impression");
//     }

//     private void HandlePaidEvent(object sender, AdValueEventArgs args)
//     {
//         Debug.LogFormat("Received paid event. (currency: {0}, value: {1}",
//                 args.AdValue.CurrencyCode, args.AdValue.Value);
//     }
}
