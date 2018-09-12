using System.Runtime.Serialization;
using System;

namespace WebAPIClient
{
    [DataContract(Name="repo")]
    public class Repository
    {
        [DataMember(Name="name")]
        public string Name;
    }
}
