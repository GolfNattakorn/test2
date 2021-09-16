using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Registration : MonoBehaviour
{
    //Registration
    public InputField yourName;
    public Text checkName;
    public Image yourImage;
    public Sprite[] yourImages;
    public GameObject selectImagePanel;

    private string yourname;
    private int yourimage;

    
    // Start is called before the first frame update
    void Start()
    {
        yourname = "";
        yourimage = 0;
        selectImagePanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        CheckImage();
        
    }

    public void Next()
    {
        if(yourName.text != "")
        {
            checkName.text = "*Next";
            checkName.color = Color.green;
            yourname = yourName.text;
            Debug.Log("O");
        }
        else
        {
            checkName.text = "*Please enter your name";
            checkName.color = Color.red;
            yourname = "";
            Debug.Log("X");
        }
    }

    public void OpenSelectImagePanel()
    {
        selectImagePanel.SetActive(true);
    }

    public void SelectImage1()
    {
        yourimage = 0 ;
        
        selectImagePanel.SetActive(false);
        Debug.Log("0");
    }

    public void SelectImage2()
    {
        yourimage = 1;
        
        selectImagePanel.SetActive(false);
        Debug.Log("1");
    }
    public void SelectImage3()
    {
        yourimage = 2;
        
        selectImagePanel.SetActive(false);
        Debug.Log("2");
    }

    private void CheckImage()
    {
        switch (yourimage)
        {
            //case 0:
            //    yourImages[0].enabled = true;
            //    yourImages[1].enabled = false;
            //    yourImages[2].enabled = false;
            //    break;
            //case 1:
            //    yourImages[0].enabled = false;
            //    yourImages[1].enabled = true;
            //    yourImages[2].enabled = false;
            //    break;
            //case 2:
            //    yourImages[0].enabled = false;
            //    yourImages[1].enabled = false;
            //    yourImages[2].enabled = true;
            //    break;

            case 0:
                yourImage.sprite = yourImages[0];
                break;
            case 1:
                yourImage.sprite = yourImages[1];
                break;
            case 2:
                yourImage.sprite = yourImages[2];
                break;
        }

    }
    
}
