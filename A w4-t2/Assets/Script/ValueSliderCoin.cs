using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class ValueSliderCoin : MonoBehaviour
{
    private Slider slider;
    private Text text;
    [SerializeField] private int ValueBegin;
    [SerializeField] private int ValueEnd;
    int valueslider;
    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponentInChildren<Slider>();
        text = transform.GetChild(0).GetComponent<Text>();
        int value = Random.Range(ValueBegin,ValueEnd);
        var s = DOTween.Sequence();
        s.Append(slider.DOValue(value, 2f));
        s.Join(text.DOText(value.ToString(), 2f, false, ScrambleMode.Numerals, "0123456789"));
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
