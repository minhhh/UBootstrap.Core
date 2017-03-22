### Setting and PathSetting

`Setting<T>` is the base class for all global setting `ScriptableObject`. All the `ScriptableObject` will be stored in a single folder that can be configured for each project.

`PathSetting` is the `ScriptableObject` that contains the path of the folder that all other setting objects will be stored in. The `PathSetting` object itself is hardcoded to be stored in the root of `Assets/Resources` folder.

### FileSystemHelper
This is a helper with useful functions to deal with file system

### ReflectionHelper
This is a helper with useful functions to deal with reflection

### Consolation
This is a `MonoBehaviour` which can be attached to any scene object. It will allow opening a custom console log using backtick ``` in PC and shaking in mobile. It is suggested to wrap it in a Singleton in your game, which will read configuration parameters from your game settings, instead of making it a prefab and set the prefab parameters.

### MeshSaver
This is an Editor script which will allow you to save any mesh using the context menu of the `MeshFilter` component.

### MeshVisualizerWindow
Visualize Mesh in Scene view

### SceneViewWindow
A simple Editor window to quickly switch between build scenes

### PlayerPrefsEditor
A simple Editor window to delete PlayerPrefs

### AssetReferencerFinder
Quickly find references to an asset
