﻿using System.IO;
using System;
using UnityEngine;


#if UNITY_EDITOR
using UnityEditor;
#endif

namespace UBootstrap
{
    static public partial class FileSystemHelper
    {
        #if UNITY_EDITOR
        /// <summary>
        /// Makes a folder in Assets folder
        /// </summary>
        /// <param name="path">The path inside Assets</param>
        public static void MakeFolderInAssets (string path)
        {
            string[] folderNames = path.Split ('/');
            string currentPath = "Assets";
            for (int i = 0; i < folderNames.Length; i++) {
                string folderPath = Path.Combine (currentPath, folderNames [i]);
                if (!Directory.Exists (folderPath)) {
                    AssetDatabase.CreateFolder (currentPath, folderNames [i]);
                }
                currentPath = folderPath;
            }
        }

        public static void SaveToFileInAssets (string content, string path)
        {
            try {
                File.WriteAllText (Path.Combine (Application.dataPath, path), content);
                AssetDatabase.Refresh ();
            } catch (Exception e) {
                Debug.LogError ("An error occurred while saving file: " + e);
            }

        }
        #endif

        #if UNITY_EDITOR
        [MenuItem ("UBootstrap/Delete Device Cache")]
        public static void DeleteDeviceCache ()
        {
            DeleteAllFilesAndFoldersInFolder (Application.persistentDataPath);
            DeleteAllFilesAndFoldersInFolder (Application.temporaryCachePath);
        }
        #endif

        public static void DeleteAllFilesAndFoldersInFolder (string directoryPath)
        {
            string[] directories = Directory.GetDirectories (directoryPath);
            foreach (string path in directories) {
                try {
                    Directory.Delete (path, true);  
                } catch (Exception e) {
                    Debug.Log ("Cannot delete " + path + " [" + e.Message + "]");
                }
            }

            string[] filePaths = Directory.GetFiles (directoryPath);
            foreach (string path in filePaths) {
                try {
                    File.Delete (path);
                } catch (Exception e) {
                    Debug.Log ("Cannot delete " + path + " [" + e.Message + "]");
                }
            }
        }
    }


}
