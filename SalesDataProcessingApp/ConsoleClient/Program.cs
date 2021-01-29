﻿using ConsoleClient.Helpers;
using Core;
using Core.Interfaces;
using Core.Services;
using DAL;
using System;

namespace ConsoleClient
{
    class Program
    {
        public static DataContext context;

        public static IDataService dataService;

        public static FileWatcher fileWatcher;

        static void Main(string[] args)
        {
            bool isWorking = true;

            CreateContext();

            InitDataBase();

            InitDataService(context);

            InitWatcher();

            Console.WriteLine("Hello effective manager!");

            while (isWorking)
            {
                fileWatcher.StartWatch(dataService);

                Console.WriteLine("Searching for files... To stop, please input \"stop\":");

                var input = Console.ReadLine().Trim();

                if (input == "stop")
                { isWorking = false; }
            }

            fileWatcher.StopWatch();

            Console.WriteLine("Exit...");
        }

        public static void CreateContext()
        {
            context = new DataContext();
        }

        public static void InitDataBase()
        {
            context.Database.Exists();

            InitData.InitializeData(context);
        }

        public static void InitDataService(DataContext context)
        {
            dataService = new DataService(context);
        }

        public static void InitWatcher()
        {
            fileWatcher = new FileWatcher(ReadConfig.ReadSetting("DataFilesPath"));
        }
    }
}
