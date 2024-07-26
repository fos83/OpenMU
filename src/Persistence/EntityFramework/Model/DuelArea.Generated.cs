// <copyright file="DuelArea.Generated.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

//------------------------------------------------------------------------------
// <auto-generated>
//     This source code was auto-generated by a roslyn code generator.
// </auto-generated>
//------------------------------------------------------------------------------

// ReSharper disable All

namespace MUnique.OpenMU.Persistence.EntityFramework.Model;

using System.ComponentModel.DataAnnotations.Schema;
using MUnique.OpenMU.Persistence;

/// <summary>
/// The Entity Framework Core implementation of <see cref="MUnique.OpenMU.DataModel.Configuration.DuelArea"/>.
/// </summary>
[Table(nameof(DuelArea), Schema = SchemaNames.Configuration)]
internal partial class DuelArea : MUnique.OpenMU.DataModel.Configuration.DuelArea, IIdentifiable
{
    
    
    /// <summary>
    /// Gets or sets the identifier of this instance.
    /// </summary>
    public Guid Id { get; set; }
    
    /// <summary>
    /// Gets or sets the identifier of <see cref="FirstPlayerGate"/>.
    /// </summary>
    public Guid? FirstPlayerGateId { get; set; }

    /// <summary>
    /// Gets the raw object of <see cref="FirstPlayerGate" />.
    /// </summary>
    [ForeignKey(nameof(FirstPlayerGateId))]
    public ExitGate RawFirstPlayerGate
    {
        get => base.FirstPlayerGate as ExitGate;
        set => base.FirstPlayerGate = value;
    }

    /// <inheritdoc/>
    [NotMapped]
    public override MUnique.OpenMU.DataModel.Configuration.ExitGate FirstPlayerGate
    {
        get => base.FirstPlayerGate;set
        {
            base.FirstPlayerGate = value;
            this.FirstPlayerGateId = this.RawFirstPlayerGate?.Id;
        }
    }

    /// <summary>
    /// Gets or sets the identifier of <see cref="SecondPlayerGate"/>.
    /// </summary>
    public Guid? SecondPlayerGateId { get; set; }

    /// <summary>
    /// Gets the raw object of <see cref="SecondPlayerGate" />.
    /// </summary>
    [ForeignKey(nameof(SecondPlayerGateId))]
    public ExitGate RawSecondPlayerGate
    {
        get => base.SecondPlayerGate as ExitGate;
        set => base.SecondPlayerGate = value;
    }

    /// <inheritdoc/>
    [NotMapped]
    public override MUnique.OpenMU.DataModel.Configuration.ExitGate SecondPlayerGate
    {
        get => base.SecondPlayerGate;set
        {
            base.SecondPlayerGate = value;
            this.SecondPlayerGateId = this.RawSecondPlayerGate?.Id;
        }
    }

    /// <summary>
    /// Gets or sets the identifier of <see cref="SpectatorsGate"/>.
    /// </summary>
    public Guid? SpectatorsGateId { get; set; }

    /// <summary>
    /// Gets the raw object of <see cref="SpectatorsGate" />.
    /// </summary>
    [ForeignKey(nameof(SpectatorsGateId))]
    public ExitGate RawSpectatorsGate
    {
        get => base.SpectatorsGate as ExitGate;
        set => base.SpectatorsGate = value;
    }

    /// <inheritdoc/>
    [NotMapped]
    public override MUnique.OpenMU.DataModel.Configuration.ExitGate SpectatorsGate
    {
        get => base.SpectatorsGate;set
        {
            base.SpectatorsGate = value;
            this.SpectatorsGateId = this.RawSpectatorsGate?.Id;
        }
    }

    /// <inheritdoc />
    public override MUnique.OpenMU.DataModel.Configuration.DuelArea Clone(MUnique.OpenMU.DataModel.Configuration.GameConfiguration gameConfiguration)
    {
        var clone = new DuelArea();
        clone.AssignValuesOf(this, gameConfiguration);
        return clone;
    }
    
    /// <inheritdoc />
    public override void AssignValuesOf(MUnique.OpenMU.DataModel.Configuration.DuelArea other, MUnique.OpenMU.DataModel.Configuration.GameConfiguration gameConfiguration)
    {
        base.AssignValuesOf(other, gameConfiguration);
        this.Id = other.GetId();
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