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
    
    public partial class StatEquipe
    {
        public int Id { get; set; }
        public int but { get; set; }
        public int etat { get; set; }
        public int domicile { get; set; }
        public int possession { get; set; }
        public int hors_jeu { get; set; }
        public int corner { get; set; }
        public int id_equipe { get; set; }
        public int id_match { get; set; }
    
        public virtual Equipe Equipe { get; set; }
        public virtual Match Match { get; set; }
    }
}
