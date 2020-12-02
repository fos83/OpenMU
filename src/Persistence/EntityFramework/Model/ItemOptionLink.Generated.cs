// <copyright file="ItemOptionLink.Generated.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

//------------------------------------------------------------------------------
// <auto-generated>
//     This source code was auto-generated by a roslyn code generator.
// </auto-generated>
//------------------------------------------------------------------------------

// ReSharper disable All

namespace MUnique.OpenMU.Persistence.EntityFramework.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using MUnique.OpenMU.Persistence;
    
    /// <summary>
    /// The Entity Framework Core implementation of <see cref="MUnique.OpenMU.DataModel.Entities.ItemOptionLink"/>.
    /// </summary>
    [Table(nameof(ItemOptionLink), Schema = "data")]
    internal partial class ItemOptionLink : MUnique.OpenMU.DataModel.Entities.ItemOptionLink, IIdentifiable
    {
        
        
        /// <summary>
        /// Gets or sets the identifier of this instance.
        /// </summary>
        public Guid Id { get; set; }
        
        /// <summary>
        /// Gets or sets the identifier of <see cref="ItemOption"/>.
        /// </summary>
        public Guid? ItemOptionId { get; set; }

        /// <summary>
        /// Gets the raw object of <see cref="ItemOption" />.
        /// </summary>
        [ForeignKey(nameof(ItemOptionId))]
        public IncreasableItemOption RawItemOption
        {
            get => base.ItemOption as IncreasableItemOption;
            set => base.ItemOption = value;
        }

        /// <inheritdoc/>
        [NotMapped]
        public override MUnique.OpenMU.DataModel.Configuration.Items.IncreasableItemOption ItemOption
        {
            get => base.ItemOption;set
            {
                base.ItemOption = value;
                this.ItemOptionId = this.RawItemOption?.Id;
            }
        }


        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            var baseObject = obj as IIdentifiable;
            if (baseObject != null)
            {
                return baseObject.Id == this.Id;
            }

            return base.Equals(obj);
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }

        
    }
}