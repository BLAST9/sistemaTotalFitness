using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DataModel
{
    public partial class BDModel : DbContext
    {
        public BDModel() : base(@"Data Source=KEVIN-CASTRO\SQLSERVER;Initial Catalog=TotalFitnes;Integrated Security=True") { }

        public DbSet<clsClienteEntity> clientesEntities { get; set; }
        public DbSet<clsClienteHorarioEntity> clientesHorariosEntities { get; set; }
        public DbSet<clsEmpleadoEntity> empleadosEntities { get; set; }
        public DbSet<clsFacturaEntity> facturassEntities { get; set; }
        public DbSet<clsHorarioClienteEntity> horariosClientesEntities { get; set; }
        public DbSet<clsHorarioEmpleadoEntity> horariosEmpleadosEntities { get; set; }
        public DbSet<clsMensualidadEntity> mensualidadesEntities { get; set; }
        public DbSet<clsProductoEntity> productosEntities { get; set; }
        public DbSet<clsProductoFacturaEntity> productosFacturasEntities { get; set; }
        public DbSet<clsTipoEjercicioEntity> tiposEjerciciosEntities { get; set; }
        public DbSet<clsMensualidadEjercicioEntity> mensualidadesEjerciciosEntities { get; set; }

    }

    public partial class BDModel
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention>();

            modelBuilder.Configurations.Add(new clsClienteEntityMapping());
            modelBuilder.Configurations.Add(new clsClienteHorarioEntityMapping());
            modelBuilder.Configurations.Add(new clsEmpleadoEntityMapping());
            modelBuilder.Configurations.Add(new clsFacturaEntityMapping());
            modelBuilder.Configurations.Add(new clsHorarioClienteEntityMapping());
            modelBuilder.Configurations.Add(new clsHorarioEmpleadoEntityMapping());
            modelBuilder.Configurations.Add(new clsMensualidadEntityMapping());
            modelBuilder.Configurations.Add(new clsProductoEntityMapping());
            modelBuilder.Configurations.Add(new clsProductoFacturaEntityMapping());
            modelBuilder.Configurations.Add(new clsTipoEjercicioEntityMapping());
            modelBuilder.Configurations.Add(new clsMensualidadEjercicioEntityMapping());

            base.OnModelCreating(modelBuilder);
        }
    }
}
