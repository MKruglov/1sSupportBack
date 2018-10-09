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

namespace WebApi.EF.Design
{
   public partial class User
   {
      partial void Init();

      /// <summary>
      /// Default constructor. Protected due to required properties, but present because EF needs it.
      /// </summary>
      protected User()
      {
         Session = new System.Collections.Generic.HashSet<WebApi.EF.Design.Session>();

         Init();
      }

      /// <summary>
      /// Public constructor with required data
      /// </summary>
      /// <param name="_provider"></param>
      public User(WebApi.EF.Design.Provider _provider)
      {
         if (_provider == null) throw new ArgumentNullException(nameof(_provider));
         Provider = _provider;

         Session = new HashSet<WebApi.EF.Design.Session>();
         Init();
      }

      /// <summary>
      /// Static create function (for use in LINQ queries, etc.)
      /// </summary>
      /// <param name="_provider"></param>
      public static User Create(WebApi.EF.Design.Provider _provider)
      {
         return new User(_provider);
      }

      // Persistent properties

      /// <summary>
      /// Identity, Required, Indexed
      /// </summary>
      [Key]
      [Required]
      public int Id { get; set; }

      public string Login { get; set; }

      public string Email { get; set; }

      public string INN { get; set; }

      // Persistent navigation properties

      public virtual ICollection<WebApi.EF.Design.Session> Session { get; set; }

      /// <summary>
      /// Required
      /// </summary>
      public virtual WebApi.EF.Design.Provider Provider { get; set; }

   }
}

