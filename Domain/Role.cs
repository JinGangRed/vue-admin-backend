#region << 版 本 注 释 >>
/*----------------------------------------------------------------
* 项目名称 ：Domain
* 项目描述 ：
* 类 名 称 ：Role
* 类 描 述 ：
* 所在的域 ：KINGDESKTOP
* 命名空间 ：Domain
* 机器名称 ：KINGDESKTOP 
* CLR 版本 ：4.0.30319.42000
* 作    者 ：Kingkang
* 创建时间 ：2019/4/9 20:37:19
* 更新时间 ：2019/4/9 20:37:19
* 版 本 号 ：v1.0.0.0
*******************************************************************
* Copyright @ Kingkang 2019. All rights reserved.
*******************************************************************
//----------------------------------------------------------------*/
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


namespace Domain
{
    public class Role: BaseModel, IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Description ="角色主键")]
        public int Id { get; set; }
        [StringLength(100)]
        [Required]
        [Display(Description ="角色名称")]
        public string RoleName { get; set; }
        [StringLength(100)]
        [Display(Description = "角色中文名称")]
        public string RoleCNName { get; set; }
    }
}
