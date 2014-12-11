// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
// PARTICULAR PURPOSE.
//
// Copyright (c) Microsoft Corporation. All rights reserved

using System;
using System.Threading;
using System.Threading.Tasks;
using Windows.ApplicationModel.Background;
using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.UI.Notifications;
using Windows.Web.Syndication;

namespace Weather.App.BackgroundTask
{
    public sealed class UpdateTileTask : IBackgroundTask
    {
        public void Run(IBackgroundTaskInstance taskInstance)
        {
            BackgroundTaskDeferral _deferral = taskInstance.GetDeferral();

            UpdateTile();

            //表示完成任务
            _deferral.Complete();
        }


        public void UpdateTile()
        {
            DTO.TileModel tileModel = new DTO.TileModel();
            tileModel.ImagerSrc = "ms-appx:///Assets/Logo.scale-100.png";
            tileModel.TextHeading = "气温 17";
            tileModel.TextBody1 = "风向 东北风";
            tileModel.TextBody2 = "风力 2级";
            tileModel.TextBody3 = "湿度 4%";
            Common.TileHelper.UpdateTileNotifications(tileModel);
            Common.TileHelper.UpdateBadgeWithNumber(10);
        }
    }
}
