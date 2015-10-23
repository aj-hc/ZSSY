//���������ɿƷ�EasyUi����������v3.5(build 20140519)��������������,��Ѱ��Զ����Ӱ�Ȩע��,�뱣����Ȩ��Ϣ�����������Ͷ��ɹ��������и��õĽ����뷢�����䣺843330160@qq.com
using System;
using System.Data;
using System.Web;
using System.Collections;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Collections.Generic;
using System.Text;
namespace RuRo
{
    /// <summary>
    /// HttpHandler���������������ɿƷ�EasyUi����������v3.5(build 20140519)��������������,��Ѱ��Զ����Ӱ�Ȩע��,�뱣����Ȩ��Ϣ�����������Ͷ��ɹ��������и��õĽ����뷢�����䣺843330160@qq.com
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    public class OPListForSpecimen_handler : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            if (context.Request["mode"] != null)
            {
                string mode = context.Request["mode"].ToString();
                switch (mode)
                { 
                    case "inf":/*��ѯʵ����*/
                        InfoData(context);
                        break;
                    case "ins":/*����*/
                        SaveData(context);
                        break;
                    case "upd":/*�޸�*/
                        SaveData(context);
                        break;
                    case "del":/*ɾ��*/
                        DeleteData(context);  
                        break;
                    case "qry":/*��ѯ*/
                        QueryData(context,false);
                        break;
                    case "exp":/*����*/
                        QueryData(context,true);
                        break;
                }
            }
            else 
                QueryData(context, false);
        }

        /// <summary>
        /// ��ѯinfo����ʵ����
        /// </summary>
        /// <param name="context"></param>
        private static void InfoData(HttpContext context)
        {
            //BLL.OPListForSpecimen_BLL bll_OPListForSpecimen = new BLL.OPListForSpecimen_BLL();
            //Model.OPListForSpecimen model_OPListForSpecimen = new Model.OPListForSpecimen();
            //DataTable dt = new DataTable();
            //if (context.Request["pk"] != null)
            //{
            //    int pk = int.Parse(context.Request["pk"]);
            //    model_OPListForSpecimen = bll_OPListForSpecimen.GetModel(pk);
            //    bll_OPListForSpecimen.GetModel(ref dt, pk);
            //}
            //string strJson = JSONHelper.DataTable2Json(dt, true);
            //context.Response.Write(strJson);
        }

        /// <summary>
        /// ��������
        /// </summary>
        /// <param name="context"></param>
        private static void SaveData(HttpContext context)
        {
            result rlt = new result();
            try
            {
                BLL.ZSSY.OPListForSpecimen bll_OPListForSpecimen = new BLL.ZSSY.OPListForSpecimen();
                Model.ZSSY.OPListForSpecimen model_OPListForSpecimen = new Model.ZSSY.OPListForSpecimen();
                #region ʵ���ำֵ

                if (context.Request["PatientId"] != null)
                    model_OPListForSpecimen.PatientId = context.Request["PatientId"];

                if (context.Request["InpNO"] != null)
                    model_OPListForSpecimen.InpNO = context.Request["InpNO"];

                if (context.Request["VisitId"] != null)
                    model_OPListForSpecimen.VisitId = context.Request["VisitId"];

                if (context.Request["Name"] != null)
                    model_OPListForSpecimen.Name = context.Request["Name"];

                if (context.Request["NamePhonetic"] != null)
                    model_OPListForSpecimen.NamePhonetic = context.Request["NamePhonetic"];

                if (context.Request["Sex"] != null)
                    model_OPListForSpecimen.Sex = context.Request["Sex"];

                if (context.Request["DateOfBirth"] != null)
                    model_OPListForSpecimen.DateOfBirth = context.Request["DateOfBirth"];

                if (context.Request["BirthPlace"] != null)
                    model_OPListForSpecimen.BirthPlace = context.Request["BirthPlace"];

                if (context.Request["Citizenship"] != null)
                    model_OPListForSpecimen.Citizenship = context.Request["Citizenship"];

                if (context.Request["Nation"] != null)
                    model_OPListForSpecimen.Nation = context.Request["Nation"];

                if (context.Request["IDNO"] != null)
                    model_OPListForSpecimen.IDNO = context.Request["IDNO"];

                if (context.Request["Identity"] != null)
                    model_OPListForSpecimen.Identity = context.Request["Identity"];

                if (context.Request["ChargeType"] != null)
                    model_OPListForSpecimen.ChargeType = context.Request["ChargeType"];

                if (context.Request["MailingAddress"] != null)
                    model_OPListForSpecimen.MailingAddress = context.Request["MailingAddress"];

                if (context.Request["ZipCode"] != null)
                    model_OPListForSpecimen.ZipCode = context.Request["ZipCode"];

                if (context.Request["PhoneNumberHome"] != null)
                    model_OPListForSpecimen.PhoneNumberHome = context.Request["PhoneNumberHome"];

                if (context.Request["PhoneNumbeBusiness"] != null)
                    model_OPListForSpecimen.PhoneNumbeBusiness = context.Request["PhoneNumbeBusiness"];

                if (context.Request["NextOfKin"] != null)
                    model_OPListForSpecimen.NextOfKin = context.Request["NextOfKin"];

                if (context.Request["RelationShip"] != null)
                    model_OPListForSpecimen.RelationShip = context.Request["RelationShip"];

                if (context.Request["NextOfKinAddr"] != null)
                    model_OPListForSpecimen.NextOfKinAddr = context.Request["NextOfKinAddr"];

                if (context.Request["NextOfKinZipCode"] != null)
                    model_OPListForSpecimen.NextOfKinZipCode = context.Request["NextOfKinZipCode"];

                if (context.Request["NextOfKinPhome"] != null)
                    model_OPListForSpecimen.NextOfKinPhome = context.Request["NextOfKinPhome"];

                if (context.Request["DeptCode"] != null)
                    model_OPListForSpecimen.DeptCode = context.Request["DeptCode"];

                if (context.Request["BedNO"] != null)
                    model_OPListForSpecimen.BedNO = context.Request["BedNO"];

                if (context.Request["AdmissionDateTime"] != null)
                    model_OPListForSpecimen.AdmissionDateTime = context.Request["AdmissionDateTime"];

                if (context.Request["DoctorInCharge"] != null)
                    model_OPListForSpecimen.DoctorInCharge = context.Request["DoctorInCharge"];

                if (context.Request["ScheduleId"] != null)
                    model_OPListForSpecimen.ScheduleId = context.Request["ScheduleId"];

                if (context.Request["DiagBeforeOperation"] != null)
                    model_OPListForSpecimen.DiagBeforeOperation = context.Request["DiagBeforeOperation"];

                if (context.Request["ScheduledDateTime"] != null)
                    model_OPListForSpecimen.ScheduledDateTime = context.Request["ScheduledDateTime"];

                if (context.Request["KeepSpecimenSign"] != null)
                    model_OPListForSpecimen.KeepSpecimenSign = context.Request["KeepSpecimenSign"];

                if (context.Request["OperatingRoom"] != null)
                    model_OPListForSpecimen.OperatingRoom = context.Request["OperatingRoom"];

                if (context.Request["Surgeon"] != null)
                    model_OPListForSpecimen.Surgeon = context.Request["Surgeon"];

                if (context.Request["InPatPreillness"] != null)
                    model_OPListForSpecimen.InPatPreillness = context.Request["InPatPreillness"];

                if (context.Request["InPatPastillness"] != null)
                    model_OPListForSpecimen.InPatPastillness = context.Request["InPatPastillness"];

                if (context.Request["InPatFamillness"] != null)
                    model_OPListForSpecimen.InPatFamillness = context.Request["InPatFamillness"];

                if (context.Request["LabInfo"] != null)
                    model_OPListForSpecimen.LabInfo = context.Request["LabInfo"];
                #endregion
                //����ת��
                //����ƥ��
                //�����ύ
                //�������
                
            }
            catch (Exception exception)
            {
                rlt.success = false;
                rlt.msg = exception.Message;
            }
            //context.Response.Write(JSONHelper.Convert2Json(rlt)); 
        }

        /// <summary>
        /// ɾ������
        /// </summary>
        /// <param name="context"></param>
        private static void DeleteData(HttpContext context)
        {
            //result rlt = new result();
            //if (context.Request["pk"] != null)
            //{
            //    string pk = context.Request["pk"];
            //    string[] ArrayPk = pk.Split(',');
            //    BLL.OPListForSpecimen_BLL bll_OPListForSpecimen = new BLL.OPListForSpecimen_BLL();
            //    int successNumber = 0;
            //    string  errorMessage = "";
            //    foreach (string strPk in ArrayPk)
            //    {
            //        if (bll_OPListForSpecimen.Delete(int.Parse(strPk)))
            //        {
            //            successNumber += 1;
            //        }
            //    }
            //    rlt.success = true;
            //    rlt.msg = "�ɹ�ɾ��[" + successNumber.ToString() + "/" + ArrayPk.Length.ToString() + "]������;" + errorMessage; 
            //}
            //else
            //{
            //    rlt.success = false;
            //    rlt.msg = "PK�ֶ�ΪNull";
            //}
            //context.Response.Write(JSONHelper.Convert2Json(rlt));
        }

        /// <summary>
        /// ��ѯ����
        /// </summary>
        /// <param name="context"></param>
        /// <param name="export">�Ƿ񵼳�Excel�ļ�</param>
        private static void QueryData(HttpContext context, bool export)
        {
            //#region ��ȡJquery�ش�Server��ҳҳ���ÿҳ����
            //int page,rows;
            //if (context.Request["page"] != null)
            //   page = int.Parse(context.Request["page"]);
            //else
            //   page = 1; 
            //if (context.Request["rows"]!= null)
            //    rows = int.Parse(context.Request["rows"]);
            //else
            //    rows = 10;
            //#endregion

            //#region ��ȡJquery�ش���ѯ��������
            //string strWhere = " 1=1 ";
            //if (context.Request["so_keywords"] != null)
            //{
            //    string strKeywords = context.Request["so_keywords"];
            //    if (strKeywords.Length > 0)
            //    {
            //        strWhere += " and (";
            //        strWhere += " id like '%" + strKeywords + "%'";
            //        strWhere += " or patientid like '%" + strKeywords + "%'";
            //        strWhere += " or inpno like '%" + strKeywords + "%'";
            //        strWhere += " or visitid like '%" + strKeywords + "%'";
            //        strWhere += " or name like '%" + strKeywords + "%'";
            //        strWhere += ")";
            //    }
            //}
            //#endregion

            //#region �ֶ�����
            //string sort = "id";
            //string order = "asc";
            //if (context.Request["sort"] != null)
            //    sort = context.Request["sort"];
            //if (context.Request["order"] != null)
            //    order = context.Request["order"];
            //#endregion

            //#region ��ҳ����
            //DataTable m_dtTable = new DataTable();
            //PageAction pageAction = new PageAction();
            //pageAction.CurPage = page;
            //pageAction.PageSize = rows;
            //pageAction.TabName = "OPListForSpecimen";
            //pageAction.Fields = "*";
            //pageAction.PkField = "id";
            //pageAction.Condition = strWhere;
            //pageAction.Sort = sort + " " + order;
            //DbHelper.FillDataTable(pageAction, m_dtTable); 
            //#endregion 


            ///*����󶨴�����KFEasyUiMaker���ݱ����ֶζ����Զ�����,���δ����������ܣ�
            // ���������ݽ�������£��ɸ���ʵ���������Ϊ���Ȳ�����������ٱ�����ֵ��*/
            //#region ���������б��������datagrid��ʾֵ
            //for (int i = 0; i < m_dtTable.Rows.Count; i++)
            //{
            //}

            //#endregion 
            //if (export)
            //{
            //    DataTable export_dataTable = new DataTable();
            //    pageAction.Fields = "id as id,patientid as ����Ψһ��ʶ��,inpno as סԺ��,visitid as �����,name as ����,namephonetic as ����ƴ��,sex as �Ա�,dateofbirth as ��������,birthplace as ����������,citizenship as ���Ҽ��,nation as ����,idno as ���֤��,identity as ���߹������,chargetype as �����շ����,mailingaddress as ����ͨ�ŵ�ַ,zipcode as ��������,phonenumberhome as ��ͥ�绰����,phonenumbebusiness as ��λ�绰����,nextofkin as ��������,relationship as ������ϵ,nextofkinaddr as ��ϵ�˵�ַ,nextofkinzipcode as ��ϵ����������,nextofkinphome as ��ϵ�˵绰����,deptcode as ��ǰ���Ҵ���@����,bedno as ������ס����,admissiondatetime as ��Ժ���ڼ�ʱ��,doctorincharge as ����ҽ������@����,scheduleid as ����id��,diagbeforeoperation as ��Ҫ���,scheduleddatetime as ԤԼ���иô����������ڼ�ʱ��,keepspecimensign as �Ƿ����걾,operatingroom as �����Ҵ���@����,surgeon as ����ҽʦ����@����,inpatpreillness as �ֲ�ʷ,inpatpastillness as ����ʷ,inpatfamillness as ����ʷ,labinfo as �Ҹ�÷�������Խ��";
            //    DbHelper.GetTable(pageAction.Sql, ref export_dataTable);
            //    commExcel._ExportExcel(export_dataTable, "OPListForSpecimen");
            //    result rlt = new result();
            //    rlt.success = true;
            //    rlt.msg = commExcel._Url("OPListForSpecimen");
            //    context.Response.Write(JSONHelper.Convert2Json(rlt));
            //}
            //else
            //{
            //    string strJson = JSONHelper.CreateJsonParameters(m_dtTable,true, pageAction.RdCount);
            //    context.Response.Write(strJson);
            //}
        }
        /// <summary>
        /// FusionChartͳ��ͼ��ʽ���ַ���
        /// </summary>
        /// <param name="context"></param>
        private static void ChartData(HttpContext context)
        {
            //ͳ��ͼdome����==========================Begin
            //ͳ��ͼ�����ʵ��ҵ�����������SQLͳ��ʵ����ʵ������ʾ
            //string swf = "Column3D";
            //if (context.Request["swf"] != null)
            //    swf = context.Request["swf"];
            //StringBuilder xmlData = new StringBuilder();
            //xmlData.Append("<chart caption='IT��ҵ�������' subCaption='2014��' xAxisName='����' yAxisName='����' showValues='0' formatNumberScale='0' showBorder='1'  logoURL='/images/login_banquan.gif'  logoPosition='BR' logoAlpha='20'>");
            //xmlData.Append("<set label='�ɶ�' value='5120' />");
            //xmlData.Append("<set label='�Ϻ�' value='9800' />");
            //xmlData.Append("<set label='����' value='9800' />");
            //xmlData.Append("<set label='���' value='6300' />");
            //xmlData.Append("<set label='����' value='10080' />");
            //xmlData.Append("</chart>");
            //string ChartHtml = FusionCharts.RenderChartHTML("../js/FusionCharts/" + swf + ".swf","", xmlData.ToString(), "myChart", "600", "350", false);
            //result rlt = new result();
            //rlt.success = true;
            //rlt.msg = ChartHtml;
            //context.Response.Write(JSONHelper.Convert2Json(rlt));
            //ͳ��ͼdome����==========================End



//            string swf = "Column3D";
//            if (context.Request["swf"] != null)
//                swf = context.Request["swf"];
//            string strSql = @"select �ֶ���,count(*) records from oplistforspecimen group by �ֶ���";
//            DataTable dt = new DataTable();
//            DbHelper.GetTable(strSql, ref dt);

//            StringBuilder xmlData = new StringBuilder();
//            xmlData.AppendFormat(@"<chart caption='{0}' 
//                                    subCaption='{1}' 
//                                    xAxisName='{2}' 
//                                    yAxisName='{3}' 
//                                    showValues='0' 
//                                    formatNumberScale='0' 
//                                    showBorder='1'  
//                                    logoURL='/images/login_banquan.gif'  
//                                    logoPosition='BR' 
//                                    logoAlpha='20'>",
//                                    "ͳ��ͼ","ͳ��ͼ������","X�������","����");
//            for (int i = 0; i < dt.Rows.Count; i++)
//            {
//                xmlData.AppendFormat("<set label='{0}' value='{1}' />",dt.Rows[i]["�ֶ���"],dt.Rows[i]["records"]);  
//            }
//            xmlData.Append("</chart>");
//            string ChartHtml = FusionCharts.RenderChartHTML("../js/FusionCharts/" + swf + ".swf","", xmlData.ToString(), "myChart", "600", "350", false);
//            result rlt = new result();
//            rlt.success = true;
//            rlt.msg = ChartHtml;
//            context.Response.Write(JSONHelper.Convert2Json(rlt));

        }

        #region JSONʵ�巵���ඨ��
        /// <summary>
        /// ʵ��Ajax������
        /// </summary>
        public class result
        {
            bool _success = false;
            string _msg = "";
            public bool success 
            {
                set { _success = value; }
                get { return _success; }
            }
            public string msg
            {
                set { _msg = value; }
                get { return _msg; } 
            }
        }
        #endregion
        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}

