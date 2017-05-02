using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIControl : MonoBehaviour
{

    public virtual void OnClickConfirm(GameObject go)
    {
        Debug.Log("Test OnClickConfirmBase");
    }
    public virtual void OnClickCancel(GameObject go)
    {
        Debug.Log("Test OnClickCancelBase");
    }
    public virtual void OnClickSet(GameObject go)
    {
        Debug.Log("Test OnClickSet");
    }

}
