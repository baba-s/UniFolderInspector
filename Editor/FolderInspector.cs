using UnityEditor;
using UnityEngine;

namespace Kogane.Internal
{
	[CustomEditor( typeof( DefaultAsset ) )]
	internal sealed class FolderInspector : Editor
	{
		public override void OnInspectorGUI()
		{
			var path = AssetDatabase.GetAssetPath( target );

			if ( !AssetDatabase.IsValidFolder( path ) ) return;
			if ( !path.StartsWith( "Assets/" ) ) return;

			GUI.enabled = true;

			if ( GUILayout.Button( "Create Folder" ) )
			{
				EditorApplication.ExecuteMenuItem( "Assets/Create/Folder" );
			}

			if ( GUILayout.Button( "Create C# Script" ) )
			{
				EditorApplication.ExecuteMenuItem( "Assets/Create/C# Script" );
			}

			GUI.enabled = false;
		}
	}
}