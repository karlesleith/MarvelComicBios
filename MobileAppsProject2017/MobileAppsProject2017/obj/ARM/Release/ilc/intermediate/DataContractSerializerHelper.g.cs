using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Threading;
using System.Xml;

[assembly: global::System.Reflection.AssemblyVersion("4.0.0.0")]



namespace System.Runtime.Serialization.Generated
{
    [global::System.Runtime.CompilerServices.__BlockReflection]
    public static partial class DataContractSerializerHelper
    {
        public static void InitDataContracts()
        {
            global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Runtime.Serialization.DataContract> dataContracts = global::System.Runtime.Serialization.DataContract.GetDataContracts();
            PopulateContractDictionary(dataContracts);
            global::System.Collections.Generic.Dictionary<global::System.Runtime.Serialization.DataContract, global::System.Runtime.Serialization.Json.JsonReadWriteDelegates> jsonDelegates = global::System.Runtime.Serialization.Json.JsonReadWriteDelegates.GetJsonDelegates();
            PopulateJsonDelegateDictionary(
                                dataContracts, 
                                jsonDelegates
                            );
        }
        static int[] s_knownContractsLists = new int[] {
              -1, }
        ;
        // Count = 483
        static int[] s_xmlDictionaryStrings = new int[] {
                0, // array length: 0
                7, // array length: 7
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                7, // array length: 7
                830, // index: 830, string: "attributionHTML"
                846, // index: 846, string: "attributionText"
                862, // index: 862, string: "code"
                867, // index: 867, string: "copyright"
                877, // index: 877, string: "data"
                882, // index: 882, string: "etag"
                887, // index: 887, string: "status"
                7, // array length: 7
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                5, // array length: 5
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                5, // array length: 5
                894, // index: 894, string: "count"
                900, // index: 900, string: "limit"
                906, // index: 906, string: "offset"
                913, // index: 913, string: "results"
                921, // index: 921, string: "total"
                5, // array length: 5
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                11, // array length: 11
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                11, // array length: 11
                927, // index: 927, string: "comics"
                934, // index: 934, string: "description"
                946, // index: 946, string: "events"
                953, // index: 953, string: "id"
                956, // index: 956, string: "modified"
                965, // index: 965, string: "name"
                970, // index: 970, string: "resourceURI"
                982, // index: 982, string: "series"
                989, // index: 989, string: "stories"
                997, // index: 997, string: "thumbnail"
                1007, // index: 1007, string: "urls"
                11, // array length: 11
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                4, // array length: 4
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                4, // array length: 4
                1012, // index: 1012, string: "available"
                1022, // index: 1022, string: "collectionURI"
                1036, // index: 1036, string: "items"
                1042, // index: 1042, string: "returned"
                4, // array length: 4
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                2, // array length: 2
                965, // index: 965, string: "name"
                970, // index: 970, string: "resourceURI"
                2, // array length: 2
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                4, // array length: 4
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                4, // array length: 4
                1012, // index: 1012, string: "available"
                1022, // index: 1022, string: "collectionURI"
                1036, // index: 1036, string: "items"
                1042, // index: 1042, string: "returned"
                4, // array length: 4
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                2, // array length: 2
                965, // index: 965, string: "name"
                970, // index: 970, string: "resourceURI"
                2, // array length: 2
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                4, // array length: 4
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                4, // array length: 4
                1012, // index: 1012, string: "available"
                1022, // index: 1022, string: "collectionURI"
                1036, // index: 1036, string: "items"
                1042, // index: 1042, string: "returned"
                4, // array length: 4
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                2, // array length: 2
                965, // index: 965, string: "name"
                970, // index: 970, string: "resourceURI"
                2, // array length: 2
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                4, // array length: 4
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                4, // array length: 4
                1012, // index: 1012, string: "available"
                1022, // index: 1022, string: "collectionURI"
                1036, // index: 1036, string: "items"
                1042, // index: 1042, string: "returned"
                4, // array length: 4
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                3, // array length: 3
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                3, // array length: 3
                965, // index: 965, string: "name"
                970, // index: 970, string: "resourceURI"
                1051, // index: 1051, string: "type"
                3, // array length: 3
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                4, // array length: 4
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                4, // array length: 4
                1056, // index: 1056, string: "extension"
                1066, // index: 1066, string: "large"
                1072, // index: 1072, string: "path"
                1077, // index: 1077, string: "small"
                4, // array length: 4
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                2, // array length: 2
                1051, // index: 1051, string: "type"
                1083, // index: 1083, string: "url"
                2, // array length: 2
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                7, // array length: 7
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                7, // array length: 7
                830, // index: 830, string: "attributionHTML"
                846, // index: 846, string: "attributionText"
                862, // index: 862, string: "code"
                867, // index: 867, string: "copyright"
                877, // index: 877, string: "data"
                882, // index: 882, string: "etag"
                887, // index: 887, string: "status"
                7, // array length: 7
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                5, // array length: 5
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                5, // array length: 5
                894, // index: 894, string: "count"
                900, // index: 900, string: "limit"
                906, // index: 906, string: "offset"
                913, // index: 913, string: "results"
                921, // index: 921, string: "total"
                5, // array length: 5
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                29, // array length: 29
                -1, // string: null
                639, // index: 639, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                639, // index: 639, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                29, // array length: 29
                1087, // index: 1087, string: "characters"
                1098, // index: 1098, string: "collectedIssues"
                1114, // index: 1114, string: "collections"
                1126, // index: 1126, string: "creators"
                1135, // index: 1135, string: "dates"
                934, // index: 934, string: "description"
                1141, // index: 1141, string: "diamondCode"
                1153, // index: 1153, string: "digitalId"
                1163, // index: 1163, string: "ean"
                946, // index: 946, string: "events"
                1167, // index: 1167, string: "format"
                953, // index: 953, string: "id"
                1174, // index: 1174, string: "images"
                1181, // index: 1181, string: "isbn"
                1186, // index: 1186, string: "issn"
                1191, // index: 1191, string: "issueNumber"
                956, // index: 956, string: "modified"
                1203, // index: 1203, string: "pageCount"
                1213, // index: 1213, string: "prices"
                970, // index: 970, string: "resourceURI"
                982, // index: 982, string: "series"
                989, // index: 989, string: "stories"
                1220, // index: 1220, string: "textObjects"
                997, // index: 997, string: "thumbnail"
                1232, // index: 1232, string: "title"
                1238, // index: 1238, string: "upc"
                1007, // index: 1007, string: "urls"
                1242, // index: 1242, string: "variantDescription"
                1261, // index: 1261, string: "variants"
                29, // array length: 29
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                4, // array length: 4
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                4, // array length: 4
                1012, // index: 1012, string: "available"
                1022, // index: 1022, string: "collectionURI"
                1036, // index: 1036, string: "items"
                1042, // index: 1042, string: "returned"
                4, // array length: 4
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                2, // array length: 2
                965, // index: 965, string: "name"
                970, // index: 970, string: "resourceURI"
                2, // array length: 2
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                4, // array length: 4
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                4, // array length: 4
                1012, // index: 1012, string: "available"
                1022, // index: 1022, string: "collectionURI"
                1036, // index: 1036, string: "items"
                1042, // index: 1042, string: "returned"
                4, // array length: 4
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                3, // array length: 3
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                3, // array length: 3
                965, // index: 965, string: "name"
                970, // index: 970, string: "resourceURI"
                1270, // index: 1270, string: "role"
                3, // array length: 3
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                2, // array length: 2
                1275, // index: 1275, string: "date"
                1051, // index: 1051, string: "type"
                2, // array length: 2
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                2, // array length: 2
                1056, // index: 1056, string: "extension"
                1072, // index: 1072, string: "path"
                2, // array length: 2
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                2, // array length: 2
                1280, // index: 1280, string: "price"
                1051, // index: 1051, string: "type"
                2, // array length: 2
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                3, // array length: 3
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                3, // array length: 3
                1286, // index: 1286, string: "language"
                1295, // index: 1295, string: "text"
                1051, // index: 1051, string: "type"
                3, // array length: 3
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                2, // array length: 2
                965, // index: 965, string: "name"
                970, // index: 970, string: "resourceURI"
                2, // array length: 2
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
                276  // index: 276, string: "http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models"
        };
        // Count = 0
        static global::MemberEntry[] s_dataMemberLists = new global::MemberEntry[0];
        static readonly byte[] s_dataContractMap_Hashtable = null;
        // Count=78
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::DataContractMapEntry[] s_dataContractMap = new global::DataContractMapEntry[] {
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 0, // 0x0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]" +
                                ", mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 0, // 0x0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte[], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 16, // 0x10
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 32, // 0x20
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], m" +
                                "scorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 32, // 0x20
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 48, // 0x30
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]" +
                                "], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 48, // 0x30
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 64, // 0x40
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]" +
                                ", mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 64, // 0x40
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 80, // 0x50
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 80, // 0x50
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 96, // 0x60
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 96, // 0x60
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 112, // 0x70
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], m" +
                                "scorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 112, // 0x70
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 128, // 0x80
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 128, // 0x80
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 144, // 0x90
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 144, // 0x90
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 160, // 0xa0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Xml.XmlQualifiedName, System.Xml.ReaderWriter, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f" +
                                "11d50a3a")),
                    TableIndex = 176, // 0xb0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 192, // 0xc0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 192, // 0xc0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 208, // 0xd0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 208, // 0xd0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 224, // 0xe0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 240, // 0xf0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]" +
                                "], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 240, // 0xf0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 256, // 0x100
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], m" +
                                "scorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 256, // 0x100
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 272, // 0x110
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 272, // 0x110
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 288, // 0x120
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 288, // 0x120
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 304, // 0x130
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 304, // 0x130
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Uri, System.Private.Uri, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 320, // 0x140
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.CharacterDataWrapper, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, Publ" +
                                "icKeyToken=null")),
                    TableIndex = 1, // 0x1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.CharacterDataContainer, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, Pu" +
                                "blicKeyToken=null")),
                    TableIndex = 17, // 0x11
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[MobileAppsProject2017.Models.Character, MobileAppsProject2017, Version=1.0.0." +
                                "0, Culture=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToke" +
                                "n=b03f5f7f11d50a3a")),
                    TableIndex = 2, // 0x2
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.Character, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, PublicKeyToken=" +
                                "null")),
                    TableIndex = 33, // 0x21
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.Comics, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nul" +
                                "l")),
                    TableIndex = 49, // 0x31
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[MobileAppsProject2017.Models.Comic, MobileAppsProject2017, Version=1.0.0.0, C" +
                                "ulture=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b0" +
                                "3f5f7f11d50a3a")),
                    TableIndex = 18, // 0x12
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.Comic, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null" +
                                "")),
                    TableIndex = 65, // 0x41
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.Events, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nul" +
                                "l")),
                    TableIndex = 81, // 0x51
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[MobileAppsProject2017.Models.Event, MobileAppsProject2017, Version=1.0.0.0, C" +
                                "ulture=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b0" +
                                "3f5f7f11d50a3a")),
                    TableIndex = 34, // 0x22
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.Event, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null" +
                                "")),
                    TableIndex = 97, // 0x61
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.SeriesList, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, PublicKeyToken" +
                                "=null")),
                    TableIndex = 113, // 0x71
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[MobileAppsProject2017.Models.Series, MobileAppsProject2017, Version=1.0.0.0, " +
                                "Culture=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b" +
                                "03f5f7f11d50a3a")),
                    TableIndex = 50, // 0x32
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.Series, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nul" +
                                "l")),
                    TableIndex = 129, // 0x81
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.Stories, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nu" +
                                "ll")),
                    TableIndex = 145, // 0x91
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[MobileAppsProject2017.Models.Story, MobileAppsProject2017, Version=1.0.0.0, C" +
                                "ulture=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b0" +
                                "3f5f7f11d50a3a")),
                    TableIndex = 66, // 0x42
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.Story, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null" +
                                "")),
                    TableIndex = 161, // 0xa1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.Thumbnail, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, PublicKeyToken=" +
                                "null")),
                    TableIndex = 177, // 0xb1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[MobileAppsProject2017.Models.Url, MobileAppsProject2017, Version=1.0.0.0, Cul" +
                                "ture=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f" +
                                "5f7f11d50a3a")),
                    TableIndex = 82, // 0x52
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.Url, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 193, // 0xc1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.ComicDataWrapper, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, PublicKe" +
                                "yToken=null")),
                    TableIndex = 209, // 0xd1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.ComicDataContainer, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, Public" +
                                "KeyToken=null")),
                    TableIndex = 225, // 0xe1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[MobileAppsProject2017.Models.ComicBook, MobileAppsProject2017, Version=1.0.0." +
                                "0, Culture=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToke" +
                                "n=b03f5f7f11d50a3a")),
                    TableIndex = 98, // 0x62
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.ComicBook, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, PublicKeyToken=" +
                                "null")),
                    TableIndex = 241, // 0xf1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.Characters, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, PublicKeyToken" +
                                "=null")),
                    TableIndex = 257, // 0x101
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[MobileAppsProject2017.Models.Item2, MobileAppsProject2017, Version=1.0.0.0, C" +
                                "ulture=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b0" +
                                "3f5f7f11d50a3a")),
                    TableIndex = 114, // 0x72
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.Item2, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null" +
                                "")),
                    TableIndex = 273, // 0x111
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, Publ" +
                                "icKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11" +
                                "d50a3a")),
                    TableIndex = 130, // 0x82
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.Creators, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, PublicKeyToken=n" +
                                "ull")),
                    TableIndex = 289, // 0x121
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[MobileAppsProject2017.Models.Item, MobileAppsProject2017, Version=1.0.0.0, Cu" +
                                "lture=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03" +
                                "f5f7f11d50a3a")),
                    TableIndex = 146, // 0x92
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.Item, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 305, // 0x131
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[MobileAppsProject2017.Models.Date, MobileAppsProject2017, Version=1.0.0.0, Cu" +
                                "lture=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03" +
                                "f5f7f11d50a3a")),
                    TableIndex = 162, // 0xa2
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.Date, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 321, // 0x141
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[MobileAppsProject2017.Models.Image, MobileAppsProject2017, Version=1.0.0.0, C" +
                                "ulture=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b0" +
                                "3f5f7f11d50a3a")),
                    TableIndex = 178, // 0xb2
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.Image, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null" +
                                "")),
                    TableIndex = 337, // 0x151
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[MobileAppsProject2017.Models.Price, MobileAppsProject2017, Version=1.0.0.0, C" +
                                "ulture=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b0" +
                                "3f5f7f11d50a3a")),
                    TableIndex = 194, // 0xc2
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.Price, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null" +
                                "")),
                    TableIndex = 353, // 0x161
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[MobileAppsProject2017.Models.TextObject, MobileAppsProject2017, Version=1.0.0" +
                                ".0, Culture=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyTok" +
                                "en=b03f5f7f11d50a3a")),
                    TableIndex = 210, // 0xd2
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.TextObject, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, PublicKeyToken" +
                                "=null")),
                    TableIndex = 369, // 0x171
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[MobileAppsProject2017.Models.Variant, MobileAppsProject2017, Version=1.0.0.0," +
                                " Culture=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=" +
                                "b03f5f7f11d50a3a")),
                    TableIndex = 226, // 0xe2
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.Variant, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nu" +
                                "ll")),
                    TableIndex = 385, // 0x181
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object[], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 242, // 0xf2
                }
        };
        static readonly byte[] s_dataContracts_Hashtable = null;
        // Count=21
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::DataContractEntry[] s_dataContracts = new global::DataContractEntry[] {
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 0, // boolean
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 0, // boolean
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 0, // boolean
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.BooleanDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 93, // base64Binary
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 93, // base64Binary
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 93, // base64Binary
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte[], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte[], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.ByteArrayDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 106, // char
                        NamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        StableNameIndex = 106, // char
                        StableNameNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        TopLevelElementNameIndex = 106, // char
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.CharDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 111, // dateTime
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 111, // dateTime
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 111, // dateTime
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.DateTimeDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 120, // decimal
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 120, // decimal
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 120, // decimal
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.DecimalDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 128, // double
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 128, // double
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 128, // double
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.DoubleDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 135, // float
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 135, // float
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 135, // float
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.FloatDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 141, // guid
                        NamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        StableNameIndex = 141, // guid
                        StableNameNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        TopLevelElementNameIndex = 141, // guid
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.GuidDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 146, // int
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 146, // int
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 146, // int
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.IntDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 150, // long
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 150, // long
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 150, // long
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.LongDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 155, // anyType
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 155, // anyType
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 155, // anyType
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    Kind = global::DataContractKind.ObjectDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 163, // QName
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 163, // QName
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 163, // QName
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Xml.XmlQualifiedName, System.Xml.ReaderWriter, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f" +
                                    "11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Xml.XmlQualifiedName, System.Xml.ReaderWriter, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f" +
                                    "11d50a3a")),
                    },
                    Kind = global::DataContractKind.QNameDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 169, // short
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 169, // short
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 169, // short
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.ShortDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 175, // byte
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 175, // byte
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 175, // byte
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.SignedByteDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 180, // string
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 180, // string
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 180, // string
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.StringDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 187, // duration
                        NamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        StableNameIndex = 187, // duration
                        StableNameNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        TopLevelElementNameIndex = 187, // duration
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.TimeSpanDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 196, // unsignedByte
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 196, // unsignedByte
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 196, // unsignedByte
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedByteDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 209, // unsignedInt
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 209, // unsignedInt
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 209, // unsignedInt
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedIntDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 221, // unsignedLong
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 221, // unsignedLong
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 221, // unsignedLong
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedLongDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 234, // unsignedShort
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 234, // unsignedShort
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 234, // unsignedShort
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedShortDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 248, // anyURI
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 248, // anyURI
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 248, // anyURI
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Uri, System.Private.Uri, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Uri, System.Private.Uri, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    Kind = global::DataContractKind.UriDataContract,
                }
        };
        static readonly byte[] s_classDataContracts_Hashtable = null;
        // Count=25
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::ClassDataContractEntry[] s_classDataContracts = new global::ClassDataContractEntry[] {
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 255, // CharacterDataWrapper
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        StableNameIndex = 255, // CharacterDataWrapper
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        TopLevelElementNameIndex = 255, // CharacterDataWrapper
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.CharacterDataWrapper, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, Publ" +
                                    "icKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.CharacterDataWrapper, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, Publ" +
                                    "icKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 1,
                    ContractNamespacesListIndex = 9,
                    MemberNamesListIndex = 11,
                    MemberNamespacesListIndex = 19,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 345, // CharacterDataContainer
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        StableNameIndex = 345, // CharacterDataContainer
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        TopLevelElementNameIndex = 345, // CharacterDataContainer
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.CharacterDataContainer, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, Pu" +
                                    "blicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.CharacterDataContainer, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, Pu" +
                                    "blicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 27,
                    ContractNamespacesListIndex = 33,
                    MemberNamesListIndex = 35,
                    MemberNamespacesListIndex = 41,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 385, // Character
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        StableNameIndex = 385, // Character
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        TopLevelElementNameIndex = 385, // Character
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.Character, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, PublicKeyToken=" +
                                    "null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.Character, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, PublicKeyToken=" +
                                    "null")),
                    },
                    ChildElementNamespacesListIndex = 47,
                    ContractNamespacesListIndex = 59,
                    MemberNamesListIndex = 61,
                    MemberNamespacesListIndex = 73,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 395, // Comics
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        StableNameIndex = 395, // Comics
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        TopLevelElementNameIndex = 395, // Comics
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.Comics, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nul" +
                                    "l")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.Comics, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nul" +
                                    "l")),
                    },
                    ChildElementNamespacesListIndex = 85,
                    ContractNamespacesListIndex = 90,
                    MemberNamesListIndex = 92,
                    MemberNamespacesListIndex = 97,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 415, // Comic
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        StableNameIndex = 415, // Comic
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        TopLevelElementNameIndex = 415, // Comic
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.Comic, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null" +
                                    "")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.Comic, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null" +
                                    "")),
                    },
                    ChildElementNamespacesListIndex = 102,
                    ContractNamespacesListIndex = 105,
                    MemberNamesListIndex = 107,
                    MemberNamespacesListIndex = 110,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 421, // Events
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        StableNameIndex = 421, // Events
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        TopLevelElementNameIndex = 421, // Events
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.Events, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nul" +
                                    "l")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.Events, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nul" +
                                    "l")),
                    },
                    ChildElementNamespacesListIndex = 113,
                    ContractNamespacesListIndex = 118,
                    MemberNamesListIndex = 120,
                    MemberNamespacesListIndex = 125,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 441, // Event
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        StableNameIndex = 441, // Event
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        TopLevelElementNameIndex = 441, // Event
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.Event, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null" +
                                    "")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.Event, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null" +
                                    "")),
                    },
                    ChildElementNamespacesListIndex = 130,
                    ContractNamespacesListIndex = 133,
                    MemberNamesListIndex = 135,
                    MemberNamespacesListIndex = 138,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 447, // SeriesList
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        StableNameIndex = 447, // SeriesList
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        TopLevelElementNameIndex = 447, // SeriesList
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.SeriesList, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, PublicKeyToken" +
                                    "=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.SeriesList, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, PublicKeyToken" +
                                    "=null")),
                    },
                    ChildElementNamespacesListIndex = 141,
                    ContractNamespacesListIndex = 146,
                    MemberNamesListIndex = 148,
                    MemberNamespacesListIndex = 153,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 472, // Series
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        StableNameIndex = 472, // Series
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        TopLevelElementNameIndex = 472, // Series
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.Series, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nul" +
                                    "l")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.Series, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nul" +
                                    "l")),
                    },
                    ChildElementNamespacesListIndex = 158,
                    ContractNamespacesListIndex = 161,
                    MemberNamesListIndex = 163,
                    MemberNamespacesListIndex = 166,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 479, // Stories
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        StableNameIndex = 479, // Stories
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        TopLevelElementNameIndex = 479, // Stories
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.Stories, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nu" +
                                    "ll")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.Stories, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nu" +
                                    "ll")),
                    },
                    ChildElementNamespacesListIndex = 169,
                    ContractNamespacesListIndex = 174,
                    MemberNamesListIndex = 176,
                    MemberNamespacesListIndex = 181,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 500, // Story
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        StableNameIndex = 500, // Story
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        TopLevelElementNameIndex = 500, // Story
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.Story, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null" +
                                    "")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.Story, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null" +
                                    "")),
                    },
                    ChildElementNamespacesListIndex = 186,
                    ContractNamespacesListIndex = 190,
                    MemberNamesListIndex = 192,
                    MemberNamespacesListIndex = 196,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 506, // Thumbnail
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        StableNameIndex = 506, // Thumbnail
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        TopLevelElementNameIndex = 506, // Thumbnail
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.Thumbnail, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, PublicKeyToken=" +
                                    "null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.Thumbnail, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, PublicKeyToken=" +
                                    "null")),
                    },
                    ChildElementNamespacesListIndex = 200,
                    ContractNamespacesListIndex = 205,
                    MemberNamesListIndex = 207,
                    MemberNamespacesListIndex = 212,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 527, // Url
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        StableNameIndex = 527, // Url
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        TopLevelElementNameIndex = 527, // Url
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.Url, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.Url, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 217,
                    ContractNamespacesListIndex = 220,
                    MemberNamesListIndex = 222,
                    MemberNamespacesListIndex = 225,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 531, // ComicDataWrapper
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        StableNameIndex = 531, // ComicDataWrapper
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        TopLevelElementNameIndex = 531, // ComicDataWrapper
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.ComicDataWrapper, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, PublicKe" +
                                    "yToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.ComicDataWrapper, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, PublicKe" +
                                    "yToken=null")),
                    },
                    ChildElementNamespacesListIndex = 228,
                    ContractNamespacesListIndex = 236,
                    MemberNamesListIndex = 238,
                    MemberNamespacesListIndex = 246,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 548, // ComicDataContainer
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        StableNameIndex = 548, // ComicDataContainer
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        TopLevelElementNameIndex = 548, // ComicDataContainer
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.ComicDataContainer, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, Public" +
                                    "KeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.ComicDataContainer, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, Public" +
                                    "KeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 254,
                    ContractNamespacesListIndex = 260,
                    MemberNamesListIndex = 262,
                    MemberNamespacesListIndex = 268,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 584, // ComicBook
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        StableNameIndex = 584, // ComicBook
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        TopLevelElementNameIndex = 584, // ComicBook
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.ComicBook, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, PublicKeyToken=" +
                                    "null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.ComicBook, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, PublicKeyToken=" +
                                    "null")),
                    },
                    ChildElementNamespacesListIndex = 274,
                    ContractNamespacesListIndex = 304,
                    MemberNamesListIndex = 306,
                    MemberNamespacesListIndex = 336,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 594, // Characters
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        StableNameIndex = 594, // Characters
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        TopLevelElementNameIndex = 594, // Characters
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.Characters, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, PublicKeyToken" +
                                    "=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.Characters, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, PublicKeyToken" +
                                    "=null")),
                    },
                    ChildElementNamespacesListIndex = 366,
                    ContractNamespacesListIndex = 371,
                    MemberNamesListIndex = 373,
                    MemberNamespacesListIndex = 378,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 618, // Item2
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        StableNameIndex = 618, // Item2
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        TopLevelElementNameIndex = 618, // Item2
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.Item2, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null" +
                                    "")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.Item2, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null" +
                                    "")),
                    },
                    ChildElementNamespacesListIndex = 383,
                    ContractNamespacesListIndex = 386,
                    MemberNamesListIndex = 388,
                    MemberNamespacesListIndex = 391,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 697, // Creators
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        StableNameIndex = 697, // Creators
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        TopLevelElementNameIndex = 697, // Creators
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.Creators, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, PublicKeyToken=n" +
                                    "ull")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.Creators, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, PublicKeyToken=n" +
                                    "ull")),
                    },
                    ChildElementNamespacesListIndex = 394,
                    ContractNamespacesListIndex = 399,
                    MemberNamesListIndex = 401,
                    MemberNamespacesListIndex = 406,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 718, // Item
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        StableNameIndex = 718, // Item
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        TopLevelElementNameIndex = 718, // Item
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.Item, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.Item, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 411,
                    ContractNamespacesListIndex = 415,
                    MemberNamesListIndex = 417,
                    MemberNamespacesListIndex = 421,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 735, // Date
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        StableNameIndex = 735, // Date
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        TopLevelElementNameIndex = 735, // Date
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.Date, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.Date, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 425,
                    ContractNamespacesListIndex = 428,
                    MemberNamesListIndex = 430,
                    MemberNamespacesListIndex = 433,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 753, // Image
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        StableNameIndex = 753, // Image
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        TopLevelElementNameIndex = 753, // Image
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.Image, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null" +
                                    "")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.Image, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null" +
                                    "")),
                    },
                    ChildElementNamespacesListIndex = 436,
                    ContractNamespacesListIndex = 439,
                    MemberNamesListIndex = 441,
                    MemberNamespacesListIndex = 444,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 772, // Price
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        StableNameIndex = 772, // Price
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        TopLevelElementNameIndex = 772, // Price
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.Price, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null" +
                                    "")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.Price, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null" +
                                    "")),
                    },
                    ChildElementNamespacesListIndex = 447,
                    ContractNamespacesListIndex = 450,
                    MemberNamesListIndex = 452,
                    MemberNamespacesListIndex = 455,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 796, // TextObject
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        StableNameIndex = 796, // TextObject
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        TopLevelElementNameIndex = 796, // TextObject
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.TextObject, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, PublicKeyToken" +
                                    "=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.TextObject, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, PublicKeyToken" +
                                    "=null")),
                    },
                    ChildElementNamespacesListIndex = 458,
                    ContractNamespacesListIndex = 462,
                    MemberNamesListIndex = 464,
                    MemberNamespacesListIndex = 468,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 822, // Variant
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        StableNameIndex = 822, // Variant
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        TopLevelElementNameIndex = 822, // Variant
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.Variant, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nu" +
                                    "ll")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.Variant, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nu" +
                                    "ll")),
                    },
                    ChildElementNamespacesListIndex = 472,
                    ContractNamespacesListIndex = 475,
                    MemberNamesListIndex = 477,
                    MemberNamespacesListIndex = 480,
                }
        };
        static readonly byte[] s_collectionDataContracts_Hashtable = null;
        // Count=16
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::CollectionDataContractEntry[] s_collectionDataContracts = new global::CollectionDataContractEntry[] {
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 368, // ArrayOfCharacter
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        StableNameIndex = 368, // ArrayOfCharacter
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        TopLevelElementNameIndex = 368, // ArrayOfCharacter
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[MobileAppsProject2017.Models.Character, MobileAppsProject2017, Version=1.0.0." +
                                    "0, Culture=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToke" +
                                    "n=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[MobileAppsProject2017.Models.Character, MobileAppsProject2017, Version=1.0.0." +
                                    "0, Culture=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToke" +
                                    "n=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 385, // Character
                    KeyNameIndex = -1,
                    ItemNameIndex = 385, // Character
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.Character, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, PublicKeyToken=" +
                                "null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 402, // ArrayOfComic
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        StableNameIndex = 402, // ArrayOfComic
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        TopLevelElementNameIndex = 402, // ArrayOfComic
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[MobileAppsProject2017.Models.Comic, MobileAppsProject2017, Version=1.0.0.0, C" +
                                    "ulture=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b0" +
                                    "3f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[MobileAppsProject2017.Models.Comic, MobileAppsProject2017, Version=1.0.0.0, C" +
                                    "ulture=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b0" +
                                    "3f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 415, // Comic
                    KeyNameIndex = -1,
                    ItemNameIndex = 415, // Comic
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.Comic, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null" +
                                "")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 428, // ArrayOfEvent
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        StableNameIndex = 428, // ArrayOfEvent
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        TopLevelElementNameIndex = 428, // ArrayOfEvent
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[MobileAppsProject2017.Models.Event, MobileAppsProject2017, Version=1.0.0.0, C" +
                                    "ulture=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b0" +
                                    "3f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[MobileAppsProject2017.Models.Event, MobileAppsProject2017, Version=1.0.0.0, C" +
                                    "ulture=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b0" +
                                    "3f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 441, // Event
                    KeyNameIndex = -1,
                    ItemNameIndex = 441, // Event
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.Event, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null" +
                                "")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 458, // ArrayOfSeries
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        StableNameIndex = 458, // ArrayOfSeries
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        TopLevelElementNameIndex = 458, // ArrayOfSeries
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[MobileAppsProject2017.Models.Series, MobileAppsProject2017, Version=1.0.0.0, " +
                                    "Culture=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b" +
                                    "03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[MobileAppsProject2017.Models.Series, MobileAppsProject2017, Version=1.0.0.0, " +
                                    "Culture=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b" +
                                    "03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 472, // Series
                    KeyNameIndex = -1,
                    ItemNameIndex = 472, // Series
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.Series, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nul" +
                                "l")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 487, // ArrayOfStory
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        StableNameIndex = 487, // ArrayOfStory
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        TopLevelElementNameIndex = 487, // ArrayOfStory
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[MobileAppsProject2017.Models.Story, MobileAppsProject2017, Version=1.0.0.0, C" +
                                    "ulture=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b0" +
                                    "3f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[MobileAppsProject2017.Models.Story, MobileAppsProject2017, Version=1.0.0.0, C" +
                                    "ulture=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b0" +
                                    "3f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 500, // Story
                    KeyNameIndex = -1,
                    ItemNameIndex = 500, // Story
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.Story, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null" +
                                "")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 516, // ArrayOfUrl
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        StableNameIndex = 516, // ArrayOfUrl
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        TopLevelElementNameIndex = 516, // ArrayOfUrl
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[MobileAppsProject2017.Models.Url, MobileAppsProject2017, Version=1.0.0.0, Cul" +
                                    "ture=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f" +
                                    "5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[MobileAppsProject2017.Models.Url, MobileAppsProject2017, Version=1.0.0.0, Cul" +
                                    "ture=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f" +
                                    "5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 527, // Url
                    KeyNameIndex = -1,
                    ItemNameIndex = 527, // Url
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.Url, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 567, // ArrayOfComicBook
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        StableNameIndex = 567, // ArrayOfComicBook
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        TopLevelElementNameIndex = 567, // ArrayOfComicBook
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[MobileAppsProject2017.Models.ComicBook, MobileAppsProject2017, Version=1.0.0." +
                                    "0, Culture=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToke" +
                                    "n=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[MobileAppsProject2017.Models.ComicBook, MobileAppsProject2017, Version=1.0.0." +
                                    "0, Culture=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToke" +
                                    "n=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 584, // ComicBook
                    KeyNameIndex = -1,
                    ItemNameIndex = 584, // ComicBook
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.ComicBook, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, PublicKeyToken=" +
                                "null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 605, // ArrayOfItem2
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        StableNameIndex = 605, // ArrayOfItem2
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        TopLevelElementNameIndex = 605, // ArrayOfItem2
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[MobileAppsProject2017.Models.Item2, MobileAppsProject2017, Version=1.0.0.0, C" +
                                    "ulture=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b0" +
                                    "3f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[MobileAppsProject2017.Models.Item2, MobileAppsProject2017, Version=1.0.0.0, C" +
                                    "ulture=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b0" +
                                    "3f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 618, // Item2
                    KeyNameIndex = -1,
                    ItemNameIndex = 618, // Item2
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.Item2, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null" +
                                "")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 624, // ArrayOfanyType
                        NamespaceIndex = 639, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 624, // ArrayOfanyType
                        StableNameNamespaceIndex = 639, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 624, // ArrayOfanyType
                        TopLevelElementNamespaceIndex = 639, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, Publ" +
                                    "icKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11" +
                                    "d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, Publ" +
                                    "icKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11" +
                                    "d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 155, // anyType
                    KeyNameIndex = -1,
                    ItemNameIndex = 155, // anyType
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 706, // ArrayOfItem
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        StableNameIndex = 706, // ArrayOfItem
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        TopLevelElementNameIndex = 706, // ArrayOfItem
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[MobileAppsProject2017.Models.Item, MobileAppsProject2017, Version=1.0.0.0, Cu" +
                                    "lture=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03" +
                                    "f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[MobileAppsProject2017.Models.Item, MobileAppsProject2017, Version=1.0.0.0, Cu" +
                                    "lture=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03" +
                                    "f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 718, // Item
                    KeyNameIndex = -1,
                    ItemNameIndex = 718, // Item
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.Item, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 723, // ArrayOfDate
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        StableNameIndex = 723, // ArrayOfDate
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        TopLevelElementNameIndex = 723, // ArrayOfDate
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[MobileAppsProject2017.Models.Date, MobileAppsProject2017, Version=1.0.0.0, Cu" +
                                    "lture=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03" +
                                    "f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[MobileAppsProject2017.Models.Date, MobileAppsProject2017, Version=1.0.0.0, Cu" +
                                    "lture=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03" +
                                    "f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 735, // Date
                    KeyNameIndex = -1,
                    ItemNameIndex = 735, // Date
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.Date, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 740, // ArrayOfImage
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        StableNameIndex = 740, // ArrayOfImage
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        TopLevelElementNameIndex = 740, // ArrayOfImage
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[MobileAppsProject2017.Models.Image, MobileAppsProject2017, Version=1.0.0.0, C" +
                                    "ulture=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b0" +
                                    "3f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[MobileAppsProject2017.Models.Image, MobileAppsProject2017, Version=1.0.0.0, C" +
                                    "ulture=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b0" +
                                    "3f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 753, // Image
                    KeyNameIndex = -1,
                    ItemNameIndex = 753, // Image
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.Image, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null" +
                                "")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 759, // ArrayOfPrice
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        StableNameIndex = 759, // ArrayOfPrice
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        TopLevelElementNameIndex = 759, // ArrayOfPrice
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[MobileAppsProject2017.Models.Price, MobileAppsProject2017, Version=1.0.0.0, C" +
                                    "ulture=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b0" +
                                    "3f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[MobileAppsProject2017.Models.Price, MobileAppsProject2017, Version=1.0.0.0, C" +
                                    "ulture=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b0" +
                                    "3f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 772, // Price
                    KeyNameIndex = -1,
                    ItemNameIndex = 772, // Price
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.Price, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null" +
                                "")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 778, // ArrayOfTextObject
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        StableNameIndex = 778, // ArrayOfTextObject
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        TopLevelElementNameIndex = 778, // ArrayOfTextObject
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[MobileAppsProject2017.Models.TextObject, MobileAppsProject2017, Version=1.0.0" +
                                    ".0, Culture=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyTok" +
                                    "en=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[MobileAppsProject2017.Models.TextObject, MobileAppsProject2017, Version=1.0.0" +
                                    ".0, Culture=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyTok" +
                                    "en=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 796, // TextObject
                    KeyNameIndex = -1,
                    ItemNameIndex = 796, // TextObject
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.TextObject, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, PublicKeyToken" +
                                "=null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 807, // ArrayOfVariant
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        StableNameIndex = 807, // ArrayOfVariant
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        TopLevelElementNameIndex = 807, // ArrayOfVariant
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/MobileAppsProject2017.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[MobileAppsProject2017.Models.Variant, MobileAppsProject2017, Version=1.0.0.0," +
                                    " Culture=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=" +
                                    "b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[MobileAppsProject2017.Models.Variant, MobileAppsProject2017, Version=1.0.0.0," +
                                    " Culture=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=" +
                                    "b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 822, // Variant
                    KeyNameIndex = -1,
                    ItemNameIndex = 822, // Variant
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MobileAppsProject2017.Models.Variant, MobileAppsProject2017, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nu" +
                                "ll")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 624, // ArrayOfanyType
                        NamespaceIndex = 639, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 624, // ArrayOfanyType
                        StableNameNamespaceIndex = 639, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 624, // ArrayOfanyType
                        TopLevelElementNamespaceIndex = 639, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object[], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object[], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    CollectionItemNameIndex = 155, // anyType
                    KeyNameIndex = -1,
                    ItemNameIndex = 155, // anyType
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.Array,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }
        };
        static readonly byte[] s_enumDataContracts_Hashtable = null;
        // Count=0
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::EnumDataContractEntry[] s_enumDataContracts = new global::EnumDataContractEntry[0];
        static readonly byte[] s_xmlDataContracts_Hashtable = null;
        // Count=0
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::XmlDataContractEntry[] s_xmlDataContracts = new global::XmlDataContractEntry[0];
        static readonly byte[] s_jsonDelegatesList_Hashtable = null;
        // Count=41
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::JsonDelegateEntry[] s_jsonDelegatesList = new global::JsonDelegateEntry[] {
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 37,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type3.WriteCharacterDataWrapperToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type2.ReadCharacterDataWrapperFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 38,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type7.WriteCharacterDataContainerToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type6.ReadCharacterDataContainerFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 39,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type12.WriteArrayOfCharacterToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type11.ReadArrayOfCharacterFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type13.ReadArrayOfCharacterFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 40,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type17.WriteCharacterToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type16.ReadCharacterFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 41,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type21.WriteComicsToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type20.ReadComicsFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 42,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type26.WriteArrayOfComicToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type25.ReadArrayOfComicFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type27.ReadArrayOfComicFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 43,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type31.WriteComicToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type30.ReadComicFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 44,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type35.WriteEventsToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type34.ReadEventsFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 45,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type40.WriteArrayOfEventToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type39.ReadArrayOfEventFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type41.ReadArrayOfEventFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 46,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type45.WriteEventToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type44.ReadEventFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 47,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type49.WriteSeriesListToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type48.ReadSeriesListFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 48,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type54.WriteArrayOfSeriesToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type53.ReadArrayOfSeriesFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type55.ReadArrayOfSeriesFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 49,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type59.WriteSeriesToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type58.ReadSeriesFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 50,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type63.WriteStoriesToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type62.ReadStoriesFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 51,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type68.WriteArrayOfStoryToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type67.ReadArrayOfStoryFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type69.ReadArrayOfStoryFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 52,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type73.WriteStoryToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type72.ReadStoryFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 53,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type77.WriteThumbnailToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type76.ReadThumbnailFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 54,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type82.WriteArrayOfUrlToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type81.ReadArrayOfUrlFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type83.ReadArrayOfUrlFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 55,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type87.WriteUrlToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type86.ReadUrlFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 56,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type91.WriteComicDataWrapperToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type90.ReadComicDataWrapperFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 57,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type95.WriteComicDataContainerToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type94.ReadComicDataContainerFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 58,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type100.WriteArrayOfComicBookToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type99.ReadArrayOfComicBookFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type101.ReadArrayOfComicBookFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 59,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type105.WriteComicBookToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type104.ReadComicBookFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 60,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type109.WriteCharactersToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type108.ReadCharactersFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 61,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type114.WriteArrayOfItem2ToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type113.ReadArrayOfItem2FromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type115.ReadArrayOfItem2FromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 62,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type119.WriteItem2ToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type118.ReadItem2FromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 63,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type124.WriteArrayOfanyTypeToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type123.ReadArrayOfanyTypeFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type125.ReadArrayOfanyTypeFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 64,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type129.WriteCreatorsToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type128.ReadCreatorsFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 65,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type134.WriteArrayOfItemToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type133.ReadArrayOfItemFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type135.ReadArrayOfItemFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 66,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type139.WriteItemToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type138.ReadItemFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 67,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type144.WriteArrayOfDateToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type143.ReadArrayOfDateFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type145.ReadArrayOfDateFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 68,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type149.WriteDateToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type148.ReadDateFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 69,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type154.WriteArrayOfImageToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type153.ReadArrayOfImageFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type155.ReadArrayOfImageFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 70,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type159.WriteImageToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type158.ReadImageFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 71,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type164.WriteArrayOfPriceToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type163.ReadArrayOfPriceFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type165.ReadArrayOfPriceFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 72,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type169.WritePriceToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type168.ReadPriceFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 73,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type174.WriteArrayOfTextObjectToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type173.ReadArrayOfTextObjectFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type175.ReadArrayOfTextObjectFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 74,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type179.WriteTextObjectToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type178.ReadTextObjectFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 75,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type184.WriteArrayOfVariantToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type183.ReadArrayOfVariantFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type185.ReadArrayOfVariantFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 76,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type189.WriteVariantToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type188.ReadVariantFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 77,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type194.WriteArrayOfanyTypeToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type193.ReadArrayOfanyTypeFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type195.ReadArrayOfanyTypeFromJsonIsGetOnly),
                }
        };
        static char[] s_stringPool = new char[] {
            'b','o','o','l','e','a','n','\0','h','t','t','p',':','/','/','w','w','w','.','w','3','.','o','r','g','/','2','0','0','1',
            '/','X','M','L','S','c','h','e','m','a','\0','h','t','t','p',':','/','/','s','c','h','e','m','a','s','.','m','i','c','r',
            'o','s','o','f','t','.','c','o','m','/','2','0','0','3','/','1','0','/','S','e','r','i','a','l','i','z','a','t','i','o',
            'n','/','\0','b','a','s','e','6','4','B','i','n','a','r','y','\0','c','h','a','r','\0','d','a','t','e','T','i','m','e','\0',
            'd','e','c','i','m','a','l','\0','d','o','u','b','l','e','\0','f','l','o','a','t','\0','g','u','i','d','\0','i','n','t','\0',
            'l','o','n','g','\0','a','n','y','T','y','p','e','\0','Q','N','a','m','e','\0','s','h','o','r','t','\0','b','y','t','e','\0',
            's','t','r','i','n','g','\0','d','u','r','a','t','i','o','n','\0','u','n','s','i','g','n','e','d','B','y','t','e','\0','u',
            'n','s','i','g','n','e','d','I','n','t','\0','u','n','s','i','g','n','e','d','L','o','n','g','\0','u','n','s','i','g','n',
            'e','d','S','h','o','r','t','\0','a','n','y','U','R','I','\0','C','h','a','r','a','c','t','e','r','D','a','t','a','W','r',
            'a','p','p','e','r','\0','h','t','t','p',':','/','/','s','c','h','e','m','a','s','.','d','a','t','a','c','o','n','t','r',
            'a','c','t','.','o','r','g','/','2','0','0','4','/','0','7','/','M','o','b','i','l','e','A','p','p','s','P','r','o','j',
            'e','c','t','2','0','1','7','.','M','o','d','e','l','s','\0','C','h','a','r','a','c','t','e','r','D','a','t','a','C','o',
            'n','t','a','i','n','e','r','\0','A','r','r','a','y','O','f','C','h','a','r','a','c','t','e','r','\0','C','h','a','r','a',
            'c','t','e','r','\0','C','o','m','i','c','s','\0','A','r','r','a','y','O','f','C','o','m','i','c','\0','C','o','m','i','c',
            '\0','E','v','e','n','t','s','\0','A','r','r','a','y','O','f','E','v','e','n','t','\0','E','v','e','n','t','\0','S','e','r',
            'i','e','s','L','i','s','t','\0','A','r','r','a','y','O','f','S','e','r','i','e','s','\0','S','e','r','i','e','s','\0','S',
            't','o','r','i','e','s','\0','A','r','r','a','y','O','f','S','t','o','r','y','\0','S','t','o','r','y','\0','T','h','u','m',
            'b','n','a','i','l','\0','A','r','r','a','y','O','f','U','r','l','\0','U','r','l','\0','C','o','m','i','c','D','a','t','a',
            'W','r','a','p','p','e','r','\0','C','o','m','i','c','D','a','t','a','C','o','n','t','a','i','n','e','r','\0','A','r','r',
            'a','y','O','f','C','o','m','i','c','B','o','o','k','\0','C','o','m','i','c','B','o','o','k','\0','C','h','a','r','a','c',
            't','e','r','s','\0','A','r','r','a','y','O','f','I','t','e','m','2','\0','I','t','e','m','2','\0','A','r','r','a','y','O',
            'f','a','n','y','T','y','p','e','\0','h','t','t','p',':','/','/','s','c','h','e','m','a','s','.','m','i','c','r','o','s',
            'o','f','t','.','c','o','m','/','2','0','0','3','/','1','0','/','S','e','r','i','a','l','i','z','a','t','i','o','n','/',
            'A','r','r','a','y','s','\0','C','r','e','a','t','o','r','s','\0','A','r','r','a','y','O','f','I','t','e','m','\0','I','t',
            'e','m','\0','A','r','r','a','y','O','f','D','a','t','e','\0','D','a','t','e','\0','A','r','r','a','y','O','f','I','m','a',
            'g','e','\0','I','m','a','g','e','\0','A','r','r','a','y','O','f','P','r','i','c','e','\0','P','r','i','c','e','\0','A','r',
            'r','a','y','O','f','T','e','x','t','O','b','j','e','c','t','\0','T','e','x','t','O','b','j','e','c','t','\0','A','r','r',
            'a','y','O','f','V','a','r','i','a','n','t','\0','V','a','r','i','a','n','t','\0','a','t','t','r','i','b','u','t','i','o',
            'n','H','T','M','L','\0','a','t','t','r','i','b','u','t','i','o','n','T','e','x','t','\0','c','o','d','e','\0','c','o','p',
            'y','r','i','g','h','t','\0','d','a','t','a','\0','e','t','a','g','\0','s','t','a','t','u','s','\0','c','o','u','n','t','\0',
            'l','i','m','i','t','\0','o','f','f','s','e','t','\0','r','e','s','u','l','t','s','\0','t','o','t','a','l','\0','c','o','m',
            'i','c','s','\0','d','e','s','c','r','i','p','t','i','o','n','\0','e','v','e','n','t','s','\0','i','d','\0','m','o','d','i',
            'f','i','e','d','\0','n','a','m','e','\0','r','e','s','o','u','r','c','e','U','R','I','\0','s','e','r','i','e','s','\0','s',
            't','o','r','i','e','s','\0','t','h','u','m','b','n','a','i','l','\0','u','r','l','s','\0','a','v','a','i','l','a','b','l',
            'e','\0','c','o','l','l','e','c','t','i','o','n','U','R','I','\0','i','t','e','m','s','\0','r','e','t','u','r','n','e','d',
            '\0','t','y','p','e','\0','e','x','t','e','n','s','i','o','n','\0','l','a','r','g','e','\0','p','a','t','h','\0','s','m','a',
            'l','l','\0','u','r','l','\0','c','h','a','r','a','c','t','e','r','s','\0','c','o','l','l','e','c','t','e','d','I','s','s',
            'u','e','s','\0','c','o','l','l','e','c','t','i','o','n','s','\0','c','r','e','a','t','o','r','s','\0','d','a','t','e','s',
            '\0','d','i','a','m','o','n','d','C','o','d','e','\0','d','i','g','i','t','a','l','I','d','\0','e','a','n','\0','f','o','r',
            'm','a','t','\0','i','m','a','g','e','s','\0','i','s','b','n','\0','i','s','s','n','\0','i','s','s','u','e','N','u','m','b',
            'e','r','\0','p','a','g','e','C','o','u','n','t','\0','p','r','i','c','e','s','\0','t','e','x','t','O','b','j','e','c','t',
            's','\0','t','i','t','l','e','\0','u','p','c','\0','v','a','r','i','a','n','t','D','e','s','c','r','i','p','t','i','o','n',
            '\0','v','a','r','i','a','n','t','s','\0','r','o','l','e','\0','d','a','t','e','\0','p','r','i','c','e','\0','l','a','n','g',
            'u','a','g','e','\0','t','e','x','t','\0'};
    }
}
