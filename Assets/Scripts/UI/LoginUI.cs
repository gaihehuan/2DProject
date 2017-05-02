using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginUI : UIControl {
    Button Login;
    Button Quit;
    Button Set;
	// Use this for initialization
	void Start ()
    {
        Login = GameObject.Find("Login").GetComponent<Button>();
        Quit = GameObject.Find("Quit").GetComponent<Button>();
        Set = GameObject.Find("Set").GetComponent<Button>();
        EventTriggerListener.Get(Login.gameObject).onClick = OnClickConfirm;
        EventTriggerListener.Get(Quit.gameObject).onClick = OnClickCancel;
        EventTriggerListener.Get(Set.gameObject).onClick = OnClickSet;

	}

    public override void OnClickConfirm(GameObject go)
    {
        base.OnClickConfirm(go);
        Application.LoadLevelAsync(1);

    }
    public override void OnClickCancel(GameObject go)
    {
        base.OnClickCancel(go);
        Application.Quit();

    }
    public override void OnClickSet(GameObject go)
    {
        base.OnClickSet(go);
        //设置相关音乐选项

    }
}
