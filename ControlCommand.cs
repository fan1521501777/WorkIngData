using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zhumu.RoomControlInterface
{
    public enum ControlCommand : short
    {

        /// <summary>
        /// 通知响应消息
        /// </summary>
        NotifyResponse = 1,

        /// <summary>
        /// 更新GUID成功通知
        /// </summary>
        UpdateGUIDResponse = 2,
        /// <summary>
        /// 会控端连接
        /// </summary>
        ClientConnected = 3,
        /// <summary>
        /// 会控端连接断开
        /// </summary>
        ClientDisConnected = 4,
        /// <summary>
        /// 会控端心跳超时（可显示会控二维码）
        /// </summary>
        ClientTimeOut = 5,
        /// <summary>
        /// 会控端心跳正常
        /// </summary>
        ClientKeepAlive = 6,
        XTKeepAliveResponse = 7,
        XTDiconnectByServer = 8,
        /// <summary>
        /// 认证失败
        /// </summary>
        OAuthError = 9,
        /// <summary>
        /// 认证成功
        /// </summary>
        OAuthPass = 10,
        /// <summary>
        /// 设备用途邮箱认证成功通过
        /// </summary>
        PurposeCheck = 11,

        /// <summary>
        /// 关机
        /// </summary>
        Shutdown = 1001,

        /// <summary>
        /// 重启
        /// </summary>
        Restart = 1002,

        /// <summary>
        /// 获取屏幕分辨率
        /// </summary>
        GetScreenResolution = 2001,

        /// <summary>
        /// 设置屏幕分辨率
        /// </summary>
        SetScreenResolution = 2002,

        /// <summary>
        /// 设置主屏幕
        /// </summary>
        SetMainScreen = 2003,

        /// <summary>
        /// 显示屏幕标识
        /// </summary>
        ShowDisplayName = 2004,
        /// <summary>
        /// 开启会议
        /// </summary>
        StartMeeting = 3001,
        /// <summary>
        /// 离开会议
        /// </summary>
        LeaveMeeting = 3002,
        /// <summary>
        /// 结束会议
        /// </summary>
        EndMeeting = 3003,
        /// <summary>
        /// 加入会议
        /// </summary>
        JoinMeeting = 3004,
        /// <summary>
        /// 获取会议状态
        /// </summary>
        GetMeetingStatus = 3005,
        /// <summary>
        /// 获取参会人列表
        /// </summary>
        GetParticipantsList = 3006,
        /// <summary>
        /// 锁定会议
        /// </summary>
        LockMeeting = 3007,
        /// <summary>
        /// 解除锁定会议
        /// </summary>
        UnlockMeeting = 3008,
        /// <summary>
        /// 静音
        /// </summary>
        MuteAudio = 3009,
        /// <summary>
        /// 解除静音
        /// </summary>
        UnMuteAudio = 3010,
        /// <summary>
        /// 禁用视频
        /// </summary>
        MuteVideo = 3011,
        /// <summary>
        /// 解除禁用视频
        /// </summary>
        UnmuteVideo = 3012,
        /// <summary>
        /// 切换视频列表到演讲者
        /// </summary>
        SwtichToAcitveSpeaker = 3013,
        /// <summary>
        /// 切换视频列表到视频墙
        /// </summary>
        SwitchToVideoWall = 3014,
        /// <summary>
        /// 获取摄像头列表
        /// </summary>
        GetCameraList = 3015,
        /// <summary>
        /// 选择摄像头
        /// </summary>
        SelectCamera = 3016,
        /// <summary>
        /// 获取邀请邮件
        /// </summary>
        GetInviteEmailTpl = 3017,
        /// <summary>
        /// 启动录制
        /// </summary>
        StartRecording = 3018,
        /// <summary>
        /// 关闭录制
        /// </summary>
        StopRecording = 3019,
        /// <summary>
        /// 修改名称
        /// </summary>
        UpdateUserName = 3020,
        /// <summary>
        /// 获取可加入会议的URL
        /// </summary>
        GetJoinMeetingUrl = 3021,
        /// <summary>
        /// 举手
        /// </summary>
        RaiseHand = 3022,
        /// <summary>
        /// 放下手
        /// </summary>
        LowerHand = 3023,
        /// <summary>
        /// 获取音频捕捉列表（获取麦克风）
        /// </summary>
        GetAudioCaptureList = 3024,
        /// <summary>
        /// 获取音频渲染列表（获取扬声器）
        /// </summary>
        GetAudioRenderList = 3025,
        /// <summary>
        /// 设置音频捕捉大小（设置麦克风输入音量大小）
        /// </summary>
        SetAudioCaptureVolume = 3026,
        /// <summary>
        /// 设置音频渲染大小（设置扬声器音量大小）
        /// </summary>
        SetAudioRederVolume = 3027,
        /// <summary>
        /// 锁定共享
        /// </summary>
        LockShare = 3028,
        /// <summary>
        /// 解除锁定共享
        /// </summary>
        UnlockShare = 3029,
        /// <summary>
        /// 焦点视频
        /// </summary>
        SpotlightVideo = 3030,
        /// <summary>
        /// 放下所有人的举手动作🙋‍
        /// </summary>
        LowerAllHands = 3031,
        /// <summary>
        /// PC共享
        /// </summary>
        PcShare = 3032,
        /// <summary>
        /// 手机共享
        /// </summary>
        IphoneShare = 3033,
        /// <summary>
        /// 分享结束
        /// </summary>
        ShareDone = 3034,
        /// <summary>
        /// 设置主持人
        /// </summary>
        MakeHost = 3035,
        /// <summary>
        /// 移除用户
        /// </summary>
        ExpelUser = 3036,
        /// <summary>
        /// 获取会议UI类型
        /// </summary>
        GetMeetingUIType = 3037,
        /// <summary>
        /// 选择麦克风
        /// </summary>
        SelectMic = 3038,
        /// <summary>
        /// 选择扬声器
        /// </summary>
        SelectSpeaker = 3039,
        /// <summary>
        /// 切换模式
        /// </summary>
        SwitchMode = 3040,
        /// <summary>
        /// 回收支持人权限
        /// </summary>
        ReclaimHost = 3041,
        /// <summary>
        /// 
        /// </summary>
        AllowLocalRecording = 3042,
        /// <summary>
        /// 
        /// </summary>
        DisAllowLocalRecording = 3043,
        /// <summary>
        /// 加入密码会议
        /// </summary>
        InputMeetingPasswordAndScreenName = 3044,
        /// <summary>
        /// 
        /// </summary>
        ShowPreOrNextPageVideo = 3045,
        /// <summary>
        /// 
        /// </summary>
        GetWallViewPageInfo = 3046,
        /// <summary>
        /// 开始测试音频
        /// </summary>
        PlayTestAudio = 3047,
        /// <summary>
        /// 关闭测试音频
        /// </summary>
        StopTestAudio = 3048,
        /// <summary>
        /// 开始录音
        /// </summary>
        RecordTestAudio = 3049,
        /// <summary>
        /// 播放录音
        /// </summary>
        PlayRecordedTestAudio = 3050,
        /// <summary>
        /// 自动更改视频页面
        /// </summary>
        AutoChangeVideoPage = 3051,
        /// <summary>
        /// 停止自动更改视频页面
        /// </summary>
        StopChangeVideoPage = 3052,
        /// <summary>
        /// 
        /// </summary>
        AudioCheckComplete = 3053,
        /// <summary>
        /// 
        /// </summary>
        EnableMirrorVideo = 3054,
        /// <summary>
        /// 控制摄像头
        /// </summary>
        PTZControl = 3055,
        /// <summary>
        /// 切换窗口
        /// </summary>
        SwitchShareFloatoVideo = 3056,
        /// <summary>
        /// 拒绝加入会议
        /// </summary>
        InviteReject = 3057,
        /// <summary>
        /// 同意加入会议
        /// </summary>
        InviteAgree = 3058,
        /// <summary>
        /// 呼叫对方加入会议
        /// </summary>
        Call = 3059,
        /// <summary>
        /// 取消呼叫
        /// </summary>
        CancelCall = 3060,
        /// <summary>
        /// 选定视频
        /// </summary>
        PinVideo = 3061,
        /// <summary>
        /// 获取链接屏幕数
        /// </summary>
        GetScreenNum = 3062,
        /// <summary>
        /// 切换主次屏
        /// </summary>
        SwitchoverScreen = 3063,
        /// <summary>
        /// 获取登录信息
        /// </summary>
        GetNotifyData = 3064,
        /// <summary>
        /// 获取H323? 信息
        /// </summary>
        GetH323Info = 3065,
        /// <summary>
        /// 云视讯呼叫
        /// </summary>
        Call4YSX = 3066,
        /// <summary>
        /// 获取呼叫历史
        /// </summary>
        GetCallHistoryList = 3067,
        /// <summary>
        /// 清空呼叫历史
        /// </summary>
        ClearCallHistory = 3068,
        /// <summary>
        /// 获取日程列表
        /// </summary>
        GetSchMeetingList = 3069,
        /// <summary>
        /// 云视讯校验联系人
        /// </summary>
        CheckUser = 3070,
        /// <summary>
        /// 邀请入会
        /// </summary>
        InviteUser = 3071,
        /// <summary>
        /// 云视讯日程加会
        /// </summary>
        SchJoinMeeting = 3072,
        /// <summary>
        /// 在视频墙上隐藏或显示没有视频用户
        /// </summary>
        HideOrShowNoVideoUserOnVideoWall,
        /// <summary>
        /// 更改视频窗口模式
        /// </summary>
        ChangeFloatoActiveSpkVideoSize,
        /// <summary>
        /// 扫描WIFI
        /// </summary>
        ScanWifi = 4000,
        /// <summary>
        /// 网络配置
        /// </summary>
        NetworkConfig = 4001,
        /// <summary>
        /// 关闭WIFOI
        /// </summary>
        DisconnectWifi = 4002,
        /// <summary>
        /// 网络代理设置
        /// </summary>
        ProxyConfig = 4003,
        /// <summary>
        /// 更新虚拟WIFI
        /// </summary>
        UpdateVirtualWifi,
        /// <summary>
        /// 检查网络
        /// </summary>
        NetworkCheck,
        /// <summary>
        /// 发送日志
        /// </summary>
        SendLog = 5001,
        /// <summary>
        /// 检查版本
        /// </summary>
        CheckVersion = 6001,
        /// <summary>
        /// 更新版本
        /// </summary>
        UpdateVersion = 6002,
        /// <summary>
        /// 开启PIN
        /// </summary>
        EnablePIN = 6003,
        /// <summary>
        /// 禁用PIN
        /// </summary>
        DisablePIN = 6004,
        /// <summary>
        /// 检查pin码
        /// </summary>
        CheckPIN = 6005,
        /// <summary>
        /// 重置
        /// </summary>
        Reset = 6006,//
        /// <summary>
        /// 绑定账户
        /// </summary>
        BindAccount = 6007,
        /// <summary>
        /// 注销
        /// </summary>
        Logout = 6008,
        /// <summary>
        /// 设置时间
        /// </summary>
        SetTime = 6009,
        /// <summary>
        /// 
        /// </summary>
        BindAccountForce = 6010,
        /// <summary>
        /// 会控App注销
        /// </summary>
        Logout4Nuc = 6011,
        /// <summary>
        /// 修改pin码
        /// </summary>
        UpdatePin = 6012,
        /// <summary>
        /// 设置
        /// </summary>
        Setting,

        //中转服务实现的接口,以9打头
        /// <summary>
        /// 可以邀请的会议列表
        /// </summary>
        GetInviteList = 9001,
        /// <summary>
        /// 收到邀请
        /// </summary>
        Invite = 9002,
        /// <summary>
        /// 发送Email
        /// </summary>
        SendEmail = 9003,
        /// <summary>
        /// 快捷加入会议列表
        /// </summary>
        GetJoinMeetingList = 9004,
        /// <summary>
        /// 单独获取状态
        /// </summary>
        GetSRMeetingStatus = 9005,
        /// <summary>
        /// 获取会议历史
        /// </summary>
        GetMeetingHistory = 9006,
        /// <summary>
        /// 清空会议历史
        /// </summary>
        ClearMeetingHistory = 9007,
        /// <summary>
        /// /App认证
        /// </summary>
        AppAuth = 9008,
        /// <summary>
        /// 获取会议列表，在线的会议中或不在会议中
        /// </summary>
        GetMeetingList = 9009,
        /// <summary>
        /// 收到呼叫
        /// </summary>
        OnCallIn = 9010,
        /// <summary>
        /// 检查Pad与盒子绑定
        /// </summary>
        CheckBind = 9011,
        /// <summary>
        /// 添加Pad与盒子绑定记录
        /// </summary>
        AddBindRecord = 9012,
        /// <summary>
        /// 收到拒绝加入会议、
        /// </summary>
        ReceiveInviteReject = 9013,

        /// <summary>
        /// 收到同意加入会议
        /// </summary>
        ReceiveInviteAgree = 9014,
        /// <summary>
        /// 收到呼叫端取消呼叫
        /// </summary>
        ReceiveInviteCancel = 9015,
        /// <summary>
        /// 截屏
        /// </summary>
        PrintScreen = 9016,
        /// <summary>
        /// 会议室系统是否绑定PAD状态通知
        /// </summary>
        AppBinded = 9017,


        /// <summary>
        /// 轮训视频
        /// </summary>
        RoundVideo = 3075,
        /// <summary>
        /// 删除摄像头坐标，焦距信息
        /// </summary>
        DelCameraPoint = 3076,
        /// <summary>
        /// 更新摄像头坐标，焦距信息
        /// </summary>
        UpdateCameraPoint = 3077,
        /// <summary>
        /// 选择摄像头坐标，焦距信息
        /// </summary>
        SelectCameraPoint = 3078,
        /// <summary>
        /// 获取摄像头坐标，焦距信息list
        /// </summary>
        GetCameraPointList = 3079,
        /// <summary>
        /// 设置摄像头坐标，焦距信息
        /// </summary>
        SetCameraPoint = 3080,
        /// <summary>
        /// 设置联席主持人
        /// </summary>
        OnCoHost = 3081,
        /// <summary>
        /// 取消联席主持人
        /// </summary>
        OffCoHost = 3082,
        /// <summary>
        /// 轮巡状态
        /// </summary>
        RoundVideoStatus = 3083,
        /// <summary>
        /// 切换摄像头
        /// </summary>
        SwitchCamera = 3084,
        /// <summary>
        /// 获取所有时区信息
        /// </summary>
        GetTimeZones = 3085,
        /// <summary>
        /// 获取当前时区
        /// </summary>
        GetCurrentTimeZone = 3086,
        /// <summary>
        /// 设置时区
        /// </summary>
        SetTimeZone = 3087,
    }
}
