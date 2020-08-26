using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class UserManager : DontDestroy<UserManager>
{
    [SerializeField]
    public int SVPoint;

    protected override void OnStart()
    {
        base.OnStart();
        SVPoint = 9000;
    }
    

}
