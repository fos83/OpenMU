// <copyright file="GameServerDefinition.Generated.cs" company="MUnique">
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
    /// The Entity Framework Core implementation of <see cref="MUnique.OpenMU.DataModel.Configuration.GameServerDefinition"/>.
    /// </summary>
    [Table(nameof(GameServerDefinition), Schema = "config")]
    internal partial class GameServerDefinition : MUnique.OpenMU.DataModel.Configuration.GameServerDefinition, IIdentifiable
    {
        
        
        /// <summary>
        /// Gets or sets the identifier of this instance.
        /// </summary>
        public Guid Id { get; set; }
        
        /// <summary>
        /// Gets the raw collection of <see cref="Endpoints" />.
        /// </summary>
        public ICollection<GameServerEndpoint> RawEndpoints { get; } = new EntityFramework.List<GameServerEndpoint>();
        
        /// <inheritdoc/>
        [NotMapped]
        public override ICollection<MUnique.OpenMU.DataModel.Configuration.GameServerEndpoint> Endpoints => base.Endpoints ??= new CollectionAdapter<MUnique.OpenMU.DataModel.Configuration.GameServerEndpoint, GameServerEndpoint>(this.RawEndpoints);

        /// <summary>
        /// Gets or sets the identifier of <see cref="ServerConfiguration"/>.
        /// </summary>
        public Guid? ServerConfigurationId { get; set; }

        /// <summary>
        /// Gets the raw object of <see cref="ServerConfiguration" />.
        /// </summary>
        [ForeignKey(nameof(ServerConfigurationId))]
        public GameServerConfiguration RawServerConfiguration
        {
            get => base.ServerConfiguration as GameServerConfiguration;
            set => base.ServerConfiguration = value;
        }

        /// <inheritdoc/>
        [NotMapped]
        public override MUnique.OpenMU.DataModel.Configuration.GameServerConfiguration ServerConfiguration
        {
            get => base.ServerConfiguration;set
            {
                base.ServerConfiguration = value;
                this.ServerConfigurationId = this.RawServerConfiguration?.Id;
            }
        }

        /// <summary>
        /// Gets or sets the identifier of <see cref="GameConfiguration"/>.
        /// </summary>
        public Guid? GameConfigurationId { get; set; }

        /// <summary>
        /// Gets the raw object of <see cref="GameConfiguration" />.
        /// </summary>
        [ForeignKey(nameof(GameConfigurationId))]
        public GameConfiguration RawGameConfiguration
        {
            get => base.GameConfiguration as GameConfiguration;
            set => base.GameConfiguration = value;
        }

        /// <inheritdoc/>
        [NotMapped]
        public override MUnique.OpenMU.DataModel.Configuration.GameConfiguration GameConfiguration
        {
            get => base.GameConfiguration;set
            {
                base.GameConfiguration = value;
                this.GameConfigurationId = this.RawGameConfiguration?.Id;
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