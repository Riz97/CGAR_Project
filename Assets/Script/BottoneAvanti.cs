using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

using unityImage = UnityEngine.UI.Image;
public class BottoneAvanti : MonoBehaviour
{
    public unityImage image;
    public Sprite[] mySprite;
    public VirtualButtonBehaviour bottoneAvanti;

    public static int count = 0 ;

    // Start is called before the first frame update
    void Start()
    {
        bottoneAvanti.RegisterOnButtonPressed(OnButtonPressed);
        bottoneAvanti.RegisterOnButtonReleased(OnButtonReleased);
    }


    public void ChangeImageForward() {
        count++;
        image.sprite = mySprite[count];
    }


    public void OnButtonPressed(VirtualButtonBehaviour bottoneAvanti) {
        ChangeImageForward();
    }


    public void OnButtonReleased(VirtualButtonBehaviour vb) {

    }

    /*
    public void ChangeImageBackward()
    {
        count--;
        image.sprite = mySprite[count]; 
        
    }
    */



}
