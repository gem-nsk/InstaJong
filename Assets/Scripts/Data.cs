using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    [DataContract]
    public class Comments
    {

        [DataMember(Name = "count")]
        public int count { get; set; }
    }

    [DataContract]
    public class From
    {

        [DataMember(Name = "username")]
        public string username { get; set; }

        [DataMember(Name = "full_name")]
        public string full_name { get; set; }

        [DataMember(Name = "type")]
        public string type { get; set; }

        [DataMember(Name = "id")]
        public string id { get; set; }
    }

    [DataContract]
    public class Caption
    {

        [DataMember(Name = "created_time")]
        public string created_time { get; set; }

        [DataMember(Name = "text")]
        public string text { get; set; }

        [DataMember(Name = "from")]
        public From from { get; set; }

        [DataMember(Name = "id")]
        public string id { get; set; }
    }

    [DataContract]
    public class Likes
    {

        [DataMember(Name = "count")]
        public int count { get; set; }
    }

    [DataContract]
    public class User
    {

        [DataMember(Name = "username")]
        public string username { get; set; }

        [DataMember(Name = "profile_picture")]
        public string profile_picture { get; set; }

        [DataMember(Name = "id")]
        public string id { get; set; }
    }

    [DataContract]
    public class LowResolution
    {

        [DataMember(Name = "url")]
        public string url { get; set; }

        [DataMember(Name = "width")]
        public int width { get; set; }

        [DataMember(Name = "height")]
        public int height { get; set; }
    }

    [DataContract]
    public class Thumbnail
    {

        [DataMember(Name = "url")]
        public string url { get; set; }

        [DataMember(Name = "width")]
        public int width { get; set; }

        [DataMember(Name = "height")]
        public int height { get; set; }
    }

    [DataContract]
    public class StandardResolution
    {

        [DataMember(Name = "url")]
        public string url { get; set; }

        [DataMember(Name = "width")]
        public int width { get; set; }

        [DataMember(Name = "height")]
        public int height { get; set; }
    }

    [DataContract]
    public class Images
    {

        [DataMember(Name = "low_resolution")]
        public LowResolution low_resolution { get; set; }

        [DataMember(Name = "thumbnail")]
        public Thumbnail thumbnail { get; set; }

        [DataMember(Name = "standard_resolution")]
        public StandardResolution standard_resolution { get; set; }
    }

    [DataContract]
    public class Location
    {

        [DataMember(Name = "latitude")]
        public double latitude { get; set; }

        [DataMember(Name = "longitude")]
        public double longitude { get; set; }

        [DataMember(Name = "id")]
        public string id { get; set; }

        [DataMember(Name = "street_address")]
        public string street_address { get; set; }

        [DataMember(Name = "name")]
        public string name { get; set; }
    }

    [DataContract]
    public class Datum
    {

        [DataMember(Name = "comments")]
        public Comments comments { get; set; }

        [DataMember(Name = "caption")]
        public Caption caption { get; set; }

        [DataMember(Name = "likes")]
        public Likes likes { get; set; }

        [DataMember(Name = "link")]
        public string link { get; set; }

        [DataMember(Name = "user")]
        public User user { get; set; }

        [DataMember(Name = "created_time")]
        public string created_time { get; set; }

        [DataMember(Name = "images")]
        public Images images { get; set; }

        [DataMember(Name = "type")]
        public string type { get; set; }

        [DataMember(Name = "users_in_photo")]
        public IList<object> users_in_photo { get; set; }

        [DataMember(Name = "filter")]
        public string filter { get; set; }

        [DataMember(Name = "tags")]
        public IList<string> tags { get; set; }

        [DataMember(Name = "id")]
        public string id { get; set; }

        [DataMember(Name = "location")]
        public Location location { get; set; }
    }

    [DataContract]
    public class RootObject
    {

        [DataMember(Name = "data")]
        public IList<Datum> data { get; set; }
    }
}
