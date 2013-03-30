﻿using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace TFSServiceAlerts
{
    [XmlRoot]
    public class CheckinEvent
    {
        public bool AllChangesIncluded { get; set; }
        public string Subscriber { get; set; }
        public string Owner { get; set; }
        public string OwnerDisplay { get; set; }
        public string CreationDate { get; set; }
        public string Comment { get; set; }
        public string TimeZone { get; set; }
        public string TimeZoneOffset { get; set; }
        public string TeamProject { get; set; }
        public string PolicyOverrideComment { get; set; }
        public string Title { get; set; }
        public string ContentTitle { get; set; }
        public string Committer { get; set; }
        public string CommitterDisplay { get; set; }
        public int Number { get; set; }

        [XmlArray]
        [XmlArrayItem("CheckinNote", typeof(NameValuePair))]
        public List<NameValuePair> CheckinNotes { get; set; }

        [XmlArray]
        [XmlArrayItem("Artifact", typeof(ClientArtifact))]
        public List<ClientArtifact> Artifacts { get; set; }

    }

    public class NameValuePair
    {
        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("val")]
        public string Value { get; set; }
    }

    public class ClientArtifact
    {
        public string Url { get; set; }

        [XmlAttribute]
        public string ArtifactType { get; set; }

        [XmlAttribute]
        public string ServerItem { get; set; }

        [XmlAttribute]
        public string Item { get; set; }

        [XmlAttribute]
        public string Folder { get; set; }

        [XmlAttribute]
        public string TeamProject { get; set; }

        [XmlAttribute]
        public string ItemRevision { get; set; }

        [XmlAttribute]
        public string ChangeType { get; set; }
    }
}