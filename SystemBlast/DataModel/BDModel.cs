using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DataModel
{
    public partial class BDModel : DbContext
    {// Se hace conexion a SQL
        public BDModel() : base(@"Data Source=DESKTOP-6H3M9U9\BLAST;Initial Catalog=TotalFitness;Integrated Security=True") { }
        //Se agregan las tablas 
        public DbSet<clsClienteEntity> clientesEntities { get; set; }
        public DbSet<clsClienteHorarioEntity> clientesHorariosEntities { get; set; }
        public DbSet<clsEmpleadoEntity> empleadosEntities { get; set; }
        public DbSet<clsFacturaEntity> facturassEntities { get; set; }
        public DbSet<clsHorarioClienteEntity> horariosClientesEntities { get; set; }
        public DbSet<clsHorarioEmpleadoEntity> horariosEmpleadosEntities { get; set; }
        public DbSet<clsProductoEntity> productosEntities { get; set; }
        public DbSet<clsProductoFacturaEntity> productosFacturasEntities { get; set; }

    }
    //Se agregan configuraciones de las tablas
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
            modelBuilder.Configurations.Add(new clsProductoEntityMapping());
            modelBuilder.Configurations.Add(new clsProductoFacturaEntityMapping());

            //Se crea BD
            base.OnModelCreating(modelBuilder);
        }
    }
}
