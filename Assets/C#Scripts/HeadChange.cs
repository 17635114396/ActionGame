using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HeadChange : MonoBehaviour
{
    public Color purple;
    public SkinnedMeshRenderer[] bodyarry;

    public SkinnedMeshRenderer headRender;
    public Mesh[] headMeshArry;
    private int arryListIndex=0;

    public SkinnedMeshRenderer handRender;
    public Mesh[] handMeshArry;
    private int handarryListIndex = 0;

    private Color[] colorArry;
    private int colorIndex=-1;

    // Start is called before the first frame update
    void Start()
    {
        colorArry = new Color[] { Color.blue, Color.cyan, Color.green, purple, Color.red };
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnHeadChange() {
        arryListIndex++;
        arryListIndex %= headMeshArry.Length;
        headRender.sharedMesh = headMeshArry[arryListIndex];
    }
    public void OnHandChange() {
        handarryListIndex++;
        handarryListIndex %= handMeshArry.Length;
        handRender.sharedMesh = handMeshArry[handarryListIndex];
    }
    public void OnColorOne() {
        colorIndex = 0;
        OnChangeColor(Color.blue);
    }
    public void OnColorTwo() {
        colorIndex = 1;
        OnChangeColor(Color.cyan);
    }
    public void OnColorThree() {
        colorIndex = 2;
        OnChangeColor(Color.green);
    }
    public void OnColorFour() {
        colorIndex = 3;
        OnChangeColor(purple);
    }
    public void OnColorFive() {
        colorIndex = 4;
        OnChangeColor(Color.red);
    }
    private void OnChangeColor(Color c ) {
        foreach (SkinnedMeshRenderer renderer in bodyarry) {
            renderer.material.color = c;
        }

    }
    void save() {
        PlayerPrefs.SetInt(" arryListIndex", arryListIndex);
        PlayerPrefs.SetInt("handarryListIndex", handarryListIndex);
        PlayerPrefs.SetInt("colorIndex", colorIndex);
    }

    public void OnPlay() {
        save();
        SceneManager.LoadScene(1);
    }
}
