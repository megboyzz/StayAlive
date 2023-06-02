using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogWindow : MonoBehaviour
{
    private bool showDialog = false;
    private string dialogText = "This is a dialog window.";

    void OnGUI()
    {
        if (showDialog)
        {
            GUIStyle dialogStyle = new GUIStyle(GUI.skin.box);
            dialogStyle.wordWrap = true;

            GUILayout.BeginArea(new Rect(20, 20, 200, 100), dialogStyle);
            GUILayout.Label(dialogText);
            GUILayout.Space(10);

            if (GUILayout.Button("Close"))
            {
                showDialog = false;
            }

            GUILayout.EndArea();
        }
    }

    public void OpenDialog(string text)
    {
        dialogText = text;
        showDialog = true;
    }
}