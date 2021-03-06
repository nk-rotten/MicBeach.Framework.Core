﻿using MicBeach.Application.Identity.Auth;
using System;
using Microsoft.AspNetCore.Mvc;

namespace MicBeach.ViewModel.Sys
{
    /// <summary>
    /// 权限
    /// </summary>
    public class AuthorityViewModel
    {
        #region	属性

        /// <summary>
        /// 权限编码
        /// </summary>
        [Remote("CheckAuthorityCode", "Sys", ErrorMessage = "权限码已存在",HttpMethod ="Post")]
        public string Code
        {
            get;
            set;
        }

        /// <summary>
        /// 名称
        /// </summary>
        [Remote("CheckAuthorityName","Sys",AdditionalFields ="Code",ErrorMessage ="权限名已存在",HttpMethod ="Post")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// 权限类型
        /// </summary>
        public AuthorityType AuthType
        {
            get;
            set;
        }

        /// <summary>
        /// 状态
        /// </summary>
        public AuthorityStatus Status
        {
            get;
            set;
        }

        /// <summary>
        /// 排序
        /// </summary>
        public int Sort
        {
            get;
            set;
        }

        /// <summary>
        /// 权限分组
        /// </summary>
        public AuthorityGroupViewModel AuthGroup
        {
            get;
            set;
        }

        /// <summary>
        /// 说明
        /// </summary>
        public string Remark
        {
            get;
            set;
        }

        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime CreateDate
        {
            get;
            set;
        }

        #endregion
    }
}