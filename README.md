# Kogane Scene Hierarchy Internal

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

![icon459](https://user-images.githubusercontent.com/6134875/187427904-a2cc9e9e-2f6a-4017-9f5f-5b2be6eded9c.gif)

```csharp
using Kogane;
using UnityEditor;

public class Example
{
    [MenuItem( "Tools/Hoge" )]
    private static void Hoge()
    {
        SceneHierarchyInternal.SetSearchFilter
        (
            searchFilter: "ピカチュウ",
            searchMode: SearchableEditorWindow.SearchMode.All,
            setAll: true
        );
    }
}
```

![icon458](https://user-images.githubusercontent.com/6134875/187427919-13aadd09-5836-4faf-9ed3-81d388639fac.gif)
