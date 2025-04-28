using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetTextScript : MonoBehaviour
{
    int number = 0;
    string text;
    public string[] textArray = {"Sveiks ", "Jauku dienu ", "Prieks Tevi redzēt ", "Uz tikšanos ","Lai Tev labi iet "};
    int randText;
    public GameObject inputField;
    public GameObject textField;
    public void showText()
    {
        randText = Random.Range(0, textArray.Length);
        text = inputField.GetComponent<Text>().text;
        textField.GetComponent<Text>().text = textArray[randText] + text.ToUpper()+"!";
    }
    void Start()
    {
        Debug.LogWarning("Startēts!");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Skaitlis: " + number);
        number++;
    }
}
