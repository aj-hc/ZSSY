﻿//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace RuRo.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FpExtendEntities : DbContext
    {
        public FpExtendEntities()
            : base("name=FpExtendEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<ImportSampleSourceLog> ImportSampleSourceLog { get; set; }
        public DbSet<SpecimenRt> SpecimenRt { get; set; }
        public DbSet<SpecimenRtLog> SpecimenRtLog { get; set; }
        public DbSet<LabTestMaster> LabTestMaster { get; set; }
        public DbSet<LabTestResult> LabTestResult { get; set; }
        public DbSet<OPListForSpecimen> OPListForSpecimen { get; set; }
    }
}
