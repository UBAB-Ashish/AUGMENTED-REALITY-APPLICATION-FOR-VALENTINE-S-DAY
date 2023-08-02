using UnityEngine;
using UnityEngine.UI;

public class buttonclick : MonoBehaviour
{
    public GameObject valentine;
    public GameObject rose;
    public GameObject heart;
    public GameObject heart_break;
    public Button yes;
    public Button no;
    public Button back;
    //public Button exit;
    //[SerializeField] private Button btn;
    //[SerializeField] private Button btnn;
    //[SerializeField] private Button btnnn;

    public void Start()
    {
        Button btn= yes.GetComponent<Button>();
        btn.onClick.AddListener(OnYesClick);

        Button btnn = no.GetComponent<Button>();
        btnn.onClick.AddListener(OnNoClick);

        Button btnnn = back.GetComponent<Button>();
        btnnn.onClick.AddListener(OnBackClick);

       // Button btnnnn = exit.GetComponent<Button>();
       // btnnnn.onClick.AddListener(OnexitClick);
        
        // set initial states
        valentine.SetActive(true);
        rose.SetActive(false);
        heart.SetActive(false);
        heart_break.SetActive(false);
    }


    public void OnYesClick()
    {
        if (valentine.activeSelf)
        {
            valentine.SetActive(false);
            rose.SetActive(true);
            heart.SetActive(false);
            heart_break.SetActive(false);
        }
        else if (rose.activeSelf)
        {
            valentine.SetActive(false);
            rose.SetActive(false);
            heart.SetActive(true);
            heart_break.SetActive(false);
        }
    }

    public void OnNoClick()
    {
        if (valentine.activeSelf)
        {
            valentine.SetActive(false);
            rose.SetActive(false);
            heart.SetActive(false);
            heart_break.SetActive(true);
        }
        else if (rose.activeSelf)
        {
            valentine.SetActive(false);
            rose.SetActive(false);
            heart.SetActive(false);
            heart_break.SetActive(true);
        }
    }

    public void OnBackClick()
    {
        valentine.SetActive(true);
        rose.SetActive(false);
        heart.SetActive(false);
        heart_break.SetActive(false);
    }

    //public void OnexitClick()
    //
        //if (Input.GetKey("exit"))
        //{
            //Application.Quit();
        //}
    //}
}

