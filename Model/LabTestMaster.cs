//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class LabTestMaster
    {
        public int Id { get; set; }
        public string TestNo { get; set; }
        public string priorityIndicator { get; set; }
        public string WorkingId { get; set; }
        public string TestCause { get; set; }
        public string RelevantClinicDiag { get; set; }
        public string Specimen { get; set; }
        public string SpcmReceivedDateTime { get; set; }
        public string OrderingDept { get; set; }
        public string orderingProvider { get; set; }
        public string PerformedBy { get; set; }
        public string ResultStatus { get; set; }
        public string ResultsRptDateTime { get; set; }
        public string transcriptionist { get; set; }
        public string VerifiedBy { get; set; }
    }
}
