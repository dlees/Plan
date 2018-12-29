using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class FileListProvider : MonoBehaviour {

    public StringReference directoryPath = new StringReference("C:\\Users\\Dan\\Music\\Kim\\KW - KW");

    public StringSetReference stringSetOutput;

    void Start() {
        loadDirectory();
    }

    public void loadDirectory() {
        stringSetOutput.Clear();
        DirectoryInfo dir = new DirectoryInfo(directoryPath.Value);

        DirectoryInfo[] dinfo = dir.GetDirectories("*");
        foreach (DirectoryInfo f in dinfo) {
            stringSetOutput.Add(f.FullName);
        }

        FileInfo[] info = dir.GetFiles("*.mp3");
         foreach (FileInfo f in info) {
             stringSetOutput.Add(f.FullName); 
         }
	}
}
