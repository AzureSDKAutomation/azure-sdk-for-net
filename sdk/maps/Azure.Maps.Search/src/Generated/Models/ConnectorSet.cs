// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Azure.Maps.Search.Models
{

    /// <summary>
    /// Defines values for ConnectorSet.
    /// </summary>
    public static class ConnectorSet
    {
        /// <summary>
        /// These are the standard household connectors for a certain region.
        /// They are all AC single phase and the standard Voltage and standard
        /// Amperage.
        ///
        /// See also: [Plug & socket types - World
        /// Standards](https://www.worldstandards.eu/electricity/plugs-and-sockets)
        /// </summary>
        public const string StandardHouseholdCountrySpecific = "StandardHouseholdCountrySpecific";
        /// <summary>
        /// Type 1 connector as defined in the IEC 62196-2 standard. Also
        /// called Yazaki after the original manufacturer or SAE J1772 after
        /// the standard that first published it. Mostly used in combination
        /// with 120V single phase or up to 240V single phase infrastructure.
        /// </summary>
        public const string IEC62196Type1 = "IEC62196Type1";
        /// <summary>
        /// Type 1 based combo connector as defined in the IEC 62196-3
        /// standard. The connector is based on the Type 1 connector – as
        /// defined in the IEC 62196-2 standard – with two additional direct
        /// current (DC) contacts to allow DC fast charging.
        /// </summary>
        public const string IEC62196Type1CCS = "IEC62196Type1CCS";
        /// <summary>
        /// Type 2 connector as defined in the IEC 62196-2 standard. Provided
        /// as a cable and plug attached to the charging point
        /// </summary>
        public const string IEC62196Type2CableAttached = "IEC62196Type2CableAttached";
        /// <summary>
        /// Type 2 connector as defined in the IEC 62196-2 standard. Provided
        /// as a socket set into the charging point.
        /// </summary>
        public const string IEC62196Type2Outlet = "IEC62196Type2Outlet";
        /// <summary>
        /// Type 2 based combo connector as defined in the IEC 62196-3
        /// standard. The connector is based on the Type 2 connector – as
        /// defined in the IEC 62196-2 standard – with two additional direct
        /// current (DC) contacts to allow DC fast charging.
        /// </summary>
        public const string IEC62196Type2CCS = "IEC62196Type2CCS";
        /// <summary>
        /// Type 3 connector as defined in the IEC 62196-2 standard. Also
        /// called Scame after the original manufacturer. Mostly used in
        /// combination with up to 240V single phase or up to 420V three phase
        /// infrastructure.
        /// </summary>
        public const string IEC62196Type3 = "IEC62196Type3";
        /// <summary>
        /// CHAdeMO connector named after an association formed by the Tokyo
        /// Electric Power Company and industrial partners. Because of this is
        /// is also known as the TEPCO's connector. It supports fast DC
        /// charging.
        /// </summary>
        public const string Chademo = "Chademo";
        /// <summary>
        /// Industrial Blue connector is a connector defined in the IEC 60309
        /// standard. It is sometime referred to as by some combination of the
        /// standard, the color and the fact that is a single phase connector.
        /// The connector usually has the "P+N+E, 6h" configuration.
        /// </summary>
        public const string IEC60309AC1PhaseBlue = "IEC60309AC1PhaseBlue";
        /// <summary>
        /// Industrial White connector is a DC connector defined in the IEC
        /// 60309 standard.
        /// </summary>
        public const string IEC60309DCWhite = "IEC60309DCWhite";
        /// <summary>
        /// The Tesla connector is the regionally specific Tesla Supercharger
        /// connector. I.e. it refers to either Tesla's proprietary connector,
        /// sometimes referred to as Tesla Port mostly limited to North America
        /// or the modified Type 2 (DC over Type 2) in Europe.
        /// </summary>
        public const string Tesla = "Tesla";
    }
}
