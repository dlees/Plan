using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class FileListProvider : MonoBehaviour {

    public StringSetReference stringSetOutput;
    public StringReference stringToPopulate;

	// Use this for initialization
    void Start () {
         DirectoryInfo dir = new DirectoryInfo("C:\\Users\\Dan\\Music\\Kim\\KW - KW");
         FileInfo[] info = dir.GetFiles("*.mp3");

         foreach (FileInfo f in info) {
             stringSetOutput.Add(f.FullName); 
         }

         stringToPopulate.setValue("file:///" + info[0].FullName);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
