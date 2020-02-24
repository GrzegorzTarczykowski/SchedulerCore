# SchedulerCore

“Microsoft” Way

NuGet:

Install-Package Microsoft.Windows.Compatibility

Deploying: 

dotnet publish -r win-x64 -c Release

sc create SchedulerCore BinPath=C:\SchedulerCore\Scheduler.exe

sc start SchedulerCore

sc stop SchedulerCore

sc delete SchedulerCore

“Topshelf” Way

NuGet:

Install-Package Topshelf

Deploying: 

dotnet publish -r win-x64 -c Release

Scheduler.exe install

Scheduler.exe start
