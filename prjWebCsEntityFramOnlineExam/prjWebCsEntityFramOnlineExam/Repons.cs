//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace prjWebCsEntityFramOnlineExam
{
    using System;
    using System.Collections.Generic;
    
    public partial class Repons
    {
        public string ReponseID { get; set; }
        public string Reponse { get; set; }
        public Nullable<int> Valeur { get; set; }
        public string RefQuestion { get; set; }
    
        public virtual Question Question { get; set; }
    }
}