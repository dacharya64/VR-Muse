using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class GameControllerScript_relaxing : MonoBehaviour {
    public ArrayList chosenValues = new ArrayList();

    public Button button0;
    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;

    public Canvas canvas;

    public float delay;
    
void OnEnable() {
        button0.onClick.AddListener(delegate { WriteToFile(0); });
        button1.onClick.AddListener(delegate { WriteToFile(1); });
        button2.onClick.AddListener(delegate { WriteToFile(2); });
        button3.onClick.AddListener(delegate { WriteToFile(3); });
        button4.onClick.AddListener(delegate { WriteToFile(2); });
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
        string path = "Assets/data/UserX.txt";
        StreamWriter writer = new StreamWriter(path, true);
        writer.WriteLine(System.DateTime.UtcNow + ", Relaxing, " + i);
        writer.Close();
    }
	// Update is called once per frame
	void Update () {
        
    }
}
