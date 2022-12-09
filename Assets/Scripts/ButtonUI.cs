using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using JetBrains.Annotations;
using UnityEngine.UIElements;

public class ButtonUI : MonoBehaviour
{
    public bool Button = false;


    // Start is called before the first frame update
    void Start()
    {
        Button = GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        if Input.GetButtonDown = true;
        {
            Button.color = new(Button.color.r = 0, Button.color.g = 0, Button.color.b = 0);
        }
    }
}
