@REM set path=E:\app\Administrator\product\11.2.0\dbhome_1\BIN\exp.exe;.;
@echo off
set sFolder=E:\c#workspace\mchisDB
if not exist %sFolder% (md %sFolder%)
cd %sFolder%
set dback=%date:~0,10%
if not exist %dback% (md %dback%)
cd %dback%

set dmpfile=%sFolder%\%dback%\mcyl_%dback%.dmp 
set logfile=%sFolder%\%dback%\mcyl_%dback%.log 

E:\app\Administrator\product\11.2.0\dbhome_1\BIN\exp.exe mcyl/mcyl@orcl  file=%dmpfile% log=%logfile% 

call cmd