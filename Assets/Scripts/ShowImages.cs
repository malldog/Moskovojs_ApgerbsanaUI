using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShowImages : MonoBehaviour {
    public GameObject shirtIMG;
    public GameObject shirt2IMG;
    public GameObject pantsIMG;
    public GameObject pants2IMG;
    public GameObject hatIMG;
    public GameObject accesorieIMG;
    public GameObject accesorie2IMG;
    public GameObject shoesIMG;
    public GameObject shoes2IMG;
    public GameObject toggleBikses;
    public GameObject toggleKrekli;
    public GameObject toggleApavi;
    public GameObject toggleCepures;
    public GameObject toggleAmuleti;
public GameObject scrollView;
public GameObject scrollView2;

    public GameObject pants3IMG;
    public GameObject pants4IMG;
    public GameObject pants5IMG;
    public GameObject shirt3IMG;
    public GameObject shirt4IMG;
    public GameObject shirt5IMG;
    public GameObject bagIMG;
    public GameObject shoes3IMG;
    public GameObject dressIMG;
    public GameObject toggleBikses2;
    public GameObject toggleKrekli2;
    public GameObject toggleApavi2;
    public GameObject toggleCepures2;
    public GameObject toggleAmuleti2;

    public GameObject cilvecins;
    public Sprite[] cilvecini;
   
    public void kreklaAttelosana(bool vertiba) {
        shirtIMG.SetActive(vertiba);
        shirt2IMG.SetActive(vertiba);
    }
    public void biksuAttelosana(bool vertiba)
    {
        
        pantsIMG.SetActive(vertiba);
        pants2IMG.SetActive(vertiba);
    }
    public void cepuresAttelosana(bool vertiba)
    {
        hatIMG.SetActive(vertiba);
    }
    public void amuletaAttelosana(bool vertiba)
    {
        accesorieIMG.SetActive(vertiba);
        accesorie2IMG.SetActive(vertiba);
    }
    public void kurpjuAttelosana(bool vertiba)
    {
        shoesIMG.SetActive(vertiba);
        shoes2IMG.SetActive(vertiba);
    }

    public void kreklaAttelosana2(bool vertiba) {
        shirt3IMG.SetActive(vertiba);
        shirt4IMG.SetActive(vertiba);
        shirt5IMG.SetActive(vertiba);
    }
    public void biksuAttelosana2(bool vertiba)
    {
        pants3IMG.SetActive(vertiba);
        pants4IMG.SetActive(vertiba);
        pants5IMG.SetActive(vertiba);
    }
    public void kleitaAttelosana(bool vertiba)
    {
        dressIMG.SetActive(vertiba);
    }
    public void amuletaAttelosana2(bool vertiba)
    {
        bagIMG.SetActive(vertiba);
    }
    public void kurpjuAttelosana2(bool vertiba)
    {
        shoes3IMG.SetActive(vertiba);
    }

    public void cilvecinaParadisana(int sk) {
        if (sk == 0){
            cilvecins.GetComponent<Image>().sprite = cilvecini[0];
            scrollView.SetActive(true);
            scrollView2.SetActive(false);
            toggleBikses.SetActive(true);
            toggleKrekli.SetActive(true);
            toggleApavi.SetActive(true);
            toggleCepures.SetActive(true);
            toggleAmuleti.SetActive(true);
shirtIMG.SetActive(false);
        shirt2IMG.SetActive(false);
        pantsIMG.SetActive(false);
        pants2IMG.SetActive(false);
        hatIMG.SetActive(false);
        accesorieIMG.SetActive(false);
        accesorie2IMG.SetActive(false);
        shoesIMG.SetActive(false);
        shoes2IMG.SetActive(false);
            toggleBikses2.SetActive(false);
            toggleKrekli2.SetActive(false);
            toggleApavi2.SetActive(false);
            toggleCepures2.SetActive(false);
            toggleAmuleti2.SetActive(false);
            shirt3IMG.SetActive(false);
        shirt4IMG.SetActive(false);
        shirt5IMG.SetActive(false);
        pants3IMG.SetActive(false);
        pants4IMG.SetActive(false);
        pants5IMG.SetActive(false);
        dressIMG.SetActive(false);
        bagIMG.SetActive(false);
        shoes3IMG.SetActive(false);


        }else if (sk == 1){

            cilvecins.GetComponent<Image>().sprite = cilvecini[1];
            scrollView.SetActive(false);
            scrollView2.SetActive(true);
            toggleBikses.SetActive(false);
            toggleKrekli.SetActive(false);
            toggleApavi.SetActive(false);
            toggleCepures.SetActive(false);
            toggleAmuleti.SetActive(false);
shirtIMG.SetActive(false);
        shirt2IMG.SetActive(false);
        pantsIMG.SetActive(false);
        pants2IMG.SetActive(false);
        hatIMG.SetActive(false);
        accesorieIMG.SetActive(false);
        accesorie2IMG.SetActive(false);
        shoesIMG.SetActive(false);
        shoes2IMG.SetActive(false);
            toggleBikses2.SetActive(true);
            toggleKrekli2.SetActive(true);
            toggleApavi2.SetActive(true);
            toggleCepures2.SetActive(true);
            toggleAmuleti2.SetActive(true);
            shirt3IMG.SetActive(false);
        shirt4IMG.SetActive(false);
        shirt5IMG.SetActive(false);
        pants3IMG.SetActive(false);
        pants4IMG.SetActive(false);
        pants5IMG.SetActive(false);
        dressIMG.SetActive(false);
        bagIMG.SetActive(false);
        shoes3IMG.SetActive(false);
        }else{
            Debug.Log("nav piesaistits attels");}
    }
}
