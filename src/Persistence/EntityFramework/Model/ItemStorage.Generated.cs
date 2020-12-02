// <copyright file="ItemStorage.Generated.cs" company="MUnique">
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
    /// The Entity Framework Core implementation of <see cref="MUnique.OpenMU.DataModel.Entities.ItemStorage"/>.
    /// </summary>
    [Table(nameof(ItemStorage), Schema = "data")]
    internal partial class ItemStorage : MUnique.OpenMU.DataModel.Entities.ItemStorage, IIdentifiable
    {
        
        
        /// <summary>
        /// Gets or sets the identifier of this instance.
        /// </summary>
        public Guid Id { get; set; }
        
        /// <summary>
        /// Gets the raw collection of <see cref="Items" />.
        /// </summary>
        public ICollection<Item> RawItems { get; } = new EntityFramework.List<Item>();
        
        /// <inheritdoc/>
        [NotMapped]
        public override ICollection<MUnique.OpenMU.DataModel.Entities.Item> Items => base.Items ??= new CollectionAdapter<MUnique.OpenMU.DataModel.Entities.Item, Item>(this.RawItems);


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