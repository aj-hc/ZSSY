<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OPListForSpecimen_list.aspx.cs" Inherits="RuRo.OPListForSpecimen_list" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="head">
    <title>��ѯҳ��</title>
    <link rel="stylesheet" type="text/css" href="../../include/jquery-easyui-1.4.3/themes/default/easyui.css" />
    <link rel="stylesheet" type="text/css" href="../../include/jquery-easyui-1.4.3/themes/icon.css" />
    <script type="text/javascript" src="../../include/jquery-easyui-1.4.3/jquery.min.js"></script>
    <script type="text/javascript" src="../../include/jquery-easyui-1.4.3/jquery.easyui.min.js"></script>
    <script type="text/javascript" src="../../include/jquery-easyui-1.4.3/locale/easyui-lang-zh_CN.js"></script>
    <link rel="stylesheet" type="text/css" href="../../include/css/kfmis.css" />
    <script type="text/javascript" src="../../include/js/page.js"></script>
    <script type="text/javascript" src="../../include/js/jquery.cookie.js"></script>
</head>
<body>
    <!--Search -->
    <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
        <tr>
            <td style="width: 80px" align="right" class="tdbg">
                <select id="cc" class="easyui-combobox" name="dept" style="width:200px;">   
                    <option value="1">����</option>   
                    <option value="2">����</option>    
                </select>  
            </td>
            <td class="tdbg">
                <div id="getcode">
                    <%--<asp:TextBox ID="txtKeyword" runat="server"></asp:TextBox>&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnSearch" runat="server" Text="�����ѯ" OnClick="btnCode_Click"></asp:Butto--%>
                </div>
                <div id="getdate" style="visibility: hidden">
