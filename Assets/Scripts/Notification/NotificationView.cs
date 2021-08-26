using System;
using UnityEngine;
using UnityEngine.UI;
using Unity.Notifications.Android;


public class NotificationView : MonoBehaviour
{
    private const string AndroidNotificationId = "android_notification_id";

    [SerializeField]
    private Button _showNotificationButton;

    private void Start()
    {
        _showNotificationButton.onClick.AddListener(CreateNotificationAndroid);
    }

    private void OnDestroy()
    {
        _showNotificationButton.onClick.RemoveAllListeners();
    }

    

    private void CreateNotificationAndroid()
    {
        var androidNotificationChannel = new AndroidNotificationChannel
        {
            Id = AndroidNotificationId,
            Name = "Улучшение замка",
            Importance = Importance.High,
            CanBypassDnd = true,
            CanShowBadge = true,
            EnableLights = true,
            EnableVibration = true,
            LockScreenVisibility = LockScreenVisibility.Public
        };

        AndroidNotificationCenter.RegisterNotificationChannel(androidNotificationChannel);

        var androidNotification = new AndroidNotification
        {
            Color = Color.white,
            RepeatInterval = TimeSpan.FromSeconds(86400)
        };

        AndroidNotificationCenter.SendNotification(androidNotification, AndroidNotificationId);
    }

   
}
