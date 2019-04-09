#region << 版 本 注 释 >>
/*----------------------------------------------------------------
* 项目名称 ：Domain
* 项目描述 ：
* 类 名 称 ：BaseModel
* 类 描 述 ：
* 所在的域 ：KINGDESKTOP
* 命名空间 ：Domain
* 机器名称 ：KINGDESKTOP 
* CLR 版本 ：4.0.30319.42000
* 作    者 ：Kingkang
* 创建时间 ：2019/4/9 20:29:51
* 更新时间 ：2019/4/9 20:29:51
* 版 本 号 ：v1.0.0.0
*******************************************************************
* Copyright @ Kingkang 2019. All rights reserved.
*******************************************************************
//----------------------------------------------------------------*/
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain
{
    public class BaseModel
    {
        [Display(Description ="数据状态",Order = 1)]
        public DataStatus Status { get; set; }
        [Display(Description ="创建时间",Order = 1)]
        public DateTime? CreateTime { get; set; }
        [Display(Description ="更新时间",Order = 1)]
        public DateTime? UpdateTime { get; set; }
        [Display(Description ="创建人",Order =1)]
        [StringLength(100)]
        public string CreateBy { get; set; }
        [Display(Description ="更新人",Order =1)]
        [StringLength(100)]
        public string UpdateBy { get; set; }
    }
}
