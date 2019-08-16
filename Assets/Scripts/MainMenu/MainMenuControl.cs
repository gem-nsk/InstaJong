using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Newtonsoft.Json;
using Assets.Scripts;
using System.IO;
using System.Net;
using System;

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
        int i = 1;
        foreach (var data in dyn.data)
        {
            string url = data.images.thumbnail.url;
            using (WebClient client = new WebClient())
            {
                //client.DownloadFile(new Uri(url), @"D:\workspace\InstaJong\Assets\Resources\image");
                // OR 
                client.DownloadFileAsync(new Uri(url), @"D:\workspace\InstaJong\Assets\Resources\image\file"+i+".jpg");
            }
            i++;
        }

        SceneManager.LoadScene("Game");
       
       

    }

    public void ButtonBack()
    {
        SceneManager.LoadScene("Menu");
    }

}
