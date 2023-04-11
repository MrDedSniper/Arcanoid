using System.Collections.Generic;
using UnityEngine;

public class BlockGenerator : MonoBehaviour
{
    [SerializeField] private GameObject blockPrefab;
    [SerializeField] private int rows = 3;
    [SerializeField] private int cols = 9;

    private int UpperSpace = 3;

    private UIScript _uiScript;

    private List<GameObject> blocks = new List<GameObject>();

    private void Start()
    {
        _uiScript = FindObjectOfType<UIScript>();
        GenerateBlocks();
    }

    private void GenerateBlocks()
    {
        List<Color> colors = new List<Color>();
        colors.Add(new Color(233f/255f, 144f/255f, 213f/255f, 1f));
        colors.Add(new Color(144f/255f, 147f/255f, 233f/255f, 1f));
        colors.Add(new Color(112f/255f, 209f/255f, 170f/255f, 1f));
        colors.Add(new Color(207f/255f, 219f/255f, 140f/255f, 1f));
        colors.Add(new Color(236f/255f, 153f/255f, 99f/255f, 1f));

        int colorIndex = 0;

        for (int row = 0; row < rows; row++)
        {
            int colsCount = cols - row % 2;

            for (int col = 0; col < colsCount; col++)
            {
                Vector2 position = new Vector2((col * 2) - (colsCount - 1), row * -1 + UpperSpace);
                GameObject block = Instantiate(blockPrefab, position, Quaternion.identity);

                if (colorIndex >= colors.Count)
                {
                    colorIndex = 0;
                }

                block.GetComponent<SpriteRenderer>().color = colors[colorIndex];
                blocks.Add(block);
                block.GetComponent<BlocksBehavior>().onBlockDestroyed.AddListener(RemoveBlock);

                colorIndex++;
            }
        }
    }

    public void RemoveBlock(GameObject block)
    {
        blocks.Remove(block);
        Destroy(block);
        if (blocks.Count == 0)
        {
            DoSomething();
        }
    }

    private void DoSomething()
    {

        Time.timeScale = 0;
        _uiScript.SetEndingUI();
    }
}