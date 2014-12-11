using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Background;

namespace Weather.Utils
{
    /// <summary>
    /// 轮询通知
    /// </summary>
    public static class PushAndPeriodicNotifications
    {
        private const string PUSH_NOTIFICATIONS_TASK_NAME = "UpdateWeather";
        private const string PUSH_NOTIFICATIONS_TASK_ENTRY_POINT = "PushNotificationsHelper.MaintenanceTask";
        private const int MAINTENANCE_INTERVAL = 60; // Check for channels that need to be updated every 10 days
        public static void RegisterTask()
        {
            if (GetRegisteredTask() == null)
            {
                BackgroundTaskBuilder taskBuilder = new BackgroundTaskBuilder();
                MaintenanceTrigger trigger = new MaintenanceTrigger(MAINTENANCE_INTERVAL, false);
                taskBuilder.SetTrigger(trigger);
                taskBuilder.TaskEntryPoint = PUSH_NOTIFICATIONS_TASK_ENTRY_POINT;
                taskBuilder.Name = PUSH_NOTIFICATIONS_TASK_NAME;

                SystemCondition internetCondition = new SystemCondition(SystemConditionType.InternetAvailable);
                taskBuilder.AddCondition(internetCondition);
                taskBuilder.Register();
            }
        }

        public static void UnregisterTaskButton()
        {
            IBackgroundTaskRegistration task = GetRegisteredTask();
            task.Unregister(true);

        }

        public static IBackgroundTaskRegistration GetRegisteredTask()
        {
            foreach (var task in BackgroundTaskRegistration.AllTasks.Values)
            {
                if (task.Name == PUSH_NOTIFICATIONS_TASK_NAME)
                {
                    return task;
                }
            }
            return null;
        }
    }
}
