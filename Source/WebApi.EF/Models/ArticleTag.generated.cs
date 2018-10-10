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
   public partial class ArticleTag
   {
      partial void Init();

      /// <summary>
      /// Default constructor. Protected due to required properties, but present because EF needs it.
      /// </summary>
      protected ArticleTag()
      {
         Init();
      }

      /// <summary>
      /// Public constructor with required data
      /// </summary>
      /// <param name="_article"></param>
      /// <param name="_tag"></param>
      public ArticleTag(WebApi.EF.Models.Article _article, WebApi.EF.Models.Tag _tag)
      {
         if (_article == null) throw new ArgumentNullException(nameof(_article));
         Article = _article;

         if (_tag == null) throw new ArgumentNullException(nameof(_tag));
         Tag = _tag;

         Init();
      }

      /// <summary>
      /// Static create function (for use in LINQ queries, etc.)
      /// </summary>
      /// <param name="_article"></param>
      /// <param name="_tag"></param>
      public static ArticleTag Create(WebApi.EF.Models.Article _article, WebApi.EF.Models.Tag _tag)
      {
         return new ArticleTag(_article, _tag);
      }

      // Persistent properties

      /// <summary>
      /// Identity, Required, Indexed
      /// </summary>
      [Key]
      [Required]
      public int ID { get; internal set; }

      // Persistent navigation properties

      /// <summary>
      /// Required
      /// </summary>
      public virtual WebApi.EF.Models.Article Article { get; set; }

      /// <summary>
      /// Required
      /// </summary>
      public virtual WebApi.EF.Models.Tag Tag { get; set; }

   }
}

