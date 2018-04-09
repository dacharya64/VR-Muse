using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class GameControllerScript : MonoBehaviour {
    public ArrayList chosenValues = new ArrayList();

    public Button button0;
    public Button button1;
    public Button button2;

    public Canvas canvas;

    public float delay;
    
void OnEnable() {
        button0.onClick.AddListener(delegate { WriteToFile(0); });
        button1.onClick.AddListener(delegate { WriteToFile(1); });
        button2.onClick.AddListener(delegate { WriteToFile(2); });
    }

    void addToArray(int i) {
        chosenValues.Add(i);
    }


    // Use this for initialization
    void Start () {
        InvokeRepeating("ShowUI", delay, delay);
    }

    void ShowUI() {
        canvas.gameObject.SetActive(true);
    }

    void WriteToFile(int i) {
        string path = "Assets/data/test.txt";
        StreamWriter writer = new StreamWriter(path, true);
        writer.WriteLine(System.DateTime.UtcNow + ", " + i);
        writer.Close();
    }
	// Update is called once per frame
	void Update () {
        
    }
}
