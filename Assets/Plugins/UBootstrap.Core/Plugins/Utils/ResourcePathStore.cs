using UnityEngine;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using System;
using System.Linq;

#if UNITY_EDITOR
using UnityEditor;
#endif

namespace UBootstrap
{
    [System.Serializable]
    public class ResourcePathInfo
    {
        public string path;
        public string pathWithoutExtension;
        public string folderPath;
        public string resourcePath;
        public int guid;
    }

    [System.Serializable]
    public class ResourcePathStore : Setting<ResourcePathStore>
    {
        #if UNITY_EDITOR
        [MenuItem ("Settings/ResourcePathStore")]
        public static void Edit ()
        {
            Selection.activeObject = Instance;
        }
        #endif

        [SerializeField][HideInInspector]
        protected List<ResourcePathInfo> _resourcePathInfos;

        protected override void OnCreated ()
        {
            _resourcePathInfos = new List<ResourcePathInfo> ();
        }

        #if UNITY_EDITOR
        public void Populate ()
        {
            _resourcePathInfos.Clear ();

            var paths = AssetDatabase.GetAllAssetPaths ();
            ResourcePathInfo rpi;
            foreach (var path in paths) {
                if (!path.Contains ("Assets/") || !path.Contains ("/Resources/")) {
                    continue;
                }
                if (Directory.Exists (path)) {
                    continue;
                }

                var asset = AssetDatabase.LoadMainAssetAtPath (path);
                if (asset == null) {
                    continue;
                }
                rpi = new ResourcePathInfo ();
                rpi.path = path;
                rpi.folderPath = Path.GetDirectoryName (path);
                rpi.pathWithoutExtension = Path.Combine (rpi.folderPath, Path.GetFileNameWithoutExtension (path));
                rpi.resourcePath = _GetResourcePath (path);
                rpi.guid = asset.GetInstanceID ();

                _resourcePathInfos.Add (rpi);
            }
        }
        #endif

        protected static string _GetResourcePath (string originalPath)
        {
            originalPath = Path.Combine (Path.GetDirectoryName (originalPath), Path.GetFileNameWithoutExtension (originalPath));
            return originalPath.Substring (originalPath.IndexOf ("/Resources/") + 11);
        }

        protected ResourcePathInfo _GetResourcePathInfo (string path)
        {
            foreach (var rpi in _resourcePathInfos) {
                if (rpi.path.Equals (path) || rpi.pathWithoutExtension.Equals (path)) {
                    return rpi;
                }
            }
            return null;
        }

        protected List<ResourcePathInfo> _GetResourcePathInfos (string path, bool topLevelOnly = true)
        {
            path = Path.GetDirectoryName (path);
            var pathWithSep = path + Path.DirectorySeparatorChar;

            var result = new List<ResourcePathInfo> ();
            if (topLevelOnly) {
                foreach (var rpi in _resourcePathInfos) {
                    if (rpi.folderPath.Equals (path)) {
                        result.Add (rpi);
                    }
                }
            } else {
                foreach (var rpi in _resourcePathInfos) {
                    if (rpi.folderPath.Equals (path) || rpi.folderPath.Contains (pathWithSep)) {
                        result.Add (rpi);
                    }
                }
            }

            return result;
        }

        public int GetNumberOfAssets ()
        {
            return _resourcePathInfos.Count;
        }

        public UnityEngine.Object Load (string path, Type systemTypeInstance)
        {
            var rpi = _GetResourcePathInfo (path);
            if (rpi == null) {
                return null;
            }
            return Resources.Load (rpi.resourcePath, systemTypeInstance);
        }

        public T Load<T> (string path) where T : UnityEngine.Object
        {
            var rpi = _GetResourcePathInfo (path);
            if (rpi == null) {
                return null;
            }
            return Resources.Load <T> (rpi.resourcePath);
        }

        public UnityEngine.Object Load (string path)
        {
            var rpi = _GetResourcePathInfo (path);
            if (rpi == null) {
                return null;
            }
            return Resources.Load (rpi.resourcePath);
        }

        
        public T[] LoadAll<T> (string path, bool topLevelOnly = true) where T : UnityEngine.Object
        {
            var rpis = _GetResourcePathInfos (path, topLevelOnly);
            return rpis.Select (x => Resources.Load<T> (x.resourcePath)).Where (x => x != null).ToArray ();
        }

        public UnityEngine.Object[] LoadAll (string path, bool topLevelOnly = true)
        {
            var rpis = _GetResourcePathInfos (path, topLevelOnly);
            return rpis.Select (x => Resources.Load (x.resourcePath)).Where (x => x != null).ToArray ();
        }

        public UnityEngine.Object[] LoadAll (string path, Type systemTypeInstance, bool topLevelOnly = true)
        {
            var rpis = _GetResourcePathInfos (path, topLevelOnly);
            return rpis.Select (x => Resources.Load (x.resourcePath, systemTypeInstance)).Where (x => x != null).ToArray ();
        }
    }
}