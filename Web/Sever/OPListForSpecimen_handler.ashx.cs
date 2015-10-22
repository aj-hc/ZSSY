//���������ɿƷ�EasyUi����������v3.5(build 20140519)��������������,��Ѱ��Զ����Ӱ�Ȩע��,�뱣����Ȩ��Ϣ�����������Ͷ��ɹ��������и��õĽ����뷢�����䣺843330160@qq.com
using System;
using System.Data;
using System.Web;
using System.Collections;
using System.Web.Services;
using System.Web.Services.Protocols;
using DBUtility;
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
            BLL.OPListForSpecimen_BLL bll_OPListForSpecimen = new BLL.OPListForSpecimen_BLL();
            Model.OPListForSpecimen model_OPListForSpecimen = new Model.OPListForSpecimen();
            DataTable dt = new DataTable();
            if (context.Request["pk"] != null)
            {
                int pk = int.Parse(context.Request["pk"]);
                model_OPListForSpecimen = bll_OPListForSpecimen.GetModel(pk);
                bll_OPListForSpecimen.GetModel(ref dt, pk);
            }
            string strJson = JSONHelper.DataTable2Json(dt, true);
            context.Response.Write(strJson);
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
                //��ȡ���淽ʽ
                string mode = context.Request["mode"].ToString();
                int strPk = 0;
                if (mode == "upd")
                {
                    strPk = int.Parse(context.Request["pk"].ToString());
                }
                BLL.OPListForSpecimen_BLL bll_OPListForSpecimen = new BLL.OPListForSpecimen_BLL();
                Model.OPListForSpecimen model_OPListForSpecimen = new Model.OPListForSpecimen(); 
                #region ʵ���ำֵ
                if (mode == "ins")
                {
                    //��������Max��ȡ����ע�������ֶγ���
                    model_OPListForSpecimen._id = bll_OPListForSpecimen.GetMax_id();//������ֵ
                }

                if(context.Request["patientid"]!=null)
                    model_OPListForSpecimen._patientid = context.Request["patientid"];

                if(context.Request["inpno"]!=null)
                    model_OPListForSpecimen._inpno = context.Request["inpno"];

                if(context.Request["visitid"]!=null)
                    model_OPListForSpecimen._visitid = context.Request["visitid"];

                if(context.Request["name"]!=null)
                    model_OPListForSpecimen._name = context.Request["name"];

                if(context.Request["namephonetic"]!=null)
                    model_OPListForSpecimen._namephonetic = context.Request["namephonetic"];

                if(context.Request["sex"]!=null)
                    model_OPListForSpecimen._sex = context.Request["sex"];

                if(context.Request["dateofbirth"]!=null)
                    model_OPListForSpecimen._dateofbirth = context.Request["dateofbirth"];

                if(context.Request["birthplace"]!=null)
                    model_OPListForSpecimen._birthplace = context.Request["birthplace"];

                if(context.Request["citizenship"]!=null)
                    model_OPListForSpecimen._citizenship = context.Request["citizenship"];

                if(context.Request["nation"]!=null)
                    model_OPListForSpecimen._nation = context.Request["nation"];

                if(context.Request["idno"]!=null)
                    model_OPListForSpecimen._idno = context.Request["idno"];

                if(context.Request["identity"]!=null)
                    model_OPListForSpecimen._identity = context.Request["identity"];

                if(context.Request["chargetype"]!=null)
                    model_OPListForSpecimen._chargetype = context.Request["chargetype"];

                if(context.Request["mailingaddress"]!=null)
                    model_OPListForSpecimen._mailingaddress = context.Request["mailingaddress"];

                if(context.Request["zipcode"]!=null)
                    model_OPListForSpecimen._zipcode = context.Request["zipcode"];

                if(context.Request["phonenumberhome"]!=null)
                    model_OPListForSpecimen._phonenumberhome = context.Request["phonenumberhome"];

                if(context.Request["phonenumbebusiness"]!=null)
                    model_OPListForSpecimen._phonenumbebusiness = context.Request["phonenumbebusiness"];

                if(context.Request["nextofkin"]!=null)
                    model_OPListForSpecimen._nextofkin = context.Request["nextofkin"];

                if(context.Request["relationship"]!=null)
                    model_OPListForSpecimen._relationship = context.Request["relationship"];

                if(context.Request["nextofkinaddr"]!=null)
                    model_OPListForSpecimen._nextofkinaddr = context.Request["nextofkinaddr"];

                if(context.Request["nextofkinzipcode"]!=null)
                    model_OPListForSpecimen._nextofkinzipcode = context.Request["nextofkinzipcode"];

                if(context.Request["nextofkinphome"]!=null)
                    model_OPListForSpecimen._nextofkinphome = context.Request["nextofkinphome"];

                if(context.Request["deptcode"]!=null)
                    model_OPListForSpecimen._deptcode = context.Request["deptcode"];

                if(context.Request["bedno"]!=null)
                    model_OPListForSpecimen._bedno = context.Request["bedno"];

                if(context.Request["admissiondatetime"]!=null)
                    model_OPListForSpecimen._admissiondatetime = context.Request["admissiondatetime"];

                if(context.Request["doctorincharge"]!=null)
                    model_OPListForSpecimen._doctorincharge = context.Request["doctorincharge"];

                if(context.Request["scheduleid"]!=null)
                    model_OPListForSpecimen._scheduleid = context.Request["scheduleid"];

                if(context.Request["diagbeforeoperation"]!=null)
                    model_OPListForSpecimen._diagbeforeoperation = context.Request["diagbeforeoperation"];

                if(context.Request["scheduleddatetime"]!=null)
                    model_OPListForSpecimen._scheduleddatetime = context.Request["scheduleddatetime"];

                if(context.Request["keepspecimensign"]!=null)
                    model_OPListForSpecimen._keepspecimensign = context.Request["keepspecimensign"];

                if(context.Request["operatingroom"]!=null)
                    model_OPListForSpecimen._operatingroom = context.Request["operatingroom"];

                if(context.Request["surgeon"]!=null)
                    model_OPListForSpecimen._surgeon = context.Request["surgeon"];

                if(context.Request["inpatpreillness"]!=null)
                    model_OPListForSpecimen._inpatpreillness = context.Request["inpatpreillness"];

                if(context.Request["inpatpastillness"]!=null)
                    model_OPListForSpecimen._inpatpastillness = context.Request["inpatpastillness"];

                if(context.Request["inpatfamillness"]!=null)
                    model_OPListForSpecimen._inpatfamillness = context.Request["inpatfamillness"];

                if(context.Request["labinfo"]!=null)
                    model_OPListForSpecimen._labinfo = context.Request["labinfo"];

                #endregion
                if (mode == "ins")
                {
                    if (bll_OPListForSpecimen.Insert(model_OPListForSpecimen))
                    {
                        rlt.success = true;
                        rlt.msg = "��������ɹ�";
                    }
                    else
                    {
                        rlt.success = false;
                        rlt.msg = "��������ʧ��:" + DbError.getErrorMsg();
                    }
                }

                if (mode == "upd")
                {
                    if (bll_OPListForSpecimen.Update(model_OPListForSpecimen, strPk))
                    {
                        rlt.success = true;
                        rlt.msg = "�޸ı���ɹ�";
                    }
                    else
                    {
                        rlt.success = false;
                        rlt.msg = "�޸ı���ʧ��:" + DbError.getErrorMsg();
                    }
                }
            }
            catch(Exception exception)
            {
                rlt.success = false;
                rlt.msg = exception.Message;
            }
            context.Response.Write(JSONHelper.Convert2Json(rlt)); 
        }

        /// <summary>
        /// ɾ������
        /// </summary>
        /// <param name="context"></param>
        private static void DeleteData(HttpContext context)
        {
            result rlt = new result();
            if (context.Request["pk"] != null)
            {
                string pk = context.Request["pk"];
                string[] ArrayPk = pk.Split(',');
                BLL.OPListForSpecimen_BLL bll_OPListForSpecimen = new BLL.OPListForSpecimen_BLL();
                int successNumber = 0;
                string  errorMessage = "";
                foreach (string strPk in ArrayPk)
                {
                    if (bll_OPListForSpecimen.Delete(int.Parse(strPk)))
                    {
                        successNumber += 1;
                    }
                }
                rlt.success = true;
                rlt.msg = "�ɹ�ɾ��[" + successNumber.ToString() + "/" + ArrayPk.Length.ToString() + "]������;" + errorMessage; 
            }
            else
            {
                rlt.success = false;
                rlt.msg = "PK�ֶ�ΪNull";
            }
            context.Response.Write(JSONHelper.Convert2Json(rlt));
        }

        /// <summary>
        /// ��ѯ����
        /// </summary>
        /// <param name="context"></param>
        /// <param name="export">�Ƿ񵼳�Excel�ļ�</param>
        private static void QueryData(HttpContext context, bool export)
        {
            #region ��ȡJquery�ش�Server��ҳҳ���ÿҳ����
            int page,rows;
            if (context.Request["page"] != null)
               page = int.Parse(context.Request["page"]);
            else
               page = 1; 
            if (context.Request["rows"]!= null)
                rows = int.Parse(context.Request["rows"]);
            else
                rows = 10;
            #endregion

            #region ��ȡJquery�ش���ѯ��������
            string strWhere = " 1=1 ";
            if (context.Request["so_keywords"] != null)
            {
                string strKeywords = context.Request["so_keywords"];
                if (strKeywords.Length > 0)
                {
                    strWhere += " and (";
                    strWhere += " id like '%" + strKeywords + "%'";
                    strWhere += " or patientid like '%" + strKeywords + "%'";
                    strWhere += " or inpno like '%" + strKeywords + "%'";
                    strWhere += " or visitid like '%" + strKeywords + "%'";
                    strWhere += " or name like '%" + strKeywords + "%'";
                    strWhere += ")";
                }
            }
            #endregion

            #region �ֶ�����
            string sort = "id";
            string order = "asc";
            if (context.Request["sort"] != null)
                sort = context.Request["sort"];
            if (context.Request["order"] != null)
                order = context.Request["order"];
            #endregion

            #region ��ҳ����
            DataTable m_dtTable = new DataTable();
            PageAction pageAction = new PageAction();
            pageAction.CurPage = page;
            pageAction.PageSize = rows;
            pageAction.TabName = "OPListForSpecimen";
            pageAction.Fields = "*";
            pageAction.PkField = "id";
            pageAction.Condition = strWhere;
            pageAction.Sort = sort + " " + order;
            DbHelper.FillDataTable(pageAction, m_dtTable); 
            #endregion 


            /*����󶨴�����KFEasyUiMaker���ݱ����ֶζ����Զ�����,���δ����������ܣ�
             ���������ݽ�������£��ɸ���ʵ���������Ϊ���Ȳ�����������ٱ�����ֵ��*/
            #region ���������б��������datagrid��ʾֵ
            for (int i = 0; i < m_dtTable.Rows.Count; i++)
            {
            }

            #endregion 
            if (export)
            {
                DataTable export_dataTable = new DataTable();
                pageAction.Fields = "id as id,patientid as ����Ψһ��ʶ��,inpno as סԺ��,visitid as �����,name as ����,namephonetic as ����ƴ��,sex as �Ա�,dateofbirth as ��������,birthplace as ����������,citizenship as ���Ҽ��,nation as ����,idno as ���֤��,identity as ���߹������,chargetype as �����շ����,mailingaddress as ����ͨ�ŵ�ַ,zipcode as ��������,phonenumberhome as ��ͥ�绰����,phonenumbebusiness as ��λ�绰����,nextofkin as ��������,relationship as ������ϵ,nextofkinaddr as ��ϵ�˵�ַ,nextofkinzipcode as ��ϵ����������,nextofkinphome as ��ϵ�˵绰����,deptcode as ��ǰ���Ҵ���@����,bedno as ������ס����,admissiondatetime as ��Ժ���ڼ�ʱ��,doctorincharge as ����ҽ������@����,scheduleid as ����id��,diagbeforeoperation as ��Ҫ���,scheduleddatetime as ԤԼ���иô����������ڼ�ʱ��,keepspecimensign as �Ƿ����걾,operatingroom as �����Ҵ���@����,surgeon as ����ҽʦ����@����,inpatpreillness as �ֲ�ʷ,inpatpastillness as ����ʷ,inpatfamillness as ����ʷ,labinfo as �Ҹ�÷�������Խ��";
                DbHelper.GetTable(pageAction.Sql, ref export_dataTable);
                commExcel._ExportExcel(export_dataTable, "OPListForSpecimen");
                result rlt = new result();
                rlt.success = true;
                rlt.msg = commExcel._Url("OPListForSpecimen");
                context.Response.Write(JSONHelper.Convert2Json(rlt));
            }
            else
            {
                string strJson = JSONHelper.CreateJsonParameters(m_dtTable,true, pageAction.RdCount);
                context.Response.Write(strJson);
            }
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



            string swf = "Column3D";
            if (context.Request["swf"] != null)
                swf = context.Request["swf"];
            string strSql = @"select �ֶ���,count(*) records from oplistforspecimen group by �ֶ���";
            DataTable dt = new DataTable();
            DbHelper.GetTable(strSql, ref dt);

            StringBuilder xmlData = new StringBuilder();
            xmlData.AppendFormat(@"<chart caption='{0}' 
                                    subCaption='{1}' 
                                    xAxisName='{2}' 
                                    yAxisName='{3}' 
                                    showValues='0' 
                                    formatNumberScale='0' 
                                    showBorder='1'  
                                    logoURL='/images/login_banquan.gif'  
                                    logoPosition='BR' 
                                    logoAlpha='20'>",
                                    "ͳ��ͼ","ͳ��ͼ������","X�������","����");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                xmlData.AppendFormat("<set label='{0}' value='{1}' />",dt.Rows[i]["�ֶ���"],dt.Rows[i]["records"]);  
            }
            xmlData.Append("</chart>");
            string ChartHtml = FusionCharts.RenderChartHTML("../js/FusionCharts/" + swf + ".swf","", xmlData.ToString(), "myChart", "600", "350", false);
            result rlt = new result();
            rlt.success = true;
            rlt.msg = ChartHtml;
            context.Response.Write(JSONHelper.Convert2Json(rlt));

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

