using UnityEngine;
using UnityEditor;
using System.IO;

public class HandleTextFile: MonoBehaviour
{
    private string index;
    public string readTextFile(string file_path)
    {
        //var file = Resources.Load(file_path) as TextAsset;


        //if(file.text.Trim().Equals("".Trim()))
        //{
        //    return null;
        //}

        //return file.text;
        if (!File.Exists(file_path))
        {
            File.Create(file_path).Dispose();
        }

        StreamReader inp_stm = new StreamReader(file_path);
        while (!inp_stm.EndOfStream)
        {
            string inp_ln = inp_stm.ReadLine();
            index = inp_ln;
            // Do Something with the input. 
        }

        inp_stm.Close();

        return index;

    }

    public void writeTextFile(string file_path, string value)
    {
        Debug.Log(value);
        StreamWriter writer = new StreamWriter(file_path, true);
        Debug.Log(writer);
        writer.WriteLine(value);
        writer.Close();
    }

}
