using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Newtonsoft.Json;
using Assets.Scripts;
using System.IO;
using System.Net;

public class MainMenuControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
      
    public void NewGanePressed()
    {
        string token = "1445481979.9d5ac8f.3a382bd5bdd441bd84a6ff98c2770f43";
        WebClient webClient = new WebClient();
        var list = webClient.DownloadString("https://api.instagram.com/v1/users/self/media/recent/?access_token=" + token);

        var dyn = JsonConvert.DeserializeObject<RootObject>(list);
        foreach (var data in dyn.data)
        {
            Debug.Log(data.user.username);
        }

        SceneManager.LoadScene("Game");
       
       

    }

    public void ButtonBack()
    {
        SceneManager.LoadScene("Menu");
    }

}
