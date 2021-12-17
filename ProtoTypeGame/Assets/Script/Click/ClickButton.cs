using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickButton : MonoBehaviour
{
    public GameObject MoveButton;

    private void Start()
    {
        MoveButton.SetActive(false);
    }

    private void OnMouseDown()
    {
        MoveButton.SetActive(true);
    }
}
