using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ApplyManager : MonoBehaviour
{
    [SerializeField]
    RectTransform BackGround;
    [SerializeField]
    public string Applycontent;
    [SerializeField]
    public GameObject g;
    [SerializeField]
    GameObject content;
    [SerializeField]
    GameObject Panel;
    [SerializeField]
    GameObject Panel2;
    List<string> list = new List<string>();

    public void OnContentClick()
    {
        Panel.SetActive(true);
        Panel.transform.GetChild(0).GetComponent<RawImage>().texture = EventSystem.current.currentSelectedGameObject.GetComponent<RawImage>().texture;
        Applycontent = EventSystem.current.currentSelectedGameObject.GetComponent<RawImage>().texture.name;
        g = EventSystem.current.currentSelectedGameObject;
    }
    public void OnGoApplyClick()
    {
        Panel2.SetActive(false);
        BackGround.localPosition = new Vector2(720, 1280);
    }
    public void OnOkClick()
    {
        Panel2.SetActive(false);
    }
    public void OnCancelClick()
    {
        Panel.SetActive(false);
    }
    public void OnApplyClick()
    {
        if (list.Contains(Applycontent))
        {
            Panel.SetActive(false);
            Panel2.SetActive(true);
        }
        else
        {
            list.Add(Applycontent);
            var obj = Instantiate(g);
            obj.transform.parent = content.transform;
            obj.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
            Panel.SetActive(false);
        }
    }
}
