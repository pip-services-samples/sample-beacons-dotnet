﻿using System;
using System.Runtime.Serialization;
using PipServices.Commons.Data;

namespace Interfaces.Data.Version1
{
    [DataContract]
    public class BeaconV1:  IStringIdentifiable
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }
        [DataMember(Name = "site_id")]
        public string SiteId { get; set; }
        [DataMember(Name = "type")]
        public string Type { get; set; }
        [DataMember(Name = "udi")]
        public string Udi { get; set; }
        [DataMember(Name = "label")]
        public string Label { get; set; }
        [DataMember(Name = "center")]
        public CenterObject Center { get; set; }
        [DataMember(Name = "radius")]
        public double Radius { get; set; }
       
    }
}