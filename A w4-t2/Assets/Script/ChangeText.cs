using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour
{

    private Text mytext;

    void Start()
    {
        mytext = GetComponent<Text>();
        mytext.enabled = false;
        gameObject.SetActive(false);
        
    }
    public void ChangeMyText(string str)
    {
        mytext.text = str;
    }
}
//custom editor
[CustomEditor(typeof(ChangeText))]
public class ChangeTextEditor : Editor
{

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        var t = target as ChangeText;
        if(GUILayout.Button("Change Text"))
        {
            t.ChangeMyText("Hello");
        }
    }
}


