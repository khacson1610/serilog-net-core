# serial-log-.net-core 3.1

### NuGet package 
```sh
Serilog
Serilog.Settings.Configuration
Serilog.Formatting.Compact
Serilog.Sinks.File
Serilog.Sinks.DateFormatPath
Serilog.Extensions.Logging
```

### appsettings.json
```sh
"Serilog": {
    "Using": [ "Serilog.Sinks.File" ],
    "MinimumLevel": "Debug",
    "WriteTo": [
      {
        "Name": "File",
        "Args": {
          "path": "D:\\Logs\\Log.json",
          "formatter": "Serilog.Formatting.Compact.CompactJsonFormatter, Serilog.Formatting.Compact",
          "rollingInterval": "Day",
          "retainedFileCountLimit": 30,
          "fileSizeLimitBytes": 2000,
          "rollOnFileSizeLimit": true
        }
      }
    ],
    "Enrich": [ "FromLogContext", "WithThreadId" ],
    "Properties": {
      "Application": "Demo.Serilog"
    }
  }
```
### Logs level
|Level   | Usage  |
|---|---|
| Debug  |  Debug is used for internal system events that are not necessarily observable from the outside, but useful when determining how something happened. |
|  Information |  Information events describe things happening in the system that correspond to its responsibilities and functions. Generally these are the observable actions the system can perform. |
|  Warning |  When service is degraded, endangered, or may be behaving outside of its expected parameters, Warning level events are used. |
|  Error |  When functionality is unavailable or expectations broken, an Error event is used. |
|  Fatal |  The most critical level, Fatal events demand immediate attention. |
