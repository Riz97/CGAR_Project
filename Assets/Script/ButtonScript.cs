using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

using unityImage = UnityEngine.UI.Image;

public class ButtonScript : MonoBehaviour
{
    public unityImage image;
    public Sprite mySprite;
    public VirtualButtonBehaviour Vb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeImage() {
        image.sprite = mySprite;
        Debug.Log("Sprite cambiato");
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb) {
        Debug.Log("Bottone premuto");
        ChangeImage();
    }
}
