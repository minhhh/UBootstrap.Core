# UBootstrap.Core

This is a core package of the UBootstrap series of libraries used for easily bootstraping a new Unity project.

## Setup

1. Clone this repo and use it as a base for your new project
2. Install `npm` and `yarn`
3. Update `package.json` to include UBootstrap.Core like so

    ```
        "ubootstrap-core": "ssh://github.com/minhhh/UBoostrap.Core.git#v0.0.1"
    ```
4. Run `npm run unity` and wait for it to install all necessary packages


To open this project on its own, run `rm -fr node_modules && DIR=`pwd` yarn install --flat --verbose` to install `devDependencies` as well.

## Documentation

All the classes are documented [here](https://github.com/minhhh/UBootstrap.Core/blob/master/docs.md)

## Changelog

**0.0.14**

* Convert helpers to partial classes for easier extension

**0.0.13**

* Improve VectorHelper

**0.0.12**

* Improve EnumHelper
* Add ScriptExecutionOrder

**0.0.11**

* Improve GameObjectHelper

**0.0.10**

* Add `VectorHelper`

**0.0.9**

* Improve `ConstantGenerator`. Add `ListHelper`, `MathHelper`

**0.0.8**

* Add `ConstantGenerator`

**0.0.7**

* Add `MissingScriptFinder`

**0.0.6**

* Add `PlayerPrefsEditor`, `AssetReferencerFinder`

**0.0.5**

* Add `MeshVisualizerWindow`, `SceneViewWindow`

**0.0.4**

* Add `Consolation`, `MeshSaver`

**0.0.3**

* Add `EnumHelper`, `GameObjectHelper`, `GCFreeDictionary`, `LimitedSizeStack`, `GameObjectExtensions`

**0.0.2**

* Fix `Setting` infinite recursion issue

**0.0.1**

* Add `Setting`, `PathSetting`, `FileSystemHelper`, `ReflectionHelper`

<br/>
