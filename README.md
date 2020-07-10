# UniSceneHierarchyInternal

SceneHierarchy クラスの internal な機能にアクセスできる機能

## 使用例

```cs
using Kogane;
using UnityEditor;

public class Example
{
    [MenuItem( "Tools/Hoge" )]
    private static void Hoge()
    {
        // Hierarchy で選択中のゲームオブジェクトのリネームモードに入る
        SceneHierarchyInternal.RenameGO();
    }
}
```

![9](https://user-images.githubusercontent.com/6134875/87103642-99d25900-c290-11ea-8f34-9a05d13188a7.gif)
