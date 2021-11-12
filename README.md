# Pointer Shape
Examples of changing pointer shape and adding crosshair.

There are 3 default pointer shapes:
1. Default Cursor
2. Manipulation Cursor
3. Rotation Cursor

More pointers shapes can be added and used as shown [here](https://github.com/JioGlass-Dev/ExampleSnippets-PointerShape/blob/1d71d36e84aa91de92abd31568cfb5b41997e911/Assets/Scripts/PointerShapeManager.cs#L48).

## Scripts 

### `PointerShapeManager.cs`
Example of changing pointer shape (inbuilt and custom prefabs).</br>
- Finding pointer gameobject and CursorVisual gameobject.
```cs
GameObject PointerObject = FindObjectOfType<JMRAnimatedCursor>().transform;
CursorParent = FindObjectInChilds(PointerObject.gameObject, "CursorVisual").transform;
```

## How to use?
1. Download and unzip this project.
2. Open the project using Unity Hub.
3. Download and import the latest version of JMRSDK package.
4. Open and play the PointerShape scene from Assets/Scenes folder.
