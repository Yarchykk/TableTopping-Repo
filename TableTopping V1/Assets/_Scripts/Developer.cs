using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using Unity.VisualScripting.Antlr3.Runtime.Misc;


//This script is for creating developer shortcuts
//https://youtu.be/za_pBB80Nt8?t=183 link is timestamped
//create static methods and decorate them with MenuItem attribute 
public class Developer
{
    //Developer is the root level object menu name (found in the section with File, edit, window, help)
    //Clear Saves is the name of the item in the Developer object options menu
    [MenuItem("Developer/Clear Saves")]
    public static void ClearSaves()
    {
        PlayerPrefs.DeleteAll();
        //Clear serialized saves

        Debug.Log("All saves have been cleared");
    }

    [MenuItem("Developer/Poggers")]
    public static void Poggers()
    {
        Debug.Log("Now thats Pog Champ!!!");
    }


}
