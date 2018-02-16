﻿using System.Runtime.Serialization;

namespace LiqPaySDK.Dto.Enums
{
    public enum LiqPayResponseAction
    {
        [EnumMember(Value = "pay")]
        Pay,
        [EnumMember(Value = "hold")]
        Hold,
        [EnumMember(Value = "paysplit")]
        Paysplit,
        [EnumMember(Value = "subscribe")]
        Subscribe,
        [EnumMember(Value = "paydonate")]
        Paydonate,
        [EnumMember(Value = "auth")]
        Auth,
        [EnumMember(Value = "regular")]
        Regular
    }
}