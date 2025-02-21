using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
 //-Peremenaia- nushen dlia hranenie danih i shtobi obrashatsa k etim danim po imeni peremenih
    //2-Tipi Danih- nushen dlia abaznochenie kakoi vid danih hranitsa v peremenie
    //3-Modificatori Dostupa - Est u peremenih, nushni dlia oboznachenia dostupnosti peremenie za pridelami scripta
    //4-Imia pereminih - nushen dlia obrshenie pereminih po imeni 
    //5-Operator "=" ravno - nushen dlia obaznochenie prisvaivania danih toest Znachenie, vot eto operatsia nazivaetsa - inicializatciya
    //6-Znachenie eto danie kotorie presvaeiutca k peremenie, toest hraniatsa v peremenie

    public float A = 15.4f;//Tip danih int - oboznachaiet celie chisla
    public float B = 10.5f;//Tip danih float - oboznachaiet drobnie chisla, vashno bukva posle cifri - 1.5f
    public string myText = "Hello, World! 12-34,-@$&*(-+)";//Tip danih string - oboznachaiet luiboi text, vashno kavichki - "My name is Grisha, i'm 12 years old"
    private void Start()
    {
        float sum = A + B;
        Debug.Log(sum);      
    
    }
    
}
