/*******************************************************************
/*
/* ��Ŀ��  : RedGlovePermission Preview������B/S��Ȩ�޹���ϵͳ��
/* ��  ��  : Nick.Yan
/*     QQ  : 13458753
/* E-mail  : nick.yanchen@gmail.com
/* ��Դ��ַ:http://www.codeplex.com/RedGlovePermission/
/* ��������:http://www.cnblog.com/nick4
/*
/*******************************************************************


������ϵͳ��һ��С��Ȩ�޹���ϵͳ����Ҫ�Դ�ϵͳ��ܵ�ģʽ���������ܣ�����ʹ��֮ǰ��Ӧ�����˽�ϵͳ��ܣ��Ƿ���������������������ܿ���Ӧ�õ���Сϵͳ�У�������û�ж�����⣬��ϵͳ��Ȩ����Ʒ��棬ֻ�ܸ���һ���ο�����ϵͳ����ʵ���˶�ϵͳ�еĹ���ģ����ƣ���������ģ������Խ�ϵͳȨ�޼ӽ�ȥ���ٽ���Ӧ��Ȩ����Ȩ����ɫ���ٽ���ɫָ�ɸ��û���

    �汾����(Ver 8.12.20)
������ �Ļ��ɹ���ģʽ 
������ ֧��MySQL���� 
������ ������ 
������ ��Ƥ�� 
������ �����¼ 
������ ��ģ��Ȩ���б�ӿ�ֳ�����,������������Ȩ�� 
������ Ĭ��Ȩ�޼ӵ�10��

1.��������

    ����ϵͳ��window 2000/XP/Vista/2008
    �������ԣ�C#,����.net3.5
    �� �� �⣺Sqlserver 2000/2005/2008
    �������ߣ�VS2008/����.net����������

2.����
����(1)�������ݿ�
����������DocĿ¼�������ݿ�ű��ļ�
����(2)���ݿ�����
��������<!--SQL Server-->
        <!--<add key="DataDAL" value="RedGlovePermission.SQLServerDAL" />-->
        <!--<add key="SQLString" value="Database=MyData;Data Source=.;User Id=sa;Password=sa;"/>-->
        <!--My SQL-->
        <add key="DataDAL" value="RedGlovePermission.MySqlDAL" />
        <add key="SqlString" value="host=localhost;userid=root;password=root;database=MyData"/>
����(3)���� Asp.net state Service����
��������<sessionState mode="StateServer" stateConnectionString="tcpip=127.0.0.1:42424" stateNetworkTimeout="14400" timeout="18000"/>
    (3)��ʽ����
��������<StyleList>
��������  <add key="Default" value="Default" />
��������  <add key="White"   value="White" />
��������</StyleList>  
    (4)��������
��������<WebLanguage>    
    ��������<add key="zh-cn" value="����" />
    ��������<add key="zh-tw" value="���w" />
    ��������<add key="en-us" value="English" />    
��������</WebLanguage>

3.ϵͳ��������

�������ȣ���ϵͳʹ��ǰ�����������ú�Ȩ�ޣ��������£�
 
����(1)����Ȩ���б�������ҪȨ�ޣ���ʼȨ��(���/����/�༭/ɾ��/����/���/�ƶ�/��ӡ/����/����)
����(2)�����û������,Ϊ�˷��㽫�û�����
����(3)����ģ�����,������ģ�����
����(4)����ģ�����,�����ģ�飬��ϸ����Ȩ������
����(5)������ɫ����
����(6)������ɫ��Ȩ����ģ��Ȩ��Ȩ�޸���ɫ

���������û�
�����û�����      ����
����Admin        admin
����test1         test
����test2         test
����test3         test

4.�����ƻ� 

��ϵͳ���������ݿ����ݲٶ�д�ڴ����У��޴洢���̣�֧�ֶ����ݿ�,��Ϊ����ģʽ��֧��Access,sqlser,mysql,��֧��Oracle 
��ģ��Ȩ���б�ӿ�ֳ�����,������������Ȩ�� 
�����԰� 
��Ƥ�� 
����Ȩ�޹��� 
�����趨Ȩ�� 
���ɫ 
���¼ģʽ����/form/���㣩 
�û����ÿ�
    �û�ID  ������������ֵ���������͡��Ƿ�������֤����ʾ���ͣ�lab,list,chkbox) 
    �����ע������

5.��Ȩ����
������ϵͳ��ȫ��Դ�����ʹ�ã������Ҫʹ�ã�ϣ�����ܱ�����Ȩ��Ϣ����ϵͳ�᲻�����Ƹ�����ʲô����������ʼ���������кü�����������˵�޷ã�ϣ�����ϵͳ����Ϊ�����ϵ�æ���Ǿ�������ĵ����ˣ�Ҳϣ����������Ѽ����������������ûнˮ�İ����Ǻǣ�Ŀ�����ڷ����Լ��ɹ�

6.��������
��(1)��.������VS2005�д򿪵Ľ���취

   ���ü��±������ļ�*.csproj,�������޸ļ��ɡ�
   ��һ������<Project DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003" ToolsVersion="3.5">�ĳ�
   ��������<Project DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">

���ڶ����������ļ����ҵ�
   ��������<AssemblyName>RedGlovePermission.Web</AssemblyName>
   ������������<FileUpgradeFlags>
   ������������</FileUpgradeFlags>
   ������������<OldToolsVersion>2.0</OldToolsVersion>
   ������������<UpgradeBackupLocation>
   ������������</UpgradeBackupLocation>
   ��������</PropertyGroup>
����������<AssemblyName>RedGlovePermission.Web</AssemblyName>��</PropertyGroup>֮ǰ����ɾ��,�޸�֮��
������������<AssemblyName>RedGlovePermission.Web</AssemblyName>
  ����������</PropertyGroup>

������������<Import Project="$(MSBuildExtensionsPath)\Microsoft\VisualStudio\v9.0\WebApplications\Microsoft.WebApplication.targets" Condition="" />ɾ����û�оͲ��ù�����

�����Ĳ�������������������㻹���ܴ򿪵Ļ�<Import Project="$(MSBuildBinPath)\Microsoft.CSharp.targets" />�滻��
����������<Import Project="$(MSBuildBinPath)\Microsoft.CSharp.targets" />����������һ���ģ�����ʹ�õ�ʱ����������������

��(2)���ݿ��ڵ��뵽sql 2000�С�

�������ṩ2005�����ݽű���Sql2000�ű�����
