using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;
using static BottoneAvanti;

using unityImage = UnityEngine.UI.Image;
public class BottoneIndietro : MonoBehaviour
{
    public unityImage image;
    public Sprite[] mySprite;
    public VirtualButtonBehaviour bottoneIndietro;


    // Start is called before the first frame update
    void Start()
    {
        bottoneIndietro.RegisterOnButtonPressed(OnButtonPressed);
        bottoneIndietro.RegisterOnButtonReleased(OnButtonReleased);
    }


    /*
    public void ChangeImageForward() {

        BottoneAvanti.count++;
        image.sprite = mySprite[count];
         
        
        

    }*/

     public void ChangeImageBackward()
    {
        BottoneAvanti.count--;
        image.sprite = mySprite[count]; 
        
    }

    public void OnButtonPressed(VirtualButtonBehaviour bottoneIndietro) {
        ChangeImageBackward();
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb) {

    }
    



}
