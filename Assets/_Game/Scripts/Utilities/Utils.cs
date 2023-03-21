
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using System;
public static class Utils
{
    public static T ResourcesLoad<T>(string path) where T : UnityEngine.Object
    {
        return Resources.Load<T>(path);
    }
    public static void SetLayerRecursively(GameObject go, string layerName)
    {
        if (go == null) return;
        foreach (Transform trans in go.GetComponentsInChildren<Transform>(true))
        {
            trans.gameObject.layer = LayerMask.NameToLayer(layerName);
        }
    }

    public static void DestroyChildren(this Transform parent)
    {
        for (int i = 0; i < parent.childCount; i++)
        {
            if (parent.GetChild(i).name == "TMP")
                continue;
            GameObject.Destroy(parent.GetChild(i).gameObject);
        }
    }

    public static T ChangeAlpha<T>(this T g, float newAlpha) where T : Graphic
    {
        var color = g.color;
        color.a = newAlpha;
        g.color = color;
        return g;
    }
    public static Enum GetRandomEnumValue(this Type t)
    {
        return Enum.GetValues(t)          // get values from Type provided
            .OfType<Enum>()               // casts to Enum
            .OrderBy(e => Guid.NewGuid()) // mess with order of results
            .FirstOrDefault();            // take first item in result
    }
    public static T RandomEnumValue<T>()
    {
        var values = Enum.GetValues(typeof(T));
        int random = UnityEngine.Random.Range(0, values.Length);
        return (T)values.GetValue(random);
    }

    private static System.Random rng = new System.Random();
    public static void Shuffle<T>(this IList<T> list)
    {
        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            T value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
    }
    public static IList<T> Shuffle2<T>(this IList<T> ts)
        {
            var count = ts.Count;
            var last = count - 1;
            for (var i = 0; i < last; ++i)
            {
                var r = UnityEngine.Random.Range(i, count);
                var tmp = ts[i];
                ts[i] = ts[r];
                ts[r] = tmp;
            }
            return ts;
        }
    public static void Transfer2List<T>(this List<T> Sender, List<T> Receiver)
    {
        foreach (var item in Sender)
            Receiver.Add(item);
    }

    //
    // Summary:
    //     Return a random int within [minInclusive..maxExclusive) (Read Only).
    //
    // Parameters:
    //   min:
    //
    //   max:
    public static int RandomNumberExclusive(int minInclusive, int maxExclusive, params int[] ExcArr)
    {
        if (ExcArr.Length >= Mathf.Abs(minInclusive - maxExclusive))
            return -1;
        int randomNum = UnityEngine.Random.Range(minInclusive, maxExclusive);
        foreach (var item in ExcArr)
            if (item == randomNum)
                return RandomNumberExclusive(minInclusive, maxExclusive, ExcArr);
        return randomNum;
    }
    public static int RandomNumberExclusive(int minInclusive, int maxExclusive, List<int> ExcList)
    {
        if (ExcList.Count >= Mathf.Abs(minInclusive - maxExclusive))
            return -1;
        int randomNum = UnityEngine.Random.Range(minInclusive, maxExclusive);
        foreach (var item in ExcList)
            if (item == randomNum)
                return RandomNumberExclusive(minInclusive, maxExclusive, ExcList);
        return randomNum;
    }
}
