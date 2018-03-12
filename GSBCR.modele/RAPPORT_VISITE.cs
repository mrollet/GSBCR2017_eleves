//------------------------------------------------------------------------------
// <auto-generated>
//    Ce code a été généré à partir d'un modèle.
//
//    Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//    Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GSBCR.modele
{
    using System;
    using System.Collections.Generic;
    
    public partial class RAPPORT_VISITE
    {
        public RAPPORT_VISITE()
        {
            this.LesEchantillonsOfferts = new HashSet<OFFRIR>();
        }
    
        public string RAP_MATRICULE { get; set; }
        public int RAP_NUM { get; set; }
        public short RAP_PRANUM { get; set; }
        public System.DateTime RAP_DATE { get; set; }
        public System.DateTime RAP_DATVISIT { get; set; }
        public string RAP_ETAT { get; set; }
        public string RAP_CONFIANCE { get; set; }
        public string RAP_BILAN { get; set; }
        public string RAP_MOTIF { get; set; }
        public string RAP_MOTIFAUTRE { get; set; }
        public string RAP_NOMREMPL { get; set; }
        public string RAP_PNOMREMPL { get; set; }
        public string RAP_MED1 { get; set; }
        public string RAP_MED2 { get; set; }
    
        public virtual MEDICAMENT leMedicament1 { get; set; }
        public virtual MEDICAMENT LeMedicament2 { get; set; }
        public virtual MOTIF_VISITE LeMotifVisite { get; set; }
        public virtual ICollection<OFFRIR> LesEchantillonsOfferts { get; set; }
        public virtual PRATICIEN LePraticien { get; set; }
        public virtual VISITEUR LeVisiteur { get; set; }
    }
}
