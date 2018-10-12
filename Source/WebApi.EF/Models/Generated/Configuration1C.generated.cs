//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
//
//     Produced by Entity Framework Visual Editor
//     https://github.com/msawczyn/EFDesigner
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;

namespace WebApi.EF.Models
{
   public partial class Configuration1C
   {
      partial void Init();

      /// <summary>
      /// Default constructor. Protected due to required properties, but present because EF needs it.
      /// </summary>
      protected Configuration1C()
      {
         ArticleDependencies = new System.Collections.Generic.HashSet<WebApi.EF.Models.ArticleDependencies>();

         Init();
      }

      /// <summary>
      /// Public constructor with required data
      /// </summary>
      /// <param name="_name"></param>
      public Configuration1C(string _name)
      {
         if (string.IsNullOrEmpty(_name)) throw new ArgumentNullException(nameof(_name));
         Name = _name;
         ArticleDependencies = new HashSet<WebApi.EF.Models.ArticleDependencies>();
         Init();
      }

      /// <summary>
      /// Static create function (for use in LINQ queries, etc.)
      /// </summary>
      /// <param name="_name"></param>
      public static Configuration1C Create(string _name)
      {
         return new Configuration1C(_name);
      }

      // Persistent properties

      /// <summary>
      /// Identity, Required, Indexed
      /// </summary>
      [Key]
      [Required]
      public int Id { get; set; }

      /// <summary>
      /// Required, Min length = 1
      /// </summary>
      [Required]
      public string Name { get; set; }

      // Persistent navigation properties

      public virtual ICollection<WebApi.EF.Models.ArticleDependencies> ArticleDependencies { get; set; }

   }
}
