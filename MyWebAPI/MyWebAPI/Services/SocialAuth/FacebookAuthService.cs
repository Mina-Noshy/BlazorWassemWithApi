﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MyWebAPI.Services.SocialAuth
{
    public class FacebookAuthService
    {
        public async Task<string> GetFacebookProfilePicURL(string accessToken)
        {
            using var httpClient = new HttpClient();
            var picUrl = $"https://graph.facebook.com/v5.0/me/picture?redirect=false&type=large&access_token={accessToken}";
            var res = await httpClient.GetStringAsync(picUrl);
            var pic = JsonConvert.DeserializeAnonymousType(res, new { data = new PictureData() });
            return pic.data.Url;
        }
    }

    public class PictureData
    {
        public int Height { get; set; }
        [JsonProperty("is_silhouette")]
        public bool IsSilhouette { get; set; }
        public string Url { get; set; }
        public int Width { get; set; }
    }
}
