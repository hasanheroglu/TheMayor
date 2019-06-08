using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollManager : MonoBehaviour
{
	//============================\\
	//BoxCount is broken. Fix it! ||
	//============================//
	private int boxCount;

	private void Start()
	{
		boxCount = 0;
	}

	public void SetBoxPosition(GameObject box)
	{
		boxCount++;
		var boxTransform = box.GetComponent<RectTransform>();
		var newPosition = new  Vector3(1,-box.transform.GetSiblingIndex() * boxTransform.rect.height, 0);
		boxTransform.anchoredPosition = newPosition;
		SetScrollLength();
	}

	private void SetScrollLength()
	{
		var scrollTransform = this.gameObject.GetComponent<RectTransform>();
		scrollTransform.sizeDelta = new Vector2(0,scrollTransform.rect.height * boxCount);
	}

	public void RemoveBox(int index)
	{
		foreach (Transform child in this.transform)
		{
			var siblingIndex = child.GetSiblingIndex();
			if (siblingIndex > index)
			{
				boxCount--;
				child.SetSiblingIndex(siblingIndex-1);
				SetBoxPosition(child.gameObject);
			}
		}
	}
}
