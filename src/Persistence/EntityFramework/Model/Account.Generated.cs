// <copyright file="Account.Generated.cs" company="MUnique">
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
    /// The Entity Framework Core implementation of <see cref="MUnique.OpenMU.DataModel.Entities.Account"/>.
    /// </summary>
    [Table(nameof(Account), Schema = "data")]
    internal partial class Account : MUnique.OpenMU.DataModel.Entities.Account, IIdentifiable
    {
        /// <inheritdoc />
        public Account()
        {
            this.InitJoinCollections();
        }

        
        /// <summary>
        /// Gets or sets the identifier of this instance.
        /// </summary>
        public Guid Id { get; set; }
        
        /// <summary>
        /// Gets the raw collection of <see cref="Characters" />.
        /// </summary>
        public ICollection<Character> RawCharacters { get; } = new EntityFramework.List<Character>();
        
        /// <inheritdoc/>
        [NotMapped]
        public override ICollection<MUnique.OpenMU.DataModel.Entities.Character> Characters => base.Characters ??= new CollectionAdapter<MUnique.OpenMU.DataModel.Entities.Character, Character>(this.RawCharacters);

        /// <summary>
        /// Gets or sets the identifier of <see cref="Vault"/>.
        /// </summary>
        public Guid? VaultId { get; set; }

        /// <summary>
        /// Gets the raw object of <see cref="Vault" />.
        /// </summary>
        [ForeignKey(nameof(VaultId))]
        public ItemStorage RawVault
        {
            get => base.Vault as ItemStorage;
            set => base.Vault = value;
        }

        /// <inheritdoc/>
        [NotMapped]
        public override MUnique.OpenMU.DataModel.Entities.ItemStorage Vault
        {
            get => base.Vault;set
            {
                base.Vault = value;
                this.VaultId = this.RawVault?.Id;
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

        protected void InitJoinCollections()
        {
            this.UnlockedCharacterClasses = new ManyToManyCollectionAdapter<MUnique.OpenMU.DataModel.Configuration.CharacterClass, AccountCharacterClass>(this.JoinedUnlockedCharacterClasses, joinEntity => joinEntity.CharacterClass, entity => new AccountCharacterClass { Account = this, AccountId = this.Id, CharacterClass = (CharacterClass)entity, CharacterClassId = ((CharacterClass)entity).Id});
        }
    }
}