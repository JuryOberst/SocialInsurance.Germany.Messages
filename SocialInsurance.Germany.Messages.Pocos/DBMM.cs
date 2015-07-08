﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialInsurance.Germany.Messages.Pocos
{
    /// <summary>
    /// Datenbaustein: DBMM - Meldesachverhalt GKV-Monatsmeldung
    /// </summary>
    public class DBMM : IDatenbaustein
    {
        /// <summary>
        /// Initialisier eine neue Instanz der <see cref="DBMM"/> Klasse
        /// </summary>
        public DBMM() 
        {
            KE = "DBMM";
        }

        /// <summary>
        /// Holt oder setzt die Kennung
        /// </summary>
        /// <remarks>
        /// Kennung, um welchen Datenbaustein es sich handelt
        /// </remarks>
        public string KE { get; set; }

        /// <summary>
        /// Hol oder setzt das GKV-Monatsmeldung Kennzeichen
        /// </summary>
        /// <remarks>
        /// Kennzeichen, ob eine GKVMonatsmeldung abzugeben ist, Länge 1, Mussangabe
        /// </remarks>
        public string KENNZMOME { get; set; }

        /// <summary>
        /// Holt oder setzt den Beginn des Zeitraums, für den die Meldung gelten soll
        /// </summary>
        /// <remarks>
        /// Beginn des Zeitraums, für den die Meldung gelten soll, Länge 8, Mussangabe
        /// </remarks>
        public DateTime ZRBG { get; set; }

        /// <summary>
        /// Holt oder setzt das Ende des Zeitraums, für den die Meldung gelten soll
        /// </summary>
        /// <remarks>
        /// Ende des Zeitraums, für den die Meldung gelten soll, Länge 8, Mussangabe
        /// </remarks>
        public DateTime ZREN { get; set; }
    }
}