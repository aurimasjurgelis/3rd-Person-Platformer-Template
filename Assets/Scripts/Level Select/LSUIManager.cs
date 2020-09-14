using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LSUIManager : MonoBehaviour
{
	#region Singleton
	public static LSUIManager instance;
    private void Awake()
    {
        instance = this;
    }
	#endregion

	public Text levelNameText;
    public GameObject levelNamePanel;
    public Text coinsText;

}
