using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Background;
using Windows.UI.Core;

namespace Weather.BackgroundTask
{
    /// <summary>
    /// 后台
    /// </summary>
    public class BackgroundTaskExecute
    {
        public const string BackgroundTaskEntryPoint = "Weather.BackgroundTask.UpdateTileTask";
        public const string BackgroundTaskName = "ZXJUpdateForTile";
        public static string BackgroundTaskProgress = "";
        public static bool BackgroundTaskRegistered = false;


        public void Execute()
        {
            foreach (var task in BackgroundTaskRegistration.AllTasks)
            {
                if (task.Value.Name == BackgroundTaskName)
                {
                    AttachProgressAndCompletedHandlers(task.Value);
                    break;
                }
            }
        }

        public async void RegisterBackgroundTask()
        {
            var backgroundAccessStatus = await BackgroundExecutionManager.RequestAccessAsync();
            if (backgroundAccessStatus == BackgroundAccessStatus.AllowedMayUseActiveRealTimeConnectivity ||
                backgroundAccessStatus == BackgroundAccessStatus.AllowedWithAlwaysOnRealTimeConnectivity)
            {
                try
                {
                    IBackgroundTrigger backgroundTrigger = new TimeTrigger(15, false);
                    var task = BackgroundTaskHelper.RegisterBackgroundTask(BackgroundTaskEntryPoint,
                                                                       BackgroundTaskName,
                                                                       backgroundTrigger,
                                                                       null);
                    await task;
                    AttachProgressAndCompletedHandlers(task.Result);
                }
                catch (Exception)
                {
                    
                    throw;
                }
               
                //UpdateUI();
            }
        }

        private void AttachProgressAndCompletedHandlers(IBackgroundTaskRegistration task)
        {
            task.Progress += new BackgroundTaskProgressEventHandler(OnProgress);
            task.Completed += new BackgroundTaskCompletedEventHandler(OnCompleted);
        }

        /// <summary>
        /// Handle background task progress.
        /// </summary>
        /// <param name="task">The task that is reporting progress.</param>
        /// <param name="e">Arguments of the progress report.</param>
        private void OnProgress(IBackgroundTaskRegistration task, BackgroundTaskProgressEventArgs args)
        {
            //UpdateUI();
        }

        /// <summary>
        /// Handle background task completion.
        /// </summary>
        /// <param name="task">The task that is reporting completion.</param>
        /// <param name="e">Arguments of the completion report.</param>
        private void OnCompleted(IBackgroundTaskRegistration task, BackgroundTaskCompletedEventArgs args)
        {
            //UpdateUI();
        }

        /// <summary>
        /// Update the scenario UI.
        /// </summary>
        private void UpdateUI()
        {
            //await Depe Dispatcher.RunAsync(CoreDispatcherPriority.Normal);
        }

        /// <summary>
        /// 移除后台任务
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UnregisterBackgroundTask()
        {
            BackgroundTaskHelper.UnregisterBackgroundTasks(BackgroundTaskName);
            //UpdateUI();
        }
    }
}
