﻿// 27 11 2020 Created by Tony Horsham 11:09

using FRTForm.Services;
using FRTForm.Settings;

namespace FRTForm.BlockTime.Settings
{
    // ReSharper disable once InconsistentNaming
    public interface IApplicationSettingsBT : IApplicationSettings
    {
        public string DataApi { get; }
        public ISmsSender SmsSender { get; }
        public IEmailSender EmailSender { get; }
    }
}