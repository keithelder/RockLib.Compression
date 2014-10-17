﻿using System.Text;
using System.Xml.Serialization;

namespace Rock.Serialization
{
    public interface IXSerializerSerializerConfiguration
    {
        XmlSerializerNamespaces Namespaces { get; }
        Encoding Encoding { get; }
        string DefaultNamespace { get; }
        bool Indent { get; }
        string RootElementName { get; }
        bool AlwaysEmitTypes { get; }
        bool Redact { get; }
        bool TreatEmptyElementAsString { get; }
        bool EmitNil { get; }
    }
}