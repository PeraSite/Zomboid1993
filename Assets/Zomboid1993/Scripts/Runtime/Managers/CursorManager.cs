using UnityEngine;

public class CursorManager : MonoBehaviour {
	public Texture2D DefaultCursorImage;

	public Texture2D ClickedCursorImage;

	public Vector2 Hotspot;

	private void Update() {
		UpdateCursor();
	}

	private void UpdateCursor() {
		var cursorImage = Input.GetMouseButton(0)
			? ClickedCursorImage
			: DefaultCursorImage;

		Cursor.SetCursor(
			cursorImage,
			Hotspot,
			CursorMode.Auto
		);
	}
}
