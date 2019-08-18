using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace DataModel
{
    public partial class clsClienteHorarioEntity
    {
        public Guid idClienteHorario { get; set; }
        public Guid idCliente { get; set; }
        public Guid idHorarioCliente{ get; set; }

    }

    public partial class clsClienteHorarioEntity
    {
        public virtual clsClienteEntity clienteHorarioentities { get; set; }
        public virtual clsHorarioClienteEntity horarioClienteEntities { get; set; }
    }

    public class clsClienteHorarioEntityMapping : EntityTypeConfiguration<clsClienteHorarioEntity>
    {
        public clsClienteHorarioEntityMapping()
        {
            ToTable("tblClientesHorarios");
            HasKey(c => c.idClienteHorario);
        }
    }
}
