// <copyright file="QuestMonsterKillRequirementState.Generated.cs" company="MUnique">
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
    /// The Entity Framework Core implementation of <see cref="MUnique.OpenMU.DataModel.Entities.QuestMonsterKillRequirementState"/>.
    /// </summary>
    [Table(nameof(QuestMonsterKillRequirementState), Schema = "data")]
    internal partial class QuestMonsterKillRequirementState : MUnique.OpenMU.DataModel.Entities.QuestMonsterKillRequirementState, IIdentifiable
    {
        
        
        /// <summary>
        /// Gets or sets the identifier of this instance.
        /// </summary>
        public Guid Id { get; set; }
        
        /// <summary>
        /// Gets or sets the identifier of <see cref="Requirement"/>.
        /// </summary>
        public Guid? RequirementId { get; set; }

        /// <summary>
        /// Gets the raw object of <see cref="Requirement" />.
        /// </summary>
        [ForeignKey(nameof(RequirementId))]
        public QuestMonsterKillRequirement RawRequirement
        {
            get => base.Requirement as QuestMonsterKillRequirement;
            set => base.Requirement = value;
        }

        /// <inheritdoc/>
        [NotMapped]
        public override MUnique.OpenMU.DataModel.Configuration.Quests.QuestMonsterKillRequirement Requirement
        {
            get => base.Requirement;set
            {
                base.Requirement = value;
                this.RequirementId = this.RawRequirement?.Id;
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