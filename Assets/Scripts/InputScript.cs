using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InputScript : MonoBehaviour {

    private string teksts;
    private string teksts2;
    public GameObject ievadesLauks;
    public GameObject ievadesLauks2;
    public GameObject tekstaAttelosana;
    
    
    public void UzglabatTekstu()
    {
       
        teksts = ievadesLauks.GetComponent<InputField>().text;
        teksts2 = ievadesLauks2.GetComponent<InputField>().text;
        tekstaAttelosana.GetComponent<Text>().text = "Mani sauc " + teksts.ToUpper() + " un man ir " + teksts2 + " gadi";
    }
}
