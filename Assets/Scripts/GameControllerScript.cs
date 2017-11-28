using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControllerScript : MonoBehaviour {
    public ArrayList chosenValues = new ArrayList();

    public Button button0;
    public Button button1;
    public Button button2;

    public Canvas canvas;
    
void OnEnable() {
        button0.onClick.AddListener(delegate { addToArray(0); });
        button1.onClick.AddListener(delegate { addToArray(1); });
        button2.onClick.AddListener(delegate { addToArray(2); });
    }

    void addToArray(int i) {
        chosenValues.Add(i);
    }


    // Use this for initialization
    void Start () {
        InvokeRepeating("ShowUI", 5.0f, 6.0f);

    }

    void ShowUI() {
        canvas.gameObject.SetActive(true);
    }
	// Update is called once per frame
	void Update () {
        Debug.Log("Printing ArrayList");
        foreach(var value in chosenValues){
            Debug.Log(value);
        }
        Debug.Log("Done");
    }
}
