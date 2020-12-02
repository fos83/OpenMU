// <copyright file="IncreasableItemOption.Generated.cs" company="MUnique">
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
    /// The Entity Framework Core implementation of <see cref="MUnique.OpenMU.DataModel.Configuration.Items.IncreasableItemOption"/>.
    /// </summary>
    [Table(nameof(IncreasableItemOption), Schema = "config")]
    internal partial class IncreasableItemOption : MUnique.OpenMU.DataModel.Configuration.Items.IncreasableItemOption, IIdentifiable
    {
        
        
        /// <summary>
        /// Gets or sets the identifier of this instance.
        /// </summary>
        public Guid Id { get; set; }
        
        /// <summary>
        /// Gets the raw collection of <see cref="LevelDependentOptions" />.
        /// </summary>
        public ICollection<ItemOptionOfLevel> RawLevelDependentOptions { get; } = new EntityFramework.List<ItemOptionOfLevel>();
        
        /// <inheritdoc/>
        [NotMapped]
        public override ICollection<MUnique.OpenMU.DataModel.Configuration.Items.ItemOptionOfLevel> LevelDependentOptions => base.LevelDependentOptions ??= new CollectionAdapter<MUnique.OpenMU.DataModel.Configuration.Items.ItemOptionOfLevel, ItemOptionOfLevel>(this.RawLevelDependentOptions);

        /// <summary>
        /// Gets or sets the identifier of <see cref="OptionType"/>.
        /// </summary>
        public Guid? OptionTypeId { get; set; }

        /// <summary>
        /// Gets the raw object of <see cref="OptionType" />.
        /// </summary>
        [ForeignKey(nameof(OptionTypeId))]
        public ItemOptionType RawOptionType
        {
            get => base.OptionType as ItemOptionType;
            set => base.OptionType = value;
        }

        /// <inheritdoc/>
        [NotMapped]
        public override MUnique.OpenMU.DataModel.Configuration.Items.ItemOptionType OptionType
        {
            get => base.OptionType;set
            {
                base.OptionType = value;
                this.OptionTypeId = this.RawOptionType?.Id;
            }
        }

        /// <summary>
        /// Gets or sets the identifier of <see cref="PowerUpDefinition"/>.
        /// </summary>
        public Guid? PowerUpDefinitionId { get; set; }

        /// <summary>
        /// Gets the raw object of <see cref="PowerUpDefinition" />.
        /// </summary>
        [ForeignKey(nameof(PowerUpDefinitionId))]
        public PowerUpDefinition RawPowerUpDefinition
        {
            get => base.PowerUpDefinition as PowerUpDefinition;
            set => base.PowerUpDefinition = value;
        }

        /// <inheritdoc/>
        [NotMapped]
        public override MUnique.OpenMU.DataModel.Attributes.PowerUpDefinition PowerUpDefinition
        {
            get => base.PowerUpDefinition;set
            {
                base.PowerUpDefinition = value;
                this.PowerUpDefinitionId = this.RawPowerUpDefinition?.Id;
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