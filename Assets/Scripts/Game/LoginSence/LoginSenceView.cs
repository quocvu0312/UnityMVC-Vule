using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoginSenceView : BaseWindow {

    public override void InitWidget()
    {
       //Debug.Log

        Debug.Log("cai loz");
    }

    public override void Awake()
    {
        base.Awake();

    }

    public override void AddEventListener()
    {
        
        MVCEvent.Instancle.addEventListener(LoginConst.LoginView,loginview);
        MVCEvent.Instancle.addEventListener(LoginConst.LoginView, (vl) =>
        {
            Hide();
        });
    }
    public override void RemoveEventListener()
    {
        //throw new System.NotImplementedException();
    }

    public void loginview(object data)
    {
        Debug.Log(data);
    }
}
