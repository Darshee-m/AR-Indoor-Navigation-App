using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetSet : MonoBehaviour
{

    public InputField text1;
    public Text name1;
    public bool createLabel = false;

    public void setget()
    {
        createLabel = true;
        name1.text = " " + text1.text;
        createLabel = false;
    }

}
