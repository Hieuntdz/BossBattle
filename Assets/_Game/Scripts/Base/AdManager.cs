using System.Runtime.InteropServices.ComTypes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Threading.Tasks;
using DG.Tweening;
public class AdManager : MonoSingleton<AdManager>
{
//     string bannerAdUnitId = "02611b48ff0996a4";
//     string InterstitialUnitId = "05c688dcb5c657e2";
//     string RewardAdUnitId = "1fccacbe0a64c14d";
//     public ADRewardConfig RewardType;
//     private Action<bool> CallbackFunc;
//     int retryAttemptReward;
//     int retryAttemptInter;
//     public bool isBlockInter = false;
//     private bool isEarnedReward = false;
//     // Start is called before the first frame update
//     void Start()
//     {
//         MaxSdkCallbacks.OnSdkInitializedEvent += (MaxSdkBase.SdkConfiguration sdkConfiguration) =>
//         {
//             // AppLovin SDK is initialized, start loading ads
//             // Banners are automatically sized to 320�50 on phones and 728�90 on tablets
//             // You may call the utility method MaxSdkUtils.isTablet() to help with view sizing adjustments
//             // InitializeBannerAds();
//             InitializeInterstitialAds();
//             InitializeRewardAds();
//             // MaxSdk.ShowMediationDebugger();
//         };
//         MaxSdk.SetSdkKey("zq2X1FfdfeIMOsmepidyMNbeqvHKzJyNwy6EI2lT_14Ns_yAy-XVUTSsThDAZ5-AqDJ2OU0CLSeP7euEiV4wor");
//         MaxSdk.SetUserId("USER_ID");
//         MaxSdk.InitializeSdk();
//     }
//     IEnumerator CountBlockTime()
//     {
//         yield return new WaitForSecondsRealtime(Constant.gapTimeInter);
//         isBlockInter = false;
//         // AdManager.Instance.ShowInterstitialSpamAds();
//     }
//     #region  Banner events
//     private void InitializeBannerAds()
//     {
//         // Banners are automatically sized to 320×50 on phones and 728×90 on tablets
//         // You may call the utility method MaxSdkUtils.isTablet() to help with view sizing adjustments
//         MaxSdk.CreateBanner(bannerAdUnitId, MaxSdkBase.BannerPosition.BottomCenter);

//         // Set background or background color for banners to be fully functional
//         MaxSdk.SetBannerBackgroundColor(bannerAdUnitId, Color.black);

//         MaxSdkCallbacks.Banner.OnAdLoadedEvent += OnBannerAdLoadedEvent;
//         MaxSdkCallbacks.Banner.OnAdLoadFailedEvent += OnBannerAdLoadFailedEvent;
//         MaxSdkCallbacks.Banner.OnAdClickedEvent += OnBannerAdClickedEvent;
//         MaxSdkCallbacks.Banner.OnAdRevenuePaidEvent += OnBannerAdRevenuePaidEvent;
//         MaxSdkCallbacks.Banner.OnAdExpandedEvent += OnBannerAdExpandedEvent;
//         MaxSdkCallbacks.Banner.OnAdCollapsedEvent += OnBannerAdCollapsedEvent;
//         // Show the first banner
//         MaxSdk.ShowBanner(bannerAdUnitId);
//     }
//     public void ShowBanner()
//     {
//         MaxSdk.ShowBanner(bannerAdUnitId);
//     }
//     public void HideBanner()
//     {
//         MaxSdk.HideBanner(bannerAdUnitId);
//     }
//     private void OnBannerAdLoadedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo) { }

//     private void OnBannerAdLoadFailedEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo) { }

//     private void OnBannerAdClickedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo) { }

//     private void OnBannerAdRevenuePaidEvent(string adUnitId, MaxSdkBase.AdInfo adInfo) { }

//     private void OnBannerAdExpandedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo) { }

//     private void OnBannerAdCollapsedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo) { }
//     #endregion

//     #region Interstitial Events

//     private void InitializeInterstitialAds()
//     {
//         // Attach callback
//         MaxSdkCallbacks.Interstitial.OnAdLoadedEvent += OnInterstitialLoadedEvent;
//         MaxSdkCallbacks.Interstitial.OnAdLoadFailedEvent += OnInterstitialLoadFailedEvent;
//         MaxSdkCallbacks.Interstitial.OnAdDisplayedEvent += OnInterstitialDisplayedEvent;
//         MaxSdkCallbacks.Interstitial.OnAdClickedEvent += OnInterstitialClickedEvent;
//         MaxSdkCallbacks.Interstitial.OnAdHiddenEvent += OnInterstitialHiddenEvent;
//         MaxSdkCallbacks.Interstitial.OnAdDisplayFailedEvent += OnInterstitialAdFailedToDisplayEvent;
//         MaxSdkCallbacks.Interstitial.OnAdRevenuePaidEvent += OnAdRevenuePaidEvent;
//         MaxSdkCallbacks.Rewarded.OnAdRevenuePaidEvent += OnAdRevenuePaidEvent;
//         MaxSdkCallbacks.Banner.OnAdRevenuePaidEvent += OnAdRevenuePaidEvent;
//         MaxSdkCallbacks.MRec.OnAdRevenuePaidEvent += OnAdRevenuePaidEvent;

//         // Load the first interstitial
//         LoadInterstitial();
//     }
//     private void OnAdRevenuePaidEvent(string adUnitId, MaxSdkBase.AdInfo impressionData)
//     {
//         double revenue = impressionData.Revenue;
//         var impressionParameters = new[] {
//             new Firebase.Analytics.Parameter("ad_platform", "AppLovin"),
//             new Firebase.Analytics.Parameter("ad_source", impressionData.NetworkName),
//             new Firebase.Analytics.Parameter("ad_unit_name", impressionData.AdUnitIdentifier),
//             new Firebase.Analytics.Parameter("ad_format", impressionData.AdFormat),
//             new Firebase.Analytics.Parameter("value", revenue),
//             new Firebase.Analytics.Parameter("currency", "USD"), // All AppLovin revenue is sent in USD
//         };
//         Firebase.Analytics.FirebaseAnalytics.LogEvent("ad_impression", impressionParameters);
//     }
//     public void LoadInterstitial()
//     {
//         MaxSdk.LoadInterstitial(InterstitialUnitId);
//     }
//     public bool IsInterstitialReady()
//     {
//         if (MaxSdk.IsInterstitialReady(InterstitialUnitId))
//             return true;
//         LoadInterstitial();
//         return false;
//     }
//     public void ForceShowInterstitial(Action _callback)
//     {
//         if (Facade.Instance.PlayerData.RemoveAds == 1)
//             return;
//         if (IsInterstitialReady())
//         {
//             FirebaseManager.LogEvent(FirebaseManager.m_force_inter);
//             _callback?.Invoke();
//             AppOpenAdsManager.isBlockGoogleOpenAdsOnce = true;
//             MaxSdk.ShowInterstitial(InterstitialUnitId);
//         }
//     }
//     public void ShowInterstitial()
//     {
//         if (Facade.Instance.PlayerData.RemoveAds == 1)
//             return;
//         if (PlayerData.Instance.CurrentLevel == 1)
//             return;
//         if (isBlockInter)
//             return;
//         if (IsInterstitialReady())
//         {
//             FirebaseManager.LogEvent(FirebaseManager.m_inter_attempt);
//             isBlockInter = true;
//             AppOpenAdsManager.isBlockGoogleOpenAdsOnce = true;
//             MaxSdk.ShowInterstitial(InterstitialUnitId);
//         }
//     }
//     public void ShowInterstitialSpamAds()
//     {
//         if (Facade.Instance.PlayerData.RemoveAds == 1)
//             return;
//         if (Constant.isAllowToSpamAds)
//             ShowInterstitial();
//     }
//     private void OnInterstitialLoadedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
//     {
//         // Reset retry attempt
//         retryAttemptInter = 0;

//     }

//     private void OnInterstitialLoadFailedEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo)
//     {
//         // Interstitial ad failed to load 
//         // AppLovin recommends that you retry with exponentially higher delays, up to a maximum delay (in this case 64 seconds)
//         retryAttemptInter++;
//         double retryDelay = Math.Pow(2, Math.Min(6, retryAttemptInter));
//         Invoke("LoadInterstitial", (float)retryDelay);
//     }

//     private void OnInterstitialDisplayedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
//     {
//         FirebaseManager.LogEvent(FirebaseManager.m_af_inters);
//         AppsFlyerObjectScript.sendEventAppsflyer(AppsFlyerObjectScript.af_inter);
//     }

//     private void OnInterstitialAdFailedToDisplayEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo, MaxSdkBase.AdInfo adInfo)
//     {
//         LoadInterstitial();
//     }

//     private void OnInterstitialClickedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo) { }

//     private void OnInterstitialHiddenEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
//     {
//         // Interstitial ad is hidden. Pre-load the next ad.
//         StopAllCoroutines();
//         StartCoroutine(CountBlockTime());
//         LoadInterstitial();
//     }
//     #endregion

//     #region Reward events
//     private void InitializeRewardAds()
//     {
//         // Attach callback
//         MaxSdkCallbacks.Rewarded.OnAdLoadedEvent += OnRewardedAdLoadedEvent;
//         MaxSdkCallbacks.Rewarded.OnAdLoadFailedEvent += OnRewardedAdLoadFailedEvent;
//         MaxSdkCallbacks.Rewarded.OnAdDisplayedEvent += OnRewardedAdDisplayedEvent;
//         MaxSdkCallbacks.Rewarded.OnAdClickedEvent += OnRewardedAdClickedEvent;
//         MaxSdkCallbacks.Rewarded.OnAdRevenuePaidEvent += OnRewardedAdRevenuePaidEvent;
//         MaxSdkCallbacks.Rewarded.OnAdHiddenEvent += OnRewardedAdHiddenEvent;
//         MaxSdkCallbacks.Rewarded.OnAdDisplayFailedEvent += OnRewardedAdFailedToDisplayEvent;
//         MaxSdkCallbacks.Rewarded.OnAdReceivedRewardEvent += OnRewardedAdReceivedRewardEvent;

//         MaxSdkCallbacks.Interstitial.OnAdRevenuePaidEvent += OnAdRevenuePaidEvent;
//         MaxSdkCallbacks.Rewarded.OnAdRevenuePaidEvent += OnAdRevenuePaidEvent;
//         MaxSdkCallbacks.Banner.OnAdRevenuePaidEvent += OnAdRevenuePaidEvent;
//         MaxSdkCallbacks.MRec.OnAdRevenuePaidEvent += OnAdRevenuePaidEvent;
//         // Load the first interstitial
//         LoadRewardedAd();
//     }
//     public void LoadRewardedAd()
//     {
//         MaxSdk.LoadRewardedAd(RewardAdUnitId);
//     }
//     public bool IsRewardReady()
//     {
//         if (MaxSdk.IsRewardedAdReady(RewardAdUnitId))
//             return true;
//         LoadRewardedAd();
//         if (PlayerData.Instance.RemoveAds == 1)
//             return true;
//         return false;
//     }
//     public void ShowRewardedAd(ADRewardConfig _rewardType, Action<bool> callback)
//     {
//         if (Facade.Instance.PlayerData.RemoveAds == 1)
//         {
//             this.CallbackFunc = callback;
//             this.RewardType = _rewardType;
//             CallbackFunc(true);
//             switch (RewardType)
//             {
//                 case ADRewardConfig.R_MINIMAP:
//                     UIManager.Instance.pfb_GamePlay.P_Booster.BoosterZone.ActiveUIBooster(BOOSTER_INGAME.MINIMAP);
//                     break;
//                 case ADRewardConfig.R_REVIVE:
//                     break;
//                 case ADRewardConfig.R_SECOND_CHANCE:
//                     UIManager.Instance.pfb_GamePlay.P_Booster.BoosterZone.ActiveUIBooster(BOOSTER_INGAME.SHIELD);
//                     break;
//                 case ADRewardConfig.R_SPEED:
//                     UIManager.Instance.pfb_GamePlay.P_Booster.BoosterZone.ActiveUIBooster(BOOSTER_INGAME.SPEED);
//                     PlayerController.Instance.plus_speed++;
//                     break;
//                 case ADRewardConfig.R_SKIP_MINIGAME:
//                     break;
//             }
//             return;
//         }
// #if !UNITY_EDITOR
//         switch (RewardType)
//         {
//             case ADRewardConfig.R_MINIMAP:
//                 FirebaseManager.LogEvent(FirebaseManager.reward_attempt_map, "level", "level_" + PlayerData.Instance.CurrentLevel);
//                 break;
//             case ADRewardConfig.R_REVIVE:
//                 FirebaseManager.LogEvent(FirebaseManager.reward_attempt_revive, "level", "level_" + PlayerData.Instance.CurrentLevel);
//                 break;
//             case ADRewardConfig.R_SECOND_CHANCE:
//                 FirebaseManager.LogEvent(FirebaseManager.reward_attempt_shield, "level", "level_" + PlayerData.Instance.CurrentLevel);
//                 break;
//             case ADRewardConfig.R_SPEED:
//                 FirebaseManager.LogEvent(FirebaseManager.reward_attempt_speed, "level", "level_" + PlayerData.Instance.CurrentLevel);
//                 break;
//             case ADRewardConfig.R_SKIP_MINIGAME:
//                 FirebaseManager.LogEvent(FirebaseManager.reward_attempt_skip_minigame, "level", "level_" + PlayerData.Instance.CurrentLevel);
//                 break;
//         }
//             if(IsRewardReady()){
//                 FirebaseManager.LogEvent(FirebaseManager.m_reward_attempt);
//                 AppOpenAdsManager.isBlockGoogleOpenAdsOnce = true;
//                 MaxSdk.ShowRewardedAd(RewardAdUnitId);
//                 this.CallbackFunc = callback;
//                 this.RewardType = _rewardType;
//             }else{
//                 LoadRewardedAd();
//             }

// #elif UNITY_EDITOR
//         this.RewardType = _rewardType;
//         this.CallbackFunc = callback;
//         CallbackFunc(true);
//         switch (RewardType)
//         {
//             case ADRewardConfig.R_MINIMAP:
//                 UIManager.Instance.pfb_GamePlay.P_Booster.BoosterZone.ActiveUIBooster(BOOSTER_INGAME.MINIMAP);
//                 break;
//             case ADRewardConfig.R_REVIVE:
//                 break;
//             case ADRewardConfig.R_SECOND_CHANCE:
//                 UIManager.Instance.pfb_GamePlay.P_Booster.BoosterZone.ActiveUIBooster(BOOSTER_INGAME.SHIELD);
//                 break;
//             case ADRewardConfig.R_SPEED:
//                 UIManager.Instance.pfb_GamePlay.P_Booster.BoosterZone.ActiveUIBooster(BOOSTER_INGAME.SPEED);
//                 PlayerController.Instance.plus_speed++;
//                 break;
//             case ADRewardConfig.R_SKIP_MINIGAME:
//                 break;
//         }
// #endif

//     }
//     private void OnRewardedAdLoadedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
//     {
//         // Reset retry attempt
//         retryAttemptReward = 0;
//     }

//     private void OnRewardedAdLoadFailedEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo)
//     {
//         // Rewarded ad failed to load 
//         // AppLovin recommends that you retry with exponentially higher delays, up to a maximum delay (in this case 64 seconds).

//         retryAttemptReward++;
//         double retryDelay = Math.Pow(2, Math.Min(6, retryAttemptReward));

//         Invoke("LoadRewardedAd", (float)retryDelay);
//     }

//     private void OnRewardedAdDisplayedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
//     {
//         FirebaseManager.LogEvent(FirebaseManager.m_af_reward);
//         AppsFlyerObjectScript.sendEventAppsflyer(AppsFlyerObjectScript.af_rewarded);

//         switch (RewardType)
//         {
//             case ADRewardConfig.R_MINIMAP:
//                 FirebaseManager.LogEvent(FirebaseManager.reward_map, "level", "level_" + PlayerData.Instance.CurrentLevel);
//                 break;
//             case ADRewardConfig.R_REVIVE:
//                 FirebaseManager.LogEvent(FirebaseManager.m_reward_revive, "level", "level_" + PlayerData.Instance.CurrentLevel);
//                 break;
//             case ADRewardConfig.R_SECOND_CHANCE:
//                 FirebaseManager.LogEvent(FirebaseManager.reward_shield, "level", "level_" + PlayerData.Instance.CurrentLevel);
//                 break;
//             case ADRewardConfig.R_SPEED:
//                 FirebaseManager.LogEvent(FirebaseManager.reward_speed, "level", "level_" + PlayerData.Instance.CurrentLevel);
//                 break;
//             case ADRewardConfig.R_SKIP_MINIGAME:
//                 FirebaseManager.LogEvent(FirebaseManager.reward_skip_minigame, "level", "level_" + PlayerData.Instance.CurrentLevel);
//                 break;
//         }
//     }

//     private void OnRewardedAdFailedToDisplayEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo, MaxSdkBase.AdInfo adInfo)
//     {
//         // Rewarded ad failed to display. AppLovin recommends that you load the next ad.
//         LoadRewardedAd();
//     }

//     private void OnRewardedAdClickedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
//     {

//     }

//     private void OnRewardedAdHiddenEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
//     {
//         // Rewarded ad is hidden. Pre-load the next ad
//         LoadRewardedAd();
//         if (isEarnedReward)
//         {
//             CallbackFunc(true);
//             isEarnedReward = false;

//             switch (RewardType)
//             {
//                 case ADRewardConfig.R_MINIMAP:
//                     UIManager.Instance.pfb_GamePlay.P_Booster.BoosterZone.ActiveUIBooster(BOOSTER_INGAME.MINIMAP);
//                     break;
//                 case ADRewardConfig.R_REVIVE:
//                     FirebaseManager.LogEvent(FirebaseManager.m_res);
//                     break;
//                 case ADRewardConfig.R_SECOND_CHANCE:
//                     UIManager.Instance.pfb_GamePlay.P_Booster.BoosterZone.ActiveUIBooster(BOOSTER_INGAME.SHIELD);
//                     FirebaseManager.LogEvent(FirebaseManager.m_shield);
//                     break;
//                 case ADRewardConfig.R_SPEED:
//                     UIManager.Instance.pfb_GamePlay.P_Booster.BoosterZone.ActiveUIBooster(BOOSTER_INGAME.SPEED);
//                     PlayerController.Instance.plus_speed++;
//                     if (PlayerController.Instance.plus_speed == 1)
//                         FirebaseManager.LogEvent(FirebaseManager.m_speed_1);
//                     else if (PlayerController.Instance.plus_speed == 2)
//                         FirebaseManager.LogEvent(FirebaseManager.m_speed_2);
//                     break;
//                 case ADRewardConfig.R_SKIP_MINIGAME:
//                     break;
//             }
//             isBlockInter = true;
//             StopCoroutine(CountBlockTime());
//             StartCoroutine(CountBlockTime());
//         }

//     }

//     private void OnRewardedAdReceivedRewardEvent(string adUnitId, MaxSdk.Reward reward, MaxSdkBase.AdInfo adInfo)
//     {
//         isEarnedReward = true;
//     }

//     private void OnRewardedAdRevenuePaidEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
//     {
//         // Ad revenue paid. Use this callback to track user revenue.
//     }

//     #endregion
}