using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SizeChanger : MonoBehaviour
{
    public GameObject garumaSlaideris;
    public GameObject platumaSlaideris;
    public GameObject attels;
    public void mainitPlatumu()
    {
        float pasreizejaVertiba = platumaSlaideris.GetComponent<Slider>().value;
        attels.transform.localScale = new Vector2(1f * pasreizejaVertiba, garumaSlaideris.GetComponent<Slider>().value);
    }
    public void mainitGarumu()
    {
        float pasreizejaVertiba = garumaSlaideris.GetComponent<Slider>().value;
        attels.transform.localScale = new Vector2(platumaSlaideris.GetComponent<Slider>().value, 1f * pasreizejaVertiba);
    }
}
