#region << 版 本 注 释 >>
/*----------------------------------------------------------------
* 项目名称 ：Domain
* 项目描述 ：
* 类 名 称 ：Menu
* 类 描 述 ：
* 所在的域 ：KINGDESKTOP
* 命名空间 ：Domain
* 机器名称 ：KINGDESKTOP 
* CLR 版本 ：4.0.30319.42000
* 作    者 ：Kingkang
* 创建时间 ：2019/4/9 20:45:27
* 更新时间 ：2019/4/9 20:45:27
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
    public class Menu:BaseModel,IEntity
    {
        [Key]
        [Display(Description ="菜单主键")]
        public Guid Id { get; set; }
        [Display(Description ="菜单级别")]
        [Required]
        public int Order { get; set; }
        [Display(Description ="菜单路径")]
        [Required(AllowEmptyStrings =false,ErrorMessage ="Please add the path of the menu")]
        public string Url { get; set; }
        [Display(Description ="菜单名称")]
        public string Name { get; set; }
    }
}
