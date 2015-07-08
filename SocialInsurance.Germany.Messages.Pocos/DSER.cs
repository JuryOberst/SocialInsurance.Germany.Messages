﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialInsurance.Germany.Messages.Pocos
{
    /// <summary>
    /// Datensatz: DSER - Erstattungen der Arbeitgeberaufwendungen
    /// </summary>
    public class DSER : IDatensatz
    {
        private bool? _hatDbau;

        private bool? _hatDbbt;

        private bool? _hatDbzu;

        private bool? _hatDbbv;

        private bool? _hatDbna;

        private bool? _hatDbaa;

        private FehlerKennzeichen? _fekz;

        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DSER"/> Klasse.
        /// </summary>
        /// <remarks>
        /// Beim Initialisieren werden die Konstanten, wie Kennung und Verfahren gesetzt.
        /// </remarks>
        public DSER()
        {
            KE = "DSER";
            VF = "AAGER";
            VERNR = 2;
        }

        /// <summary>
        /// Holt oder setzt die Kennung
        /// </summary>
        /// <remarks>
        /// Kennung, um welchen Datensatz es sich handelt.
        /// </remarks>
        public string KE { get; set; }

        /// <summary>
        /// Holt oder setzt das Verfahren
        /// </summary>
        /// <remarks>
        /// Verfahren, für das der Datensatz bestimmt ist, Länge 5, Mussangabe
        /// DEUEV = DEÜV- Meldeverfahren
        /// </remarks>
        public string VF { get; set; }

        /// <summary>
        /// Holt oder setzt die Betriebsnummer des Erstellers des Datensatzes
        /// </summary>
        /// <remarks>
        ///  Betriebsnummer des Erstellers des Datensatzes, Länge 15, (8 Stellen linksbündig mit nachfolgenden Leerzeichen), Mussangabe
        /// </remarks>
        public string BBNRAB { get; set; }

        /// <summary>
        /// Holt oder setzt die Betriebsnummer des Empfängers des Datensatzes
        /// </summary>
        /// <remarks>
        /// Betriebsnummer des Empfängers des Datensatzes, Länge 15, (8 Stellen linksbündig mit nachfolgenden Leerzeichen), Mussangabe
        /// </remarks>
        public string BBNREP { get; set; }

        /// <summary>
        /// Holt oder setzt die Versionsnummer des übermittelten Datensatzes
        /// </summary>
        /// <remarks>
        /// Versionsnummer des übermittelten Datensatzes, Länge 2, Mussangabe
        /// </remarks>
        public int VERNR { get; set; }

        /// <summary>
        /// Holt oder setzt den Zeitpunkt der Erstellung des Dateznsatzes
        /// </summary>
        /// <remarks>
        /// Zeitpunkt der Erstellung des Datensatzes, Länge 20, jhjjmmtt (Datum) hhmmss (Uhrzeit) msmsms (Mikrosekunde) (Wert > 0 in letzten 6 Stellen optional), Mussangabe
        /// </remarks>
        public DateTime ED { get; set; }

        /// <summary>
        /// Holt oder setzt die Kennzeichnung für fehlerhafte Datensätze
        /// </summary>
        /// <remarks>
        /// Kennzeichnung für fehlerhafte Datensätze, Länge 1, 0 = Datensatz fehlerfrei 1 = Datensatz fehlerhaft, Mussangabe
        /// </remarks>
        public FehlerKennzeichen FEKZ
        {
            get { return _fekz ?? (DBFE == null || DBFE.Count == 0 ? FehlerKennzeichen.Fehlerfrei : FehlerKennzeichen.Fehlerhaft); }
            set { _fekz = value; }
        }

        /// <summary>
        /// Holt oder setzt die Anzahl der Fehler des Datensatzes
        /// </summary>
        /// <remarks>
        /// Anzahl der Fehler des Datensatzes, Länge 1, Mussangabe
        /// </remarks>
        public int FEAN
        {
            get { return DBFE == null ? 0 : DBFE.Count; }
            private set { }
        }

        /// <summary>
        /// Holt oder setzt die Versicherungsnummer
        /// </summary>
        /// <remarks>
        /// Versicherungsnummer in der Form: bbttmmjjassp, Länge 12, Pflichtangabe, soweit bekannt
        /// </remarks>
        public string VSNR { get; set; }

        /// <summary>
        /// Holt oder setzt das Geburtsdatum des Versicherten im Format
        /// </summary>
        /// <remarks>
        /// Geburtsdatum des Versicherten im Format, Länge 8, Mussangabe
        /// </remarks>
        public string GEBDA { get; set; }

        /// <summary>
        /// Holt oder setzt die Betriebsnummer des Verursachers des Datensatzes
        /// </summary>
        /// <remarks>
        /// Betriebsnummer des Verursachers des Datensatzes, Länge 15, Mussangabe
        /// Bei der Datenübermittlung zwischen dem Arbeitgeber und der Krankenkasse
        /// ist hier die Betriebsnummer des Beschäftigungsbetriebes anzugeben.
        /// </remarks>
        public string BBNRVU { get; set; }

        /// <summary>
        /// Dieses Feld steht dem Verursacher zur Verfügung
        /// </summary>
        /// <remarks>
        /// Dieses Feld steht dem Verursacher zur Verfügung, Länge 20, Kannangabe
        /// Bei der Datenübermittlung zwischen dem Arbeitgeber und der Krankenkasse:
        /// z. B. Aktenzeichen / Personalnummer des Beschäftigten 
        /// </remarks>
        public string AZVU { get; set; }

        /// <summary>
        /// Dieses Feld steht der Abrechnungsstelle (z. B. Steuerberater, Rechenzentrum, Arbeitgeber) zur Verfügung 
        /// </summary>
        /// <remarks>
        /// Dieses Feld steht der Abrechnungsstelle (z. B. Steuerberater, Rechenzentrum, Arbeitgeber) zur Verfügung, Länge 20
        /// Identifikationsnummer des Datensatzes 
        /// </remarks>
        public string DSID { get; set; }

        /// <summary>
        /// Holt oder setzt die Betriebsnummer der für den Beschäftigten zuständigen Krankenkasse
        /// </summary>
        /// <remarks>
        /// Betriebsnummer der für den Beschäftigten zuständigen Krankenkasse, Länge 15, Mussangabe
        /// </remarks>
        public string BBNRKK { get; set; }

        /// <summary>
        /// Dieses Feld steht der Krankenkasse zur Verfügung.
        /// </summary>
        /// <remarks>
        /// Dieses Feld steht der Krankenkasse zur Verfügung, Länge 20, Pflichtangabe, soweit bekannt
        /// </remarks>
        public string AZKK { get; set; }

        /// <summary>
        /// Holt oder setzt die Betriebsnummer der Abrechnungsstelle
        /// </summary>
        /// <remarks>
        /// Betriebsnummer der Abrechnungsstelle, z. B. Steuerberater, Länge 15, Pflichtangabe, soweit bekannt
        /// 8 Stellen linksbündig mit nachfolgenden Leerzeichen
        /// </remarks>
        public string BBNRAS { get; set; }

        /// <summary>
        /// Holt oder setzt den Grund der Abgabe
        /// </summary>
        /// <remarks>
        /// Grund der Abgabe, Länge 2, Mussangabe
        /// 01 = bei Arbeitsunfähigkeit, 02 = bei Beschäftigungsverbot nach dem MuSchG
        /// 03 = bei Mutterschaft
        /// </remarks>
        public int GD { get; set; }

        /// <summary>
        /// Holt oder setzt den Beschäftigungsbeginn
        /// </summary>
        /// <remarks>
        /// Beschäftigungsbeginn in der Form: jhjjmmtt, Länge 8, Mussangabe
        /// </remarks>
        public DateTime BESCHSEIT { get; set; }

        /// <summary>
        /// Holt oder setzt die Art der Versicherung
        /// </summary>
        /// <remarks>
        /// Art der Versicherung, Länge 1, Mussangabe
        /// 0 = in der GKV versichert, 1 = privat versichert
        /// 2 = LKK-versichert, 3 = geringfügige Beschäftigung
        /// </remarks>
        public int ARTVERS { get; set; }

        /// <summary>
        /// Holt oder setzt das Geschlecht
        /// </summary>
        /// <remarks>
        /// Geschlecht, Länge 1, Mussangabe
        /// M = Männlich, W = Weiblich
        /// </remarks>
        public string GE { get; set; }

        /// <summary>
        /// Holt oder setzt die Art des verwendeten Abrechnungsprogramms
        /// </summary>
        /// <remarks>
        /// Art des verwendeten Abrechnungsprogramms, Länge 1, Mussangabe
        /// 1 = systemgeprüftes Entgeltabrechnungsprogramm
        /// 2 = systemgeprüfte Ausfüllhilfe
        /// </remarks>
        public int APRO { get; set; }

        /// <summary>
        /// Holt oder setzt das Reservefeld
        /// </summary>
        /// <remarks>
        /// Reservefeld, Blank = Grundstellung, Länge 16, Mussangabe
        /// </remarks>
        public string RESERVE { get; set; }

        /// <summary>
        /// Holt oder setzt das Vorhandensein von Erstattungen Arbeitgeberaufwendungen Arbeitsunfähigkeit
        /// </summary>
        /// <remarks>
        /// Datenbaustein DBAU, Länge 1, Mussangabe
        /// Erstattungen Arbeitgeberaufwendungen Arbeitsunfähigkeit vorhanden:
        /// N = Nein, J = Ja
        /// </remarks>
        public bool MMDBAU
        {
            get { return _hatDbau ?? Arbeitsunfähigkeit != null; }
            set { _hatDbau = value; }
        }

        /// <summary>
        /// Holt oder setzt das Vorhandensein von Erstattungen Beschäftigungsverbot
        /// </summary>
        /// <remarks>
        /// Datenbaustein DBBT, Länge 1, Mussangabe
        /// Erstattungen Beschäftigungsverbot vorhanden:
        /// N = Nein, J = Ja
        /// </remarks>
        public bool MMDBBT
        {
            get { return _hatDbbt ?? Beschäftigungsverbot != null; }
            set { _hatDbbt = value; }
        }

        /// <summary>
        /// Holt oder setzt das Vorhandensein von Erstattungen Mutterschaft
        /// </summary>
        /// <remarks>
        /// Datenbaustein DBZU, Länge 1, Mussangabe
        /// Erstattungen Mutterschaft vorhanden:
        /// N = Nein, J = Ja
        /// </remarks>
        public bool MMDBZU
        {
            get { return _hatDbzu ?? Mutterschaft != null; }
            set { _hatDbzu = value; }
        }

        /// <summary>
        /// Holt oder setzt das Vorhandensein von Bankverbindung
        /// </summary>
        /// <remarks>
        /// Datenbaustein DBBV, Länge 1, Mussangabe
        /// Bankverbindung vorhanden: J = Ja
        /// </remarks>
        public bool MMDBBV
        {
            get { return _hatDbbv ?? Bankverbindung != null; }
            set { _hatDbbv = value; }
        }

        /// <summary>
        /// Holt oder setzt das Vorhandensein von Name
        /// </summary>
        /// <remarks>
        /// Datenbaustein DBNA, Länge 1, Mussangabe
        /// Name vorhanden: J = Ja
        /// </remarks>
        public bool MMDBNA
        {
            get { return _hatDbna ?? Name != null; }
            set { _hatDbna = value; }
        }
        /// <summary>
        /// Holt oder setzt das Vorhandensein von Ansprechpartner Arbeitgeber
        /// </summary>
        /// <remarks>
        /// Datenbaustein DBAA, Länge 1, Mussangabe
        /// Ansprechpartner Arbeitgeber vorhanden: N = Nein, J = Ja

        /// </remarks>
        public bool MMDBAA
        {
            get { return _hatDbaa ?? Ansprechpartner != null; }
            set { _hatDbaa = value; }
        }

        public DBAU Arbeitsunfähigkeit
        {
            get
            {
                return ListeDBAU == null ? null : ListeDBAU.SingleOrDefault();
            }
            set
            {
                ListeDBAU = ListeDBAU.Set(value);
                _hatDbau = null;
            }
        }

        public DBBT Beschäftigungsverbot
        {
            get
            {
                return ListeDBBT == null ? null : ListeDBBT.SingleOrDefault();
            }
            set
            {
                ListeDBBT = ListeDBBT.Set(value);
                _hatDbbt = null;
            }
        }

        public DBZU Mutterschaft
        {
            get
            {
                return ListeDBZU == null ? null : ListeDBZU.SingleOrDefault();
            }
            set
            {
                ListeDBZU = ListeDBZU.Set(value);
                _hatDbzu = null;
            }
        }

        public DBBV Bankverbindung
        {
            get
            {
                return ListeDBBV == null ? null : ListeDBBV.SingleOrDefault();
            }
            set
            {
                ListeDBBV = ListeDBBV.Set(value);
                _hatDbbv = null;
            }
        }

        public DBNA Name
        {
            get
            {
                return ListeDBNA == null ? null : ListeDBNA.SingleOrDefault();
            }
            set
            {
                ListeDBNA = ListeDBNA.Set(value);
                _hatDbna = null;
            }
        }

        public DBAA Ansprechpartner
        {
            get
            {
                return ListeDBAA == null ? null : ListeDBAA.SingleOrDefault();
            }
            set
            {
                ListeDBAA = ListeDBAA.Set(value);
                _hatDbaa = null;
            }
        }

        private IList<DBAU> ListeDBAU { get; set; }

        private IList<DBBT> ListeDBBT { get; set; }

        private IList<DBZU> ListeDBZU { get; set; }

        private IList<DBBV> ListeDBBV { get; set; }

        private IList<DBNA> ListeDBNA { get; set; }

        private IList<DBAA> ListeDBAA { get; set; }

        private IList<DBFE> DBFE { get; set; }
    }
}
