using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShowImages : MonoBehaviour {
    public GameObject joeBiden;
    public GameObject obama;
    public GameObject obamna;
    public GameObject shirtIMG;
    public GameObject shirt2IMG;
    public GameObject pantsIMG;
    public GameObject pants2IMG;
    public GameObject hatIMG;
    public GameObject spriteIMG;

    public void joeAttelosana(bool vertiba) {
        joeBiden.SetActive(vertiba);
        obama.SetActive(false);
        obamna.SetActive(false);
        
    }
    public void obamaAttelosana(bool vertiba)
    {
        obama.SetActive(vertiba);
        joeBiden.SetActive(false);
        obamna.SetActive(false);
     
    }
    public void obamnaAttelosana(bool vertiba) {
        obamna.SetActive(vertiba);
        obama.SetActive(false);
        joeBiden.SetActive(false);
    }
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
        spriteIMG.SetActive(vertiba);
    }
}
