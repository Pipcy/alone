using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//****

public class sceneChange : MonoBehaviour
{
    

    public void AloadTitle() {
        SceneManager.LoadScene("Title"); }

    public void Aintro(){
        SceneManager.LoadScene("intro"); }

    public void Astart(){
        SceneManager.LoadScene("SampleScene"); }

    
    public void Alose(){
        SceneManager.LoadScene("EndingLost"); }

    public void Acredit(){
        SceneManager.LoadScene("credit"); }



}
