using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class DotweenExample : MonoBehaviour
{
    protected Button button;
    [SerializeField]
    private bool IsEnable = true;
    public GameObject Panel;


    // Start is called before the first frame update
    void Start()
    {

        button = GetComponent<Button>();
        button.onClick.AddListener(OnClick);
    }
    void OnClick()
    {
        if (IsEnable)
        {
            var sequece = DOTween.Sequence();
            sequece.Append(transform.DOScale(new Vector3(0.5f, 0.5f, 0.5f), 0.5f));
            sequece.Append(transform.DOScale(new Vector3(1, 1, 1), 0.75f));
            Panel.SetActive(true);
            IsEnable = false;
        }
        else
        {
            transform.DOShakePosition(1f, 10f);
            IsEnable = true;
        }

    }
    void OnClicks()
    {
        if (IsEnable == false)
        {
            transform.DOShakePosition(1f, 10f);
        }
    }

}
