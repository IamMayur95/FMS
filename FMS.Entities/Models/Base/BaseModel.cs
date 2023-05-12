using FMS.Core.Common.Contracts.Diff;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Utils.Common.Interfaces;

namespace FMS.Entities.Models.Base
{
    public abstract class BaseModel<TId> : IHasId<TId>
        where TId : IEquatable<TId>, IComparable<TId>
    {
        [DiffSkip]
        [Key]
        public TId Id { get; set; }
    }

    public abstract class BaseGuidModel : IHasId<Guid>
    {
        [DiffSkip]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid Id { get; set; }
    }

    public abstract class BaseModel : BaseModel<int>
    {
    }
}
