using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Core.Pool;

public class CreateController : MonoSingleton<CreateController>
{
    public List<ObjectPoolItem> ListItemPool;
    protected override void Awake()
    {
        base.Awake();
        Preload();
    }
    public void Preload(){
        foreach (var item in ListItemPool)
            if(item.poolAmount > 0)
                SmartPool.Instance.Preload(item.poolObject, item.poolAmount);
    }
    public GameObject GetPoolObject(string _name, bool active = false){
        ObjectPoolItem OPI = ListItemPool.Find(x => x._name == _name);
        if(OPI != null)
            return SmartPool.Instance.GetPoolObject(OPI.poolObject, active);
        return null;
    }

    [System.Serializable]
    public class ObjectPoolItem
    {
        public string _name;
        public int poolAmount;
        public GameObject poolObject;
    }
}
