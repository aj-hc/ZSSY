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
    public class LabTestMaster_handler : IHttpHandler
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
            BLL.LabTestMaster_BLL bll_LabTestMaster = new BLL.LabTestMaster_BLL();
            Model.LabTestMaster model_LabTestMaster = new Model.LabTestMaster();
            DataTable dt = new DataTable();
            if (context.Request["pk"] != null)
            {
                int pk = int.Parse(context.Request["pk"]);
                model_LabTestMaster = bll_LabTestMaster.GetModel(pk);
                bll_LabTestMaster.GetModel(ref dt, pk);
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
                BLL.LabTestMaster_BLL bll_LabTestMaster = new BLL.LabTestMaster_BLL();
                Model.LabTestMaster model_LabTestMaster = new Model.LabTestMaster(); 
                #region ʵ���ำֵ
                if (mode == "ins")
                {
                    //��������Max��ȡ����ע�������ֶγ���
                    model_LabTestMaster._id = bll_LabTestMaster.GetMax_id();//������ֵ
                }

                if(context.Request["testno"]!=null)
                    model_LabTestMaster._testno = context.Request["testno"];

                if(context.Request["priorityindicator"]!=null)
                    model_LabTestMaster._priorityindicator = context.Request["priorityindicator"];

                if(context.Request["workingid"]!=null)
                    model_LabTestMaster._workingid = context.Request["workingid"];

                if(context.Request["testcause"]!=null)
                    model_LabTestMaster._testcause = context.Request["testcause"];

                if(context.Request["relevantclinicdiag"]!=null)
                    model_LabTestMaster._relevantclinicdiag = context.Request["relevantclinicdiag"];

                if(context.Request["specimen"]!=null)
                    model_LabTestMaster._specimen = context.Request["specimen"];

                if(context.Request["spcmreceiveddatetime"]!=null)
                    model_LabTestMaster._spcmreceiveddatetime = context.Request["spcmreceiveddatetime"];

                if(context.Request["orderingdept"]!=null)
                    model_LabTestMaster._orderingdept = context.Request["orderingdept"];

                if(context.Request["orderingprovider"]!=null)
                    model_LabTestMaster._orderingprovider = context.Request["orderingprovider"];

                if(context.Request["performedby"]!=null)
                    model_LabTestMaster._performedby = context.Request["performedby"];

                if(context.Request["resultstatus"]!=null)
                    model_LabTestMaster._resultstatus = context.Request["resultstatus"];

                if(context.Request["resultsrptdatetime"]!=null)
                    model_LabTestMaster._resultsrptdatetime = context.Request["resultsrptdatetime"];

                if(context.Request["transcriptionist"]!=null)
                    model_LabTestMaster._transcriptionist = context.Request["transcriptionist"];

                if(context.Request["verifiedby"]!=null)
                    model_LabTestMaster._verifiedby = context.Request["verifiedby"];

                #endregion
                if (mode == "ins")
                {
                    if (bll_LabTestMaster.Insert(model_LabTestMaster))
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
                    if (bll_LabTestMaster.Update(model_LabTestMaster, strPk))
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
                BLL.LabTestMaster_BLL bll_LabTestMaster = new BLL.LabTestMaster_BLL();
                int successNumber = 0;
                string  errorMessage = "";
                foreach (string strPk in ArrayPk)
                {
                    if (bll_LabTestMaster.Delete(int.Parse(strPk)))
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
                    strWhere += " or testno like '%" + strKeywords + "%'";
                    strWhere += " or priorityindicator like '%" + strKeywords + "%'";
                    strWhere += " or workingid like '%" + strKeywords + "%'";
                    strWhere += " or testcause like '%" + strKeywords + "%'";
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
            pageAction.TabName = "LabTestMaster";
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
                pageAction.Fields = "id as id,testno as �������뵥��,priorityindicator as ���ȱ�־,workingid as ��������,testcause as ����Ŀ��,relevantclinicdiag as �ٴ����,specimen as �걾,spcmreceiveddatetime as ����ʱ��,orderingdept as ��ҽ������,orderingprovider as ҽ������,performedby as ִ�п���,resultstatus as ִ�����,resultsrptdatetime as �������ʱ��,transcriptionist as �����߹���,verifiedby as ����߹���";
                DbHelper.GetTable(pageAction.Sql, ref export_dataTable);
                commExcel._ExportExcel(export_dataTable, "LabTestMaster");
                result rlt = new result();
                rlt.success = true;
                rlt.msg = commExcel._Url("LabTestMaster");
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
            string strSql = @"select �ֶ���,count(*) records from labtestmaster group by �ֶ���";
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

