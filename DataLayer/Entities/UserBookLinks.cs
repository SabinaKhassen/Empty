namespace DataLayer.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UserBookLinks
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int BookId { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime ReturnDate { get; set; }

        public DateTime Deadline { get; set; }

        public virtual Books Books { get; set; }

        public virtual Users Users { get; set; }
    }
}
