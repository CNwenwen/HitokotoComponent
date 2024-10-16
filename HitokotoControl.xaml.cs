﻿using System.Net.Http;
using System.Threading.Tasks;
using ClassIsland.Core.Controls;
using System.Windows;
using ClassIsland.Core.Abstractions.Controls;
using ClassIsland.Core.Attributes;
using MaterialDesignThemes.Wpf;

namespace HitokotoComponent
{
    [ComponentInfo(
        "81941A41-314C-4117-981B-920AEE1E3EB3",
            "一言",
            PackIconKind.CalendarOutline,
            "在主界面显示一言。"
        )]
    public partial class HitokotoControl : ComponentBase
    {
        private readonly HttpClient _httpClient = new HttpClient();

        public HitokotoControl()
        {
            InitializeComponent();
            LoadHitokotoAsync();
        }

        public async void LoadHitokotoAsync()
        {
            try
            {
                var result = "等待";
                if ( PluginSettingsPage.Mode == 0)
                {
                    result = await _httpClient.GetStringAsync("https://v1.hitokoto.cn/?encode=text");
                }
                else
                {
                    result = await _httpClient.GetStringAsync("https://v1.hitokoto.cn/?encode=text");
                }
                Dispatcher.Invoke(() => HitokotoText.Text = result);
            }
            catch (HttpRequestException)
            {
                Dispatcher.Invoke(() => HitokotoText.Text = "加载失败");
            }
        }
    }
}