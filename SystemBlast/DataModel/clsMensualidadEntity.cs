using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace DataModel
{
    public partial class clsMensualidadEntity
    {
        public Guid idMensualidad { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaCierre { get; set; }
        public Guid idCliente { get; set; }
    }
    public partial class clsMensualidadEntity
    {
        public clsMensualidadEntity()
        {
            this.mensualidadEjerciciosEntities = new HashSet<clsMensualidadEjercicioEntity>();
        }
        public virtual clsClienteEntity clienteMensualidadEntities { get; set; }
        public virtual ICollection<clsMensualidadEjercicioEntity> mensualidadEjerciciosEntities { get; set; }
    }

    public class clsMensualidadEntityMapping : EntityTypeConfiguration<clsMensualidadEntity>
    {
        public clsMensualidadEntityMapping()
        {
            ToTable("tblMensualidad");
            HasKey(c => c.idMensualidad);
            Property(c => c.fechaInicio)
                .IsRequired();
            Property(c => c.fechaCierre)
                .IsRequired();
        }
    }
}
