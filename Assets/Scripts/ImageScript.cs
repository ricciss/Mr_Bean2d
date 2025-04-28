using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageScript : MonoBehaviour
{
    public GameObject bean;
    public GameObject teddy;
    public GameObject car;
    public GameObject lady;
    public GameObject left;
    public GameObject right;

    public void ToogleBean(bool value)
    {
        bean.SetActive(value);
        left.GetComponent<Toggle>().interactable = value;
        right.GetComponent<Toggle>().interactable = value;
    }
    public void ToggleTeddy(bool value)
    {
        teddy.SetActive(value);
    }
    public void ToogleCar(bool value)
    {
        car.SetActive(value);
    }
    public void ToogleLady(bool value)
    {
        lady.SetActive(value);
    }
    public void ToLeft()
    {
        bean.transform.localScale = new Vector2(1, 1);

    }
    public void ToRight()
    {
        bean.transform.localScale = new Vector2(-1, 1);
    }

}
