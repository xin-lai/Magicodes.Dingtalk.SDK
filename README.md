# Magicodes.Dingtalk.SDK
钉钉SDK

## 特色

* 编写简单,易于理解
* 支持成功状态判断
* 支持Token管理
* 返回结果命名易于理解并符合C#命名规范

## Nuget

| 名称     |      Nuget      | 
|----------|:-------------:|
| Magicodes.Dingtalk.SDK  |  [![NuGet](https://buildstats.info/nuget/Magicodes.Dingtalk.SDK)](https://www.nuget.org/packages/Magicodes.Dingtalk.SDK) |


## VNext

* 完善接口

## 使用

### 注册服务并且设置服务生命周期

            services.AddTransient<TokenApi>();
            services.AddTransient<AttendanceApi>();
            services.AddSingleton<TokenManager>();
            services.AddSingleton<StaffApi>();
            services.AddTransient<DailyApi>();
            services.AddTransient<DepartmentApi>();
            services.AddTransient<NoticeApi>();

### 通过构造函数注入

        private readonly AttendanceApi _attendanceApi;
        private readonly IConfiguration _configuration;
        private readonly ILogger<ExampleBackgroundServices> _logger;
        private readonly StaffApi _staffApi;
        private Timer _timer;

        public ExampleBackgroundServices(ILogger<ExampleBackgroundServices> logger, AttendanceApi attendanceApi,
            StaffApi staffApi, IConfiguration configuration)
        {
            _logger = logger;
            _attendanceApi = attendanceApi;
            _staffApi = staffApi;
            _configuration = configuration;
        }

### 使用接口

            //获取排班记录
            var userList = await GetCheduleUserList();
            if (userList == null || userList.Count == 0)
            {
                _logger.LogWarning("未能获取到考勤人员！");
                return;
            }

## 单元测试

无，因为钉钉后端接口必须设置信任IP，而且需使用相关机房IP