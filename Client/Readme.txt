美创科技医疗系统
联系人：罗新鑫
联系邮箱：362527240@qq.com
联系QQ：362527240
联系电话：15087010221

项目提交规范：
1.先学习使用SVN，会基本的检出、提交、还原，更新等
2.提交代码时不要提交工程目录下的bin和obj目录，这两个目录是存放VS根据项目源码生成的目标文件和可执行文件
3.提交文件时注意，需要提交源码及项目相关的*.csproj配置文件

开发环境配置：
一、配置Oracle的odac驱动
1、装好vs2012后，安装svn
2、打开--subversion项目，添加SVN服务器的地址，输入账户密码，检出项目（ps：vs上的svn插件会有小bug，有些时候svn地址输入是对的，显示出的项目为空，遇到这种情况的话，重新安装一个针对windows的tortoiseSVN，使用这个软件检出到本地，再使用VS打开项目）
3、项目连接oracle，项目使用.net framework4.5版本，此版本微软不再提供连接oracle的驱动（之前版本使用System.Data.Oracle程序集）,使用oracle官方下载的ODAC驱动，Oracle.DataAccess
4、（参考oracle文档中的oracleODAC常见问题.docx）安装ODAC,从oracle官网下载本机系统对应的X86或X64版本的ODAC程序,解压后使用命令行运行目录下的install.bat
(a、按住shift点右键，会多出一项“在此处打开命令窗口”，把install。bat拖进来回车。
b、先安装basic（后面跟路径 false），再装odp.net4  （后面跟路径 true）
c、在项目中引用ODAC安装目录\odp.net\bin\4\Oracle.DataAccess.dll,动态链接库
）
5、运行程序（未能加载文件或程序集“Oracle.DataAccess, Version=4.112.2.0, Culture=neutral, PublicKeyToken=89b483f429c47342”或它的某一个依赖项。系统找不到指定的文件），可能安装不正确或者版本不对应

6、配置使用32位的OBAC自带的客户端+PLSQL管理oracle，（因为plsql不支持与64位oracle客户端的连接，所以如果本机是64位操作系统并且安装了64位ODAC，必须重新安装一个32位的oracle客户端才可以使用plsql），如果本机是32位操作系统，则可以直接使用ODAC自带的客户端进行连接，但是得手动在系统环境变量中配置一个监听程序
7、使用32位ODAC配置环境变量及监听（安装的32位客户端不必配置此步骤）
(1)新建ORACLE_HOME：ODAC的安装目录（类似～app\Administrator\product\ .1.0\client_1，我这里的安装目录是E:\app\ljp\product\11.2.0\client_2）
(2)新建LD_LIBRARY_PATH ：%ORACLE_HOME%
(3)新建TNS_ADMIN ： %ORACLE_HOME%（这里是监听设置，应该是tnsnames.ora的目录，我设置的是E:\oracle\product\10.1.0\db_1\NETWORK\ADMIN，当然也可以将配置好的tnsnames.ora文件拷贝到%ORACLE_HOME%目录下）
(4)在PATH的最前面追加：%ORACLE_HOME%

8、在oracle客户端得根目录下新建两层文件夹\NETWORK\ADMIN（如果没有的话），将已经安装的oracle11g的根目录\product\11.2.0\dbhome_1\network\admin\tnsnames.ora文件复制过来（没有安装oracle的话手动拷贝一个）。
配置plsql的首选项:打开plsql，点取消不进行连接数据库。进入之后，在工具栏中找到工具》首选项，OCI库：e:\instantclient_11_2\oci.dll（ODAC的根目录下的oci.dll）设置完成之后点击应用即可

9、NLS_Lang 客户端不能被确定 .字符集问题
添加环境变量
NLS_LANG = SIMPLIFIED CHINESE_CHINA.AL32UTF8


10、安装plsql-32管理oracle的工具后要连接数据库进行管理，需要安装32位客户端，具体详见下文 ：
【plsql是不可以直接连接64位oracle数据库，只能连接32位。解压完成后，在instantclient_11_2目录下新建两层文件夹\NETWORK\ADMIN，将已经安装的oracle11g的根目录\product\11.2.0\dbhome_1\network\admin\tnsnames.ora文件复制过来。配置plsql的首选项:打开plsql，点取消不进行连接数据库。进入之后，在工具栏中找到工具》首选项，oracle主目录名：e:\instantclient_11_2，OCI库：e:\instantclient_11_2\oci.dll设置完成之后点击应用即可。】

11、NLS_Lang 客户端不能被确定 .字符集问题
添加环境变量
NLS_LANG = SIMPLIFIED CHINESE_CHINA.AL32UTF8
或者（NLS_LANG 值为  SIMPLIFIED CHINESE_CHINA.ZHS16GBK）


12、启动运行出错：
无法直接启动带有“类库输出类型”的项目。
若要调试此项目，请在此解决方案中添加一个引用库项目的可执行项目。将这个可执行项目设置为启动项目。
----这是因为需要把client右键设置为启动项目，然后再“重新生成解决方案”，即可启动程序！

二、配置App.config中数据库连接

    <add name="oracleConnection" connectionString="Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=ORCL)));User Id=mcyl;Password=mcyl;" />

三、配置汉字转拼音码五笔码的文件
copy“拼音五笔转码表”文件下的CodeConfig目录到项目bin目录下