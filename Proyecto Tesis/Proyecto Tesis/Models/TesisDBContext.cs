namespace Proyecto_Tesis.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TesisDBContext : DbContext
    {
        public TesisDBContext()
            : base("name=TesisDBContext")
        {
        }

        public virtual DbSet<TBL_ACTIVIDAD> TBL_ACTIVIDAD { get; set; }
        public virtual DbSet<TBL_AREA> TBL_AREA { get; set; }
        public virtual DbSet<TBL_AREA_PUESTO> TBL_AREA_PUESTO { get; set; }
        public virtual DbSet<TBL_BIOMETRICO> TBL_BIOMETRICO { get; set; }
        public virtual DbSet<TBL_CLIENTE> TBL_CLIENTE { get; set; }
        public virtual DbSet<TBL_COMPANIA> TBL_COMPANIA { get; set; }
        public virtual DbSet<TBL_EMPLEADO> TBL_EMPLEADO { get; set; }
        public virtual DbSet<TBL_INCIDENCIA> TBL_INCIDENCIA { get; set; }
        public virtual DbSet<TBL_INCIDENCIA_SOLUCION> TBL_INCIDENCIA_SOLUCION { get; set; }
        public virtual DbSet<TBL_MODULO> TBL_MODULO { get; set; }
        public virtual DbSet<TBL_MODULO_ACTIVIDAD> TBL_MODULO_ACTIVIDAD { get; set; }
        public virtual DbSet<TBL_PUESTO> TBL_PUESTO { get; set; }
        public virtual DbSet<TBL_REGISTRO_HORAS> TBL_REGISTRO_HORAS { get; set; }
        public virtual DbSet<TBL_REGISTRO_ICNDENCIA> TBL_REGISTRO_ICNDENCIA { get; set; }
        public virtual DbSet<TBL_ROL> TBL_ROL { get; set; }
        public virtual DbSet<TBL_SERVIDOR> TBL_SERVIDOR { get; set; }
        public virtual DbSet<TBL_SOLUCIONES> TBL_SOLUCIONES { get; set; }
        public virtual DbSet<TBL_TIPO_INCIDENCIA> TBL_TIPO_INCIDENCIA { get; set; }
        public virtual DbSet<TBL_TIPO_SERVIDOR> TBL_TIPO_SERVIDOR { get; set; }
        public virtual DbSet<TBL_USUARIO> TBL_USUARIO { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TBL_ACTIVIDAD>()
                .Property(e => e.VC_NOMBRE_ACTIVIDAD)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_ACTIVIDAD>()
                .Property(e => e.VC_DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_ACTIVIDAD>()
                .HasMany(e => e.TBL_MODULO_ACTIVIDAD)
                .WithRequired(e => e.TBL_ACTIVIDAD)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TBL_AREA>()
                .Property(e => e.VC_NOMBRE_AREA)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_AREA>()
                .Property(e => e.CH_SITUACION_REGISTRO)
                .IsFixedLength()
                .IsUnicode(false);

            //----------Agregado----
            //modelBuilder.Entity<TBL_AREA>()
            //    .HasMany(e => e.TBL_EMPLEADO)
            //    .WithRequired(e => e.TBL_AREA)
            //    .HasForeignKey(e => new { e.IN_CODIGO_AREA, e.IN_CODIGO_AREA })
            //    .WillCascadeOnDelete(false);


                //---------

            modelBuilder.Entity<TBL_AREA>()
                .HasMany(e => e.TBL_AREA_PUESTO)
                .WithRequired(e => e.TBL_AREA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TBL_AREA_PUESTO>()
                .HasMany(e => e.TBL_EMPLEADO)
                .WithRequired(e => e.TBL_AREA_PUESTO)
                .HasForeignKey(e => new { e.IN_CODIGO_PUESTO, e.IN_CODIGO_AREA })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TBL_BIOMETRICO>()
                .Property(e => e.VC_TIPO)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_BIOMETRICO>()
                .Property(e => e.VC_DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_BIOMETRICO>()
                .Property(e => e.VC_NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_BIOMETRICO>()
                .Property(e => e.VC_IP)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_BIOMETRICO>()
                .HasMany(e => e.TBL_CLIENTE)
                .WithRequired(e => e.TBL_BIOMETRICO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TBL_CLIENTE>()
                .Property(e => e.VC_TIPO_ACCESO)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_COMPANIA>()
                .Property(e => e.VC_NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_COMPANIA>()
                .Property(e => e.VC_RUC)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_COMPANIA>()
                .Property(e => e.VC_DIRECCION)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_COMPANIA>()
                .HasMany(e => e.TBL_AREA)
                .WithRequired(e => e.TBL_COMPANIA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TBL_COMPANIA>()
                .HasOptional(e => e.TBL_CLIENTE)
                .WithRequired(e => e.TBL_COMPANIA);

            modelBuilder.Entity<TBL_COMPANIA>()
                .HasMany(e => e.TBL_REGISTRO_HORAS)
                .WithRequired(e => e.TBL_COMPANIA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TBL_EMPLEADO>()
                .Property(e => e.VC_APELLIDO_PATERNO)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_EMPLEADO>()
                .Property(e => e.VC_APELLIDO_MATERNO)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_EMPLEADO>()
                .Property(e => e.VC_NOMBRES)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_EMPLEADO>()
                .Property(e => e.CH_SEXO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TBL_EMPLEADO>()
                .Property(e => e.VC_NACIONALIDAD)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_EMPLEADO>()
                .Property(e => e.CH_TIPO_DOCUMENTO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TBL_EMPLEADO>()
                .Property(e => e.VC_NUMERO_DOCUMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_EMPLEADO>()
                .Property(e => e.VC_CORREO)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_EMPLEADO>()
                .Property(e => e.VC_NUMERO_CELULAR)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_EMPLEADO>()
                .Property(e => e.CH_SITUACION_REGISTRO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TBL_EMPLEADO>()
                .Property(e => e.VC_FOTO)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_EMPLEADO>()
                .HasMany(e => e.TBL_REGISTRO_HORAS)
                .WithRequired(e => e.TBL_EMPLEADO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TBL_EMPLEADO>()
                .HasMany(e => e.TBL_REGISTRO_ICNDENCIA)
                .WithRequired(e => e.TBL_EMPLEADO)
                .WillCascadeOnDelete(false);

           modelBuilder.Entity<TBL_INCIDENCIA>()
                .Property(e => e.VC_NOMBRE_INCIDENCIA)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_INCIDENCIA>()
                .Property(e => e.VC_DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_INCIDENCIA>()
                .HasMany(e => e.TBL_REGISTRO_ICNDENCIA)
                .WithRequired(e => e.TBL_INCIDENCIA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TBL_INCIDENCIA>()
                .HasMany(e => e.TBL_INCIDENCIA_SOLUCION)
                .WithRequired(e => e.TBL_INCIDENCIA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TBL_INCIDENCIA_SOLUCION>()
                .Property(e => e.VC_DECRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_INCIDENCIA_SOLUCION>()
                .HasMany(e => e.TBL_REGISTRO_ICNDENCIA)
                .WithRequired(e => e.TBL_INCIDENCIA_SOLUCION)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TBL_MODULO>()
                .Property(e => e.VC_NOMBRE_MODULO)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_MODULO>()
                .Property(e => e.VC_DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_MODULO>()
                .HasMany(e => e.TBL_MODULO_ACTIVIDAD)
                .WithRequired(e => e.TBL_MODULO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TBL_MODULO_ACTIVIDAD>()
                .Property(e => e.IN_TIPO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TBL_MODULO_ACTIVIDAD>()
                .Property(e => e.VC_MANUAL_ACCESO)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_MODULO_ACTIVIDAD>()
                .HasMany(e => e.TBL_CLIENTE)
                .WithRequired(e => e.TBL_MODULO_ACTIVIDAD)
                .HasForeignKey(e => new { e.IN_CODIGO_MODULO, e.IN_CODIGO_ACTIVIDAD })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TBL_MODULO_ACTIVIDAD>()
                .HasMany(e => e.TBL_REGISTRO_HORAS)
                .WithRequired(e => e.TBL_MODULO_ACTIVIDAD)
                .HasForeignKey(e => new { e.IN_CODIGO_MODULO, e.IN_CODIGO_ACTIVIDAD })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TBL_MODULO_ACTIVIDAD>()
                .HasMany(e => e.TBL_REGISTRO_ICNDENCIA)
                .WithRequired(e => e.TBL_MODULO_ACTIVIDAD)
                .HasForeignKey(e => new { e.IN_CODIGO_MODULO, e.IN_CODIGO_ACTIVIDAD })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TBL_PUESTO>()
                .Property(e => e.VC_NOMBRE_PUESTO)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_PUESTO>()
                .Property(e => e.VC_DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_PUESTO>()
                .Property(e => e.CH_SITUACION_REGISTRO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TBL_PUESTO>()
                .HasMany(e => e.TBL_AREA_PUESTO)
                .WithRequired(e => e.TBL_PUESTO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TBL_REGISTRO_HORAS>()
                .Property(e => e.DE_HORAS)
                .HasPrecision(2, 2);

            modelBuilder.Entity<TBL_ROL>()
                .Property(e => e.VC_DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_ROL>()
                .Property(e => e.CH_SITUACION_REGISTRO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TBL_ROL>()
                .HasMany(e => e.TBL_USUARIO)
                .WithRequired(e => e.TBL_ROL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TBL_SERVIDOR>()
                .Property(e => e.VC_DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_SERVIDOR>()
                .Property(e => e.DE_CAPACIDAD_DD)
                .HasPrecision(10, 2);

            modelBuilder.Entity<TBL_SERVIDOR>()
                .Property(e => e.DE_CAPACIDAD_RAM)
                .HasPrecision(10, 2);

            modelBuilder.Entity<TBL_SERVIDOR>()
                .Property(e => e.VC_MODELO)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_SERVIDOR>()
                .HasMany(e => e.TBL_BIOMETRICO)
                .WithRequired(e => e.TBL_SERVIDOR)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TBL_SERVIDOR>()
                .HasMany(e => e.TBL_CLIENTE)
                .WithRequired(e => e.TBL_SERVIDOR)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TBL_SOLUCIONES>()
                .Property(e => e.VC_NOMBRE_SOLUCION)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_SOLUCIONES>()
                .Property(e => e.VC_DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_SOLUCIONES>()
                .Property(e => e.VC_ARCHIVO)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_SOLUCIONES>()
                .HasMany(e => e.TBL_INCIDENCIA_SOLUCION)
                .WithRequired(e => e.TBL_SOLUCIONES)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TBL_TIPO_INCIDENCIA>()
                .Property(e => e.VC_DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_TIPO_INCIDENCIA>()
                .HasMany(e => e.TBL_INCIDENCIA)
                .WithRequired(e => e.TBL_TIPO_INCIDENCIA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TBL_TIPO_SERVIDOR>()
                .Property(e => e.VC_NOMBRE_SERVIDOR)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_TIPO_SERVIDOR>()
                .Property(e => e.VC_DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_TIPO_SERVIDOR>()
                .HasMany(e => e.TBL_SERVIDOR)
                .WithRequired(e => e.TBL_TIPO_SERVIDOR)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TBL_USUARIO>()
                .Property(e => e.VC_USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_USUARIO>()
                .Property(e => e.VC_PASSWORD)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_USUARIO>()
                .Property(e => e.CH_SITUACION_REGISTRO)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
