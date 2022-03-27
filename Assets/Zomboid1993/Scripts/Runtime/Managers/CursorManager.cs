using UnityEngine;

public class CursorManager : MonoBehaviour {
	public Texture2D DefaultCursorImage;

	public Texture2D ClickedCursorImage;

	public Vector2 Hotspot;

	private void Update() {
		UpdateCursor();
	}

	private void UpdateCursor() {
		if (Input.GetMouseButtonDown(0)) {
			Cursor.SetCursor(
				ClickedCursorImage,
				Hotspot,
				CursorMode.Auto
			);
		}

		if (Input.GetMouseButtonUp(0)) {
			Cursor.SetCursor(
				DefaultCursorImage,
				Hotspot,
				CursorMode.Auto
			);
		}
	}
}
