using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NavigateManager : MonoBehaviour
{
    [SerializeField]
    RectTransform BackGround;

    UserManager UM;
    private void Start()
    {
        UM = GameObject.Find("UserManager").GetComponent<UserManager>();
    }
    public void OnMainClick()
    {
        BackGround.localPosition = new Vector2(0, 0);
    }
    public void OnApplyClick()
    {
        BackGround.localPosition = new Vector2(720, 1280);
    }
    public void OnQuestionClick()
    {
        BackGround.localPosition = new Vector2(0, 1280);
    }
    public void OnMyClick()
    {
        BackGround.localPosition = new Vector2(-720, 1280);
        Text t = GameObject.Find("Text (7)").GetComponent<Text>();
        t.text = UM.SVPoint.ToString();
    }
}
