using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitySingleton<T> : MonoBehaviour where T: Component {


    private static T _insstance;
    public static T Instance
    {
        get
        {
            if(_insstance==null)
            {
                _insstance = FindObjectOfType(typeof(T)) as T;
                if(_insstance==null)
                {
                    GameObject obj= new GameObject();
                    obj.hideFlags= HideFlags.HideAndDontSave;
                    _insstance= (T)obj.AddComponent(typeof(T));
                }
            }
            return _insstance;
        }
    }

    public virtual void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        if(_insstance==null)
        {
            _insstance = this as T;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
