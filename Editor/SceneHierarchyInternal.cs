using System.Reflection;
using UnityEditor;

namespace Kogane
{
	public static class SceneHierarchyInternal
	{
		public static void RenameGO()
		{
			var assembly                 = typeof( EditorWindow ).Assembly;
			var sceneHierarchyWindowType = assembly.GetType( "UnityEditor.SceneHierarchyWindow" );
			var sceneHierarchyType       = assembly.GetType( "UnityEditor.SceneHierarchy" );
			var sceneHierarchyField      = sceneHierarchyWindowType.GetField( "m_SceneHierarchy", BindingFlags.Instance | BindingFlags.NonPublic );
			var renameGO                 = sceneHierarchyType.GetMethod( "RenameGO", BindingFlags.Instance | BindingFlags.NonPublic );
			var sceneHierarchyWindow     = EditorWindow.GetWindow( sceneHierarchyWindowType );
			var sceneHierarchy           = sceneHierarchyField.GetValue( sceneHierarchyWindow );

			renameGO.Invoke( sceneHierarchy, null );
		}
	}
}