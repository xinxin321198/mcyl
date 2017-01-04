# mcyl
##自己写的his系统，基于。net和C#的winform，因各种原因未能继续
### 1.业务功能上实现到基本门诊挂号、门诊医生坐诊、收费室划价、药房调拨药品、药房发药
### 2.基础功能上有基本的RBAC控制的实现，以及科室管理、行政区划管理、数据字典管理、登录日志管理、供应商管理、ICD-10管理、居民管理、医院工作人员管理、药品的管理（入库、出库、调拨）、诊疗项目管理
### 3.技术架构使用常见的三层架构进行开发，界面层、业务逻辑层、数据访问层，数据库使用oracle 11g，数据库驱动方面因。net4.0微软不再提供对oracle的支持，所以选用oracle官方提供的ODP.NET
### 4.UI暂时使用winForm，未使用第三方的UI库或WPF，但是在原生的UI组件上封装了一些易与使用的方式方法
### 5.业务逻辑层和数据库访问层预留了接口->实现的方式，方便未来引入IOC相关框架进行各层之间解耦（但目前未引入任何IOC框架，故还是各层耦合）
### 6.数据访问层考虑再三，最终也未使用任何ORM框架，之前考虑过微软的EF和第三方的Nhibernate
### 7.提供了一些常用工具类，比如：配置文件操作、GUID生成器、IP地址、MD5加密、NPOI操作excel、汉字转拼音、汉子转五笔、日期时间操作等

[基于C#的his系统](https://github.com/xinxin321198/mcyl/)<br/>
[代码生成器](https://github.com/xinxin321198/mcylCodeGenerator)<br/>
[文档](https://github.com/xinxin321198/mcylDoc)<br/>

* 昵称：loserStar<br/>
* email:xinxin321198@gmail.com<br/>
* email2:362527240@qq.com<br/>
* qq:362527240<br/>
* github:https://github.com/xinxin321198<br/>