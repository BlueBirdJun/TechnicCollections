 services.AddHangfire(x => x.SetDataCompatibilityLevel(CompatibilityLevel.Version_170)
                .UseSimpleAssemblyNameTypeSerializer()
                .UseRecommendedSerializerSettings()
                .UseSqlServerStorage(hangcontainer
                , new SqlServerStorageOptions
                {
                    CommandBatchMaxTimeout = TimeSpan.FromMinutes(5),
                    SlidingInvisibilityTimeout = TimeSpan.FromMinutes(5),
                    QueuePollInterval = TimeSpan.Zero,
                    UseRecommendedIsolationLevel = true,
                    UsePageLocksOnDequeue = true,
                    DisableGlobalLocks = true,
                }));
            services.AddHangfireServer(p => p.WorkerCount = 2);
            //work count 인스턴스 갯수



CS Source

Que에 작업넣기 
BackgroundJob.Enqueue(() => RegProcess(jb));



