using NotificationsExtensions.TileContent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Notifications;

namespace Weather.App.Common
{
    public class TileHelper : Utils.TileHelper
    {
        /// <summary>
        /// 更新默认磁贴内容(不通用)
        /// </summary>
        /// <param name="tileModel"></param>
        public static void UpdateTileNotifications(DTO.TileModel tileModel)
        {

            ITileWide310x150ImageAndText01 tileWide310x150ImageAndText01 = TileContentFactory.CreateTileWide310x150ImageAndText01();

            ITileSquare150x150PeekImageAndText01 tileSquare150x150PeekImageAndText01 = TileContentFactory.CreateTileSquare150x150PeekImageAndText01();
            //磁铁内容赋值
            tileSquare150x150PeekImageAndText01.Image.Src = tileModel.ImagerSrc;
            tileSquare150x150PeekImageAndText01.TextHeading.Text = tileModel.TextHeading;
            tileSquare150x150PeekImageAndText01.TextBody1.Text = tileModel.TextBody1;
            tileSquare150x150PeekImageAndText01.TextBody2.Text = tileModel.TextBody2;
            tileSquare150x150PeekImageAndText01.TextBody3.Text = tileModel.TextBody3;
            tileWide310x150ImageAndText01.Square150x150Content = tileSquare150x150PeekImageAndText01;
            tileWide310x150ImageAndText01.Image.Src = "ms-appx:///Assets/WideLogo.scale-100.png";
            tileWide310x150ImageAndText01.TextCaptionWrap.Text = tileModel.TextHeading + tileModel.TextBody1 + tileModel.TextBody2 + tileModel.TextBody3;
            //更新至磁贴
            TileUpdateManager.CreateTileUpdaterForApplication().Update(tileWide310x150ImageAndText01.CreateNotification());

        }

    }
}
