﻿using ZhonTai.Admin.Core.Entities;
using FreeSql.DataAnnotations;
using ZhonTai.Admin.Domain.User;
using ZhonTai.Admin.Domain.Role;

namespace ZhonTai.Admin.Domain.UserRole;

/// <summary>
/// 用户角色
/// </summary>
[Table(Name = "ad_user_role")]
[Index("idx_{tablename}_01", nameof(UserId) + "," + nameof(RoleId), true)]
public class UserRoleEntity : EntityAdd
{
    /// <summary>
    /// 用户Id
    /// </summary>
    public long UserId { get; set; }

    public UserEntity User { get; set; }

    /// <summary>
    /// 角色Id
    /// </summary>
    public long RoleId { get; set; }

    public RoleEntity Role { get; set; }
}