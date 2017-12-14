using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseWindow : MonoBehaviour {


    public  virtual void Awake()
    {
        //base.Awake();
        InitWidget();
        AddEventListener();
    }
    public virtual void Start()
    {

    }

    public virtual void OnDisnable()
    {

    }

    public void Hide()
    {
        if (this.gameObject.activeSelf) this.gameObject.SetActive(false);
    }

    public void Show()
    {
        if (!this.gameObject.activeSelf) this.gameObject.SetActive(true);
    }

    public abstract void InitWidget();

    public abstract void AddEventListener();


    public abstract void RemoveEventListener();
   

    void onDisnable()
    {
        RemoveEventListener();
    }
    
}
