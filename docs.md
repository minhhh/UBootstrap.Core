### Setting and PathSetting

`Setting<T>` is the base class for all global setting `ScriptableObject`. All the `ScriptableObject` will be stored in a single folder that can be configured for each project.

`PathSetting` is the `ScriptableObject` that contains the path of the folder that all other setting objects will be stored in. The `PathSetting` object itself is hardcoded to be stored in the root of `Assets/Resources` folder.

### FileSystemHelper
This is a helper with useful functions to deal with file system

### ReflectionHelper
This is a helper with useful functions to deal with reflection
