using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MVCEvent  {

    protected static MVCEvent _instancle;
    Dictionary<object, List< System.Action<object>>> mDiction;
    public static MVCEvent Instancle
    {
        get
        {
            if (_instancle == null) _instancle = new MVCEvent();
            return _instancle;
        }
    }

    public MVCEvent()
    {
        if (mDiction == null) mDiction = new Dictionary<object,List<System.Action<object>>>();
    }

    public void addEventListener(object key, System.Action<object> handle)
    {
        if (mDiction.ContainsKey(key))
        {
            if(mDiction[key]==null) mDiction[key]= new List<System.Action<object>>(){handle};
            else{
                mDiction[key].Add(handle);
            }
        }
        else
        {
            mDiction.Add(key, new List<System.Action<object>>(){handle});
        }
    }

    public void removeEventListener(object key)
    {
        if (mDiction.ContainsKey(key)) mDiction.Remove(key);
    }

    public void removeEventListener(object key, System.Action<object> handle)
    {
        if(mDiction.ContainsKey(key) && mDiction[key].Find(x=>x==handle)!=null)
        {
            mDiction[key].Remove(handle);
        }
    }

    public void dispathEvent(object key,object handle)
    {

        if (mDiction.ContainsKey(key))
        {
            foreach(System.Action<object> ob in mDiction[key])
            {
                ob(handle);
            }
        }
    }

}