<%--                    <div>
                        ��ʼ���ڣ�<input class="Wdate" type="text" runat="server" id="ksrq" name="ksrq" onclick="WdatePicker()">
                    </div>
                    <div>
                        �������ڣ�<input class="Wdate" type="text" runat="server" id="jsrq" name="jsrq" onclick="WdatePicker()">
                    </div>
                    <asp:Button ID="Button1" runat="server" Text="���ڲ�ѯ" OnClick="btnSelDate_Click"></asp:Button>--%>
                </div>
            </td>
            <td class="tdbg"></td>
        </tr>
    </table>
    <!--Search end-->

    <!--datagrid��-->
    <table id="datagrid" title="OPListForSpecimen" class="easyui-datagrid" style="width: auto; height: 460px"
        url="OPListForSpecimen_handler.ashx?mode=qry" fit='false'
        pagination="true" idfield="id" rownumbers="true"
        fitcolumns="true" singleselect="true" toolbar="#toolbar"
        striped="false" pagelist="[15,30,50,100,500]"
        selectoncheck="true" checkonselect="true" remotesort="true">
        <thead>
            <tr>
                <th field="ck" checkbox="true"></th>
                <th field="id" width="100" sortable="true">id</th>
                <th field="patientid" width="100" sortable="true">����Ψһ��ʶ��</th>
                <th field="inpno" width="100" sortable="true">סԺ��</th>
                <th field="visitid" width="100" sortable="true">�����</th>
                <th field="name" width="100" sortable="true">����</th>
                <th field="namephonetic" width="100" sortable="true">����ƴ��</th>
                <th field="sex" width="100" sortable="true">�Ա�</th>
                <th field="dateofbirth" width="100" sortable="true">��������</th>
                <th field="birthplace" width="100" sortable="true">����������</th>
                <th field="citizenship" width="100" sortable="true">���Ҽ��</th>
                <th field="nation" width="100" sortable="true">����</th>
                <th field="idno" width="100" sortable="true">���֤��</th>
                <th field="identity" width="100" sortable="true">���߹������</th>
                <th field="chargetype" width="100" sortable="true">�����շ����</th>
                <th field="mailingaddress" width="100" sortable="true">����ͨ�ŵ�ַ</th>
                <th field="zipcode" width="100" sortable="true">��������</th>
                <th field="phonenumberhome" width="100" sortable="true">��ͥ�绰����</th>
                <th field="phonenumbebusiness" width="100" sortable="true">��λ�绰����</th>
                <th field="nextofkin" width="100" sortable="true">��������</th>
                <th field="relationship" width="100" sortable="true">������ϵ</th>
                <th field="nextofkinaddr" width="100" sortable="true">��ϵ�˵�ַ</th>
                <th field="nextofkinzipcode" width="100" sortable="true">��ϵ����������</th>
                <th field="nextofkinphome" width="100" sortable="true">��ϵ�˵绰����</th>
                <th field="deptcode" width="100" sortable="true">��ǰ���Ҵ���@����</th>
                <th field="bedno" width="100" sortable="true">������ס����</th>
                <th field="admissiondatetime" width="100" sortable="true">��Ժ���ڼ�ʱ��</th>
                <th field="doctorincharge" width="100" sortable="true">����ҽ������@����</th>
                <th field="scheduleid" width="100" sortable="true">����id��</th>
                <th field="diagbeforeoperation" width="100" sortable="true">��Ҫ���</th>
                <th field="scheduleddatetime" width="100" sortable="true">ԤԼ���иô����������ڼ�ʱ��</th>
                <th field="keepspecimensign" width="100" sortable="true">�Ƿ����걾</th>
                <th field="operatingroom" width="100" sortable="true">�����Ҵ���@����</th>
                <th field="surgeon" width="100" sortable="true">����ҽʦ����@����</th>
                <th field="inpatpreillness" width="100" sortable="true">�ֲ�ʷ</th>
                <th field="inpatpastillness" width="100" sortable="true">����ʷ</th>
                <th field="inpatfamillness" width="100" sortable="true">����ʷ</th>
                <th field="labinfo" width="100" sortable="true">�Ҹ�÷�������Խ��</th>
            </tr>
        </thead>
    </table>

    <!--toolbar��������datagrid��toolbar�Զ�������-->
    <div id="toolbar">
        <table style="width: 100%;">
            <tr>
                <td>
                    <!--��ѯ������-->
                    <table>
                        <tr>
                            <!--Page����ѡ��ģʽ-->
                            <td>
                                <select onchange="$('#datagrid').datagrid({singleSelect:(this.value==0)})">
                                    <option value="0">��ѡģʽ</option>
                                    <option value="1">��ѡģʽ</option>
                                </select></td>

                            <!--��ѯ�ؼ�-->
                            <td>
                                <!--
                    �����ֶ�<input id="so_�ֶ�����"  class="easyui-combobox" panelHeight="auto"  data-options="valueField:'������Ӧcode�ֶ���',textField:'������Ӧname�ֶ���', url:'/common/codeDataHandler.ashx?tabName=�������'"/>
                    <input id="date"     class="easyui-datebox" type="text" />
                    -->
                            </td>
                            <!--�����ؼ���-->
                            <td>
                                <input id="so_keywords" class="easyui-searchbox" data-options="prompt:'�������ѯ�ؼ���',searcher:searchData"></input></td>
                        </tr>
                    </table>
                </td>
                <!--button��ť������-->
                <td style="text-align: right;">
                    <a href="javascript:void(0)" class="easyui-linkbutton" id="linkbuttonInfo" iconcls="icon-search" plain="false" onclick="infoForm();">�鿴</a>
                    <a href="javascript:void(0)" class="easyui-linkbutton" id="linkbuttonAdd" iconcls="icon-add" plain="false" onclick="newForm();">���</a>
                    <a href="javascript:void(0)" class="easyui-linkbutton" id="linkbuttonEdit" iconcls="icon-edit" plain="false" onclick="editForm();">�༭</a>
                    <a href="javascript:void(0)" class="easyui-linkbutton" id="linkbuttonDel" iconcls="icon-cancel" plain="false" onclick="destroy();">ɾ��</a>
                    <a href="javascript:void(0)" class="easyui-linkbutton" id="linkbuttonExport" iconcls="icon-save" plain="false" onclick="exportData();">����</a>
                    <a href="javascript:void(0)" class="easyui-linkbutton" id="linkbuttonPrint" iconcls="icon-print" plain="false" onclick="CreateFormPage('OPListForSpecimen', $('#datagrid'));">��ӡ</a>
                </td>
            </tr>
        </table>
    </div>

    <!--diaglog���ڣ����ڱ༭����-->
    <div id="dlg" class="easyui-dialog" closed="true"></div>

    <script type="text/javascript">
        var url;
        /*������*/
        function newForm() {
            $('#dlg').dialog({
                title: 'OPListForSpecimen-�������',
                width: 650,
                height: 450,
                closed: false,
                cache: false,
                href: 'OPListForSpecimen_info.aspx?mode=ins'
            });
        }

        /*�鿴����*/
        function infoForm() {
            var rows = $('#datagrid').datagrid('getSelections');
            if (rows.length > 0) {
                if (rows.length == 1) {
                    var row = $('#datagrid').datagrid('getSelected');
                    $('#dlg').dialog({
                        title: 'OPListForSpecimen-�鿴����',
                        width: 650,
                        height: 450,
                        closed: false,
                        cache: true,
                        href: 'OPListForSpecimen_info.aspx?mode=inf&pk=' + row.id
                    });
                } else {
                    $.messager.alert('����', '�鿴����ֻ��ѡ��һ������', 'warning');
                }
            } else {
                $.messager.alert('����', '��ѡ������', 'warning');
            }
        }

        /*�޸�����*/
        function editForm() {
            var rows = $('#datagrid').datagrid('getSelections');
            if (rows.length > 0) {
                if (rows.length == 1) {
                    var row = $('#datagrid').datagrid('getSelected');
                    $('#dlg').dialog({
                        title: 'OPListForSpecimen-�޸�����',
                        width: 650,
                        height: 450,
                        closed: false,
                        cache: true,
                        href: 'OPListForSpecimen_info.aspx?mode=upd&pk=' + row.id
                    });
                } else {
                    $.messager.alert('����', '�޸Ĳ���ֻ��ѡ��һ������', 'warning');
                }
            } else {
                $.messager.alert('����', '��ѡ������', 'warning');
            }
        }

        /*ɾ��ѡ������,������¼PK���������ö���,�ֿ�*/
        function destroy() {
            var rows = $('#datagrid').datagrid('getSelections');
            if (rows.length > 0) {
                var pkSelect = "";
                for (var i = 0; i < rows.length; i++) {
                    row = rows[i];
                    if (i == 0) {
                        pkSelect += row.id;
                    } else {
                        pkSelect += ',' + row.id;
                    }
                }
                $.messager.confirm('��ʾ', '�Ƿ�ȷ��ɾ�����ݣ�', function (r) {
                    if (r) {
                        $.post('OPListForSpecimen_handler.ashx?mode=del&pk=' + pkSelect, function (result) {
                            if (result.success) {
                                $.messager.alert('��ʾ', result.msg, 'info', function () {
                                    $('#datagrid').datagrid('reload');    //���¼���������
                                });
                            } else {
                                $.messager.alert('����', result.msg, 'warning');
                            }
                        }, 'json');
                    }
                });
            } else {
                $.messager.alert('����', '��ѡ������', 'warning');
            }
        }

        /*��ѯ������������*/
        function getSearchParm() {
            //������������׷�Ӳ�������
            /*comboboxֵ��ȡ����,��������������ѯ�������*/
            //var v_so_�ֶ����� = $('#so_�ֶ�����').combobox('getValue');
            var v_parm
            var v_so_keywords = $('#so_keywords').searchbox('getValue');
            v_parm = 'so_keywords=' + escape(v_so_keywords);
            return v_parm;
        }

        /*��ѯ����*/
        function searchData() {
            /*��˵���Excel����������������datagrid����load�������ز�����ֱ����URL���ݲ���*/
            var Parm = getSearchParm();//��ò�ѯ����������������URL���ݲ�ѯ����
            var QryUrl = 'OPListForSpecimen_handler.ashx?mode=qry&' + Parm;
            $('#datagrid').datagrid({ url: QryUrl });
        }

        /*��������*/
        function exportData() {
            var Parm = getSearchParm();//��ò�ѯ����������������URL���ݲ�ѯ����
            var QryUrl = 'OPListForSpecimen_handler.ashx?mode=exp&' + Parm;
            $.post(QryUrl, function (result) {
                if (result.success) {
                    window.location.href = result.msg;
                } else {
                    $.messager.alert('����', result.msg, 'warning');
                }
            }, 'json');
        }

        /*�ر�dialog���¼���datagrid����*/
        $('#dlg').dialog({
            onClose: function () {
                $('#datagrid').datagrid('reload'); //���¼���������
            }
        });
        function getQuery(sel) {
            var change = sel.value;
            if (change == 2) {
                document.getElementById("getcode").style.visibility = "hidden";
                document.getElementById("getdate").style.visibility = "visible";
            }
            else {
                document.getElementById("getdate").style.visibility = "hidden";
                document.getElementById("getcode").style.visibility = "visible";
            }
        }
    </script>

</body>
</html>
