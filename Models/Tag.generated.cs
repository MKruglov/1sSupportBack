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

namespace Models
{
   public partial class Tag
   {
      partial void Init();

      /// <summary>
      /// Default constructor. Protected due to required properties, but present because EF needs it.
      /// </summary>
      protected Tag()
      {
         Init();
      }

      /// <summary>
      /// Public constructor with required data
      /// </summary>
      /// <param name="_articletag0"></param>
      public Tag(Models.ArticleTag _articletag0)
      {
         if (_articletag0 == null) throw new ArgumentNullException(nameof(_articletag0));
         _articletag0.Tags = this;

         Init();
      }

      /// <summary>
      /// Static create function (for use in LINQ queries, etc.)
      /// </summary>
      /// <param name="_articletag0"></param>
      public static Tag Create(Models.ArticleTag _articletag0)
      {
         return new Tag(_articletag0);
      }

      // Persistent properties

      /// <summary>
      /// Identity, Required, Indexed
      /// </summary>
      [Key]
      [Required]
      public int Id { get; set; }

      // Persistent navigation properties

   }
}

