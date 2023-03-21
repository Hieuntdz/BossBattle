using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using Firebase.Analytics;

public static class FirebaseManager
{
    public static string m_play_level = "play_level"; //Bắn khi bắt đầu chơi 1 level trong game
    public static string m_lose_level = "lose_level"; //Bắn khi chơi thua 1 level trong game
    public static string m_win_level = "win_level"; //Bắn khi chơi thắng 1 level trong game nếu có
    public static string m_open_app = "open_app"; //Bắn mỗi khi user mở app thành công
    public static string m_af_AOA = "af_AOA"; //Bắn mỗi khi hiển thị AOA thành công
    public static string m_af_inters = "af_inters"; //Bắn mỗi khi hiển thị inters thành công trên user device
    public static string m_inter_attempt = "inter_attempt"; //Bắn mỗi lần code gọi show inter
    public static string m_af_reward = "af_reward"; //Bắn mỗi khi hiển thị rewards thành công trên user device
    public static string m_reward_attempt = "reward_attempt"; //Bắn mỗi lần code gọi show reward
    public static string m_reward_skin = "reward_skin"; //Bắn mỗi khi user claim skin mèo (Index theo ID)
    public static string m_reward_background = "reward_background"; //Bắn mỗi khi user claim background (Index theo ID)
    public static string m_reward_cage = "reward_cage"; //Bắn mỗi khi user claim chuồng mèo(Index theo ID)
    public static string m_pass_level_5 = "pass_level_5"; //Bắn mỗi khi user chơi qua level 5
    public static string m_pass_level_10 = "pass_level_10"; //Bắn mỗi khi user chơi qua level 10
    public static string m_pass_level_20 = "pass_level_20"; //Bắn mỗi khi user chơi qua level 20
    public static string m_pass_level_30 = "pass_level_30"; //Bắn mỗi khi user chơi qua level 30
    public static string m_pass_level_40 = "pass_level_40"; //Bắn mỗi khi user chơi qua level 40
    public static string m_pass_level_50 = "pass_level_50"; //Bắn mỗi khi user chơi qua level 50
    private static List<string> Constraints = new List<string>();
    // public static void LogEvent(string eventName){
    //     FirebaseAnalytics.LogEvent(eventName);
    // }
    // public static void LogEvent(string eventName, string ParameterName, string ParameterValue){
    //     FirebaseAnalytics.LogEvent(eventName, ParameterName, ParameterValue);
    // }

    // /// <summary>
    // /// Thực thi hàm này khi biến 'ConstraintExclusive' chưa được gọi lần nào
    // /// </summary>
    // /// <param name="EventName">event</param>
    // /// <param name="Constraint">Nếu biến này đã được log rồi thì event sễ không thực thi</param>
    // public static void LogEventConstraint(string EventName, string ConstraintExclusive){
    //     if(Constraints.Contains(ConstraintExclusive))
    //         return;
    //     Constraints.Add(ConstraintExclusive);
    //     LogEvent(EventName);
    // }
    // public static void LogEventConstraint(string EventName, string ParameterName, string ParameterValue,string ConstraintExclusive){
    //     if(Constraints.Contains(ConstraintExclusive))
    //         return;
    //     Constraints.Add(ConstraintExclusive);
    //     LogEvent(EventName, ParameterName, ParameterValue);
    // }
}
