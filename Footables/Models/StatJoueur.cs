//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Footables.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class StatJoueur
    {
        public int Id { get; set; }
        public int but { get; set; }
        public int decisive { get; set; }
        public int tir { get; set; }
        public int cadre { get; set; }
        public int interception { get; set; }
        public int tacle { get; set; }
        public int faute { get; set; }
        public int jaune { get; set; }
        public int rouge { get; set; }
        public int arret { get; set; }
        public int encaisse { get; set; }
        public int id_joueur { get; set; }
        public int id_match { get; set; }
    
        public virtual Joueur Joueur { get; set; }
        public virtual Match Match { get; set; }
    }
}
