using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_Bakery.Models
{
    internal class Image
    {
        public int Id { get; set; }
        public int ProductId { get; set; }

        public required virtual Product Product { get; set; }

        public static void Config(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Image>()
                .HasOne(i => i.Product)
                .WithMany(p => p.Images)
                .HasForeignKey(i => i.ProductId);
        }
    }
}
