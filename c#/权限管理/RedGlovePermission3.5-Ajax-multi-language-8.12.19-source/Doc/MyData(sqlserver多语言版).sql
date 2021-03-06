USE [MyData]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 12/20/2008 16:52:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](128) NOT NULL,
	[Password] [nvarchar](128) NOT NULL,
	[Question] [nvarchar](100) NULL,
	[Answer] [nvarchar](100) NULL,
	[RoleID] [int] NOT NULL,
	[UserGroup] [int] NOT NULL,
	[CreateTime] [datetime] NOT NULL,
	[LastLoginTime] [datetime] NULL,
	[Status] [int] NOT NULL,
	[IsOnline] [bit] NOT NULL,
	[IsLimit] [bit] NOT NULL,
 CONSTRAINT [PK_User_ID] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'用户ID' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'UserID'
GO
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'登录名，用户Email' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'UserName'
GO
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'密码' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'Password'
GO
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'重置密码的问题' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'Question'
GO
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'重置密码的答案' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'Answer'
GO
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'角色' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'RoleID'
GO
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'用户组' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'UserGroup'
GO
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'帐户创建时间' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'CreateTime'
GO
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'上一次登录的时间' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'LastLoginTime'
GO
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'用户状态' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'Status'
GO
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'是否在线' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'IsOnline'
GO
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'是否受权限限制，0为受限制' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'IsLimit'
GO
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'用户帐户信息表' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users'
GO
SET IDENTITY_INSERT [dbo].[Users] ON
INSERT [dbo].[Users] ([UserID], [UserName], [Password], [Question], [Answer], [RoleID], [UserGroup], [CreateTime], [LastLoginTime], [Status], [IsOnline], [IsLimit]) VALUES (1, N'admin', N'21232F297A57A5A743894A0E4A801FC3', N'Who', N'系统管理员', 1, 1, CAST(0x00009B74012E092D AS DateTime), NULL, 1, 0, 1)
INSERT [dbo].[Users] ([UserID], [UserName], [Password], [Question], [Answer], [RoleID], [UserGroup], [CreateTime], [LastLoginTime], [Status], [IsOnline], [IsLimit]) VALUES (2, N'test1', N'098F6BCD4621D373CADE4E832627B4F6', N'', N'', 5, 3, CAST(0x00009B74012F3F78 AS DateTime), NULL, 1, 0, 0)
INSERT [dbo].[Users] ([UserID], [UserName], [Password], [Question], [Answer], [RoleID], [UserGroup], [CreateTime], [LastLoginTime], [Status], [IsOnline], [IsLimit]) VALUES (3, N'test2', N'098F6BCD4621D373CADE4E832627B4F6', N'123123', N'123123', 6, 6, CAST(0x00009B7500DA1B2C AS DateTime), NULL, 1, 0, 0)
INSERT [dbo].[Users] ([UserID], [UserName], [Password], [Question], [Answer], [RoleID], [UserGroup], [CreateTime], [LastLoginTime], [Status], [IsOnline], [IsLimit]) VALUES (4, N'test3', N'098F6BCD4621D373CADE4E832627B4F6', N'123123', N'123213', 7, 6, CAST(0x00009B7500DA4284 AS DateTime), NULL, 1, 0, 0)
SET IDENTITY_INSERT [dbo].[Users] OFF
/****** Object:  Table [dbo].[RGP_Roles]    Script Date: 12/20/2008 16:52:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RGP_Roles](
	[RoleID] [int] IDENTITY(1,1) NOT NULL,
	[RoleGroupID] [int] NOT NULL,
	[RoleName] [nvarchar](30) NOT NULL,
	[RoleDescription] [nvarchar](50) NULL,
 CONSTRAINT [PK_RGP_Roles] PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC
) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'角色ID' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RGP_Roles', @level2type=N'COLUMN',@level2name=N'RoleID'
GO
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'分组ID' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RGP_Roles', @level2type=N'COLUMN',@level2name=N'RoleGroupID'
GO
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'角色名称' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RGP_Roles', @level2type=N'COLUMN',@level2name=N'RoleName'
GO
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'说明' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RGP_Roles', @level2type=N'COLUMN',@level2name=N'RoleDescription'
GO
SET IDENTITY_INSERT [dbo].[RGP_Roles] ON
INSERT [dbo].[RGP_Roles] ([RoleID], [RoleGroupID], [RoleName], [RoleDescription]) VALUES (4, 1, N'role1', N'具有系统所有权限')
INSERT [dbo].[RGP_Roles] ([RoleID], [RoleGroupID], [RoleName], [RoleDescription]) VALUES (5, 2, N'role2', N'用户信息管理')
INSERT [dbo].[RGP_Roles] ([RoleID], [RoleGroupID], [RoleName], [RoleDescription]) VALUES (6, 3, N'role3', N'外部注册会员')
INSERT [dbo].[RGP_Roles] ([RoleID], [RoleGroupID], [RoleName], [RoleDescription]) VALUES (7, 3, N'role4', N'内部用户信息')
INSERT [dbo].[RGP_Roles] ([RoleID], [RoleGroupID], [RoleName], [RoleDescription]) VALUES (9, 1, N'role8', N'系统管理员,管理配置')
SET IDENTITY_INSERT [dbo].[RGP_Roles] OFF
/****** Object:  Table [dbo].[RGP_RoleAuthorityList]    Script Date: 12/20/2008 16:52:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RGP_RoleAuthorityList](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[RoleID] [int] NOT NULL,
	[ModuleID] [int] NOT NULL,
	[AuthorityTag] [nvarchar](50) NOT NULL,
	[Flag] [bit] NOT NULL,
 CONSTRAINT [PK_UserAuthorityList] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'编号' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RGP_RoleAuthorityList', @level2type=N'COLUMN',@level2name=N'ID'
GO
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'用户ID' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RGP_RoleAuthorityList', @level2type=N'COLUMN',@level2name=N'UserID'
GO
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'角色ID' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RGP_RoleAuthorityList', @level2type=N'COLUMN',@level2name=N'RoleID'
GO
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'模块ID' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RGP_RoleAuthorityList', @level2type=N'COLUMN',@level2name=N'ModuleID'
GO
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'权限标识' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RGP_RoleAuthorityList', @level2type=N'COLUMN',@level2name=N'AuthorityTag'
GO
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'1为允许，0为不禁止' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RGP_RoleAuthorityList', @level2type=N'COLUMN',@level2name=N'Flag'
GO
SET IDENTITY_INSERT [dbo].[RGP_RoleAuthorityList] ON
INSERT [dbo].[RGP_RoleAuthorityList] ([ID], [UserID], [RoleID], [ModuleID], [AuthorityTag], [Flag]) VALUES (18, 0, 4, 18, N'RGP_BROWSE', 1)
INSERT [dbo].[RGP_RoleAuthorityList] ([ID], [UserID], [RoleID], [ModuleID], [AuthorityTag], [Flag]) VALUES (23, 0, 4, 18, N'RGP_SHARCH', 1)
INSERT [dbo].[RGP_RoleAuthorityList] ([ID], [UserID], [RoleID], [ModuleID], [AuthorityTag], [Flag]) VALUES (25, 0, 4, 19, N'RGP_BROWSE', 1)
INSERT [dbo].[RGP_RoleAuthorityList] ([ID], [UserID], [RoleID], [ModuleID], [AuthorityTag], [Flag]) VALUES (26, 0, 4, 19, N'RGP_ADD', 1)
INSERT [dbo].[RGP_RoleAuthorityList] ([ID], [UserID], [RoleID], [ModuleID], [AuthorityTag], [Flag]) VALUES (27, 0, 4, 20, N'RGP_BROWSE', 1)
INSERT [dbo].[RGP_RoleAuthorityList] ([ID], [UserID], [RoleID], [ModuleID], [AuthorityTag], [Flag]) VALUES (29, 0, 4, 21, N'RGP_BROWSE', 1)
INSERT [dbo].[RGP_RoleAuthorityList] ([ID], [UserID], [RoleID], [ModuleID], [AuthorityTag], [Flag]) VALUES (31, 0, 4, 18, N'RGP_ADD', 1)
INSERT [dbo].[RGP_RoleAuthorityList] ([ID], [UserID], [RoleID], [ModuleID], [AuthorityTag], [Flag]) VALUES (33, 0, 4, 18, N'RGP_DELETE', 1)
INSERT [dbo].[RGP_RoleAuthorityList] ([ID], [UserID], [RoleID], [ModuleID], [AuthorityTag], [Flag]) VALUES (34, 0, 4, 18, N'RGP_MOVE', 1)
INSERT [dbo].[RGP_RoleAuthorityList] ([ID], [UserID], [RoleID], [ModuleID], [AuthorityTag], [Flag]) VALUES (36, 0, 4, 19, N'RGP_DELETE', 1)
INSERT [dbo].[RGP_RoleAuthorityList] ([ID], [UserID], [RoleID], [ModuleID], [AuthorityTag], [Flag]) VALUES (37, 0, 4, 19, N'RGP_MOVE', 1)
INSERT [dbo].[RGP_RoleAuthorityList] ([ID], [UserID], [RoleID], [ModuleID], [AuthorityTag], [Flag]) VALUES (38, 0, 4, 20, N'RGP_EDIT', 1)
INSERT [dbo].[RGP_RoleAuthorityList] ([ID], [UserID], [RoleID], [ModuleID], [AuthorityTag], [Flag]) VALUES (39, 0, 4, 20, N'RGP_DELETE', 1)
INSERT [dbo].[RGP_RoleAuthorityList] ([ID], [UserID], [RoleID], [ModuleID], [AuthorityTag], [Flag]) VALUES (40, 0, 4, 21, N'RGP_EDIT', 1)
INSERT [dbo].[RGP_RoleAuthorityList] ([ID], [UserID], [RoleID], [ModuleID], [AuthorityTag], [Flag]) VALUES (41, 0, 4, 21, N'RGP_DELETE', 1)
INSERT [dbo].[RGP_RoleAuthorityList] ([ID], [UserID], [RoleID], [ModuleID], [AuthorityTag], [Flag]) VALUES (42, 0, 4, 21, N'RGP_MOVE', 1)
INSERT [dbo].[RGP_RoleAuthorityList] ([ID], [UserID], [RoleID], [ModuleID], [AuthorityTag], [Flag]) VALUES (43, 0, 4, 22, N'RGP_BROWSE', 1)
INSERT [dbo].[RGP_RoleAuthorityList] ([ID], [UserID], [RoleID], [ModuleID], [AuthorityTag], [Flag]) VALUES (44, 0, 4, 22, N'RGP_EDIT', 1)
INSERT [dbo].[RGP_RoleAuthorityList] ([ID], [UserID], [RoleID], [ModuleID], [AuthorityTag], [Flag]) VALUES (45, 0, 4, 23, N'RGP_BROWSE', 1)
INSERT [dbo].[RGP_RoleAuthorityList] ([ID], [UserID], [RoleID], [ModuleID], [AuthorityTag], [Flag]) VALUES (48, 0, 4, 23, N'RGP_DELETE', 1)
INSERT [dbo].[RGP_RoleAuthorityList] ([ID], [UserID], [RoleID], [ModuleID], [AuthorityTag], [Flag]) VALUES (49, 0, 4, 18, N'RGP_EDIT', 1)
INSERT [dbo].[RGP_RoleAuthorityList] ([ID], [UserID], [RoleID], [ModuleID], [AuthorityTag], [Flag]) VALUES (50, 0, 4, 19, N'RGP_EDIT', 1)
INSERT [dbo].[RGP_RoleAuthorityList] ([ID], [UserID], [RoleID], [ModuleID], [AuthorityTag], [Flag]) VALUES (51, 0, 4, 14, N'RGP_BROWSE', 1)
INSERT [dbo].[RGP_RoleAuthorityList] ([ID], [UserID], [RoleID], [ModuleID], [AuthorityTag], [Flag]) VALUES (52, 0, 4, 14, N'RGP_ADD', 1)
INSERT [dbo].[RGP_RoleAuthorityList] ([ID], [UserID], [RoleID], [ModuleID], [AuthorityTag], [Flag]) VALUES (53, 0, 4, 23, N'RGP_ADD', 1)
INSERT [dbo].[RGP_RoleAuthorityList] ([ID], [UserID], [RoleID], [ModuleID], [AuthorityTag], [Flag]) VALUES (54, 0, 4, 23, N'RGP_EDIT', 1)
INSERT [dbo].[RGP_RoleAuthorityList] ([ID], [UserID], [RoleID], [ModuleID], [AuthorityTag], [Flag]) VALUES (55, 0, 4, 14, N'RGP_EDIT', 1)
INSERT [dbo].[RGP_RoleAuthorityList] ([ID], [UserID], [RoleID], [ModuleID], [AuthorityTag], [Flag]) VALUES (56, 0, 4, 14, N'RGP_DELETE', 1)
INSERT [dbo].[RGP_RoleAuthorityList] ([ID], [UserID], [RoleID], [ModuleID], [AuthorityTag], [Flag]) VALUES (57, 0, 4, 14, N'RGP_VERIFY', 1)
INSERT [dbo].[RGP_RoleAuthorityList] ([ID], [UserID], [RoleID], [ModuleID], [AuthorityTag], [Flag]) VALUES (58, 0, 4, 14, N'RGP_MOVE', 1)
INSERT [dbo].[RGP_RoleAuthorityList] ([ID], [UserID], [RoleID], [ModuleID], [AuthorityTag], [Flag]) VALUES (59, 0, 4, 16, N'RGP_BROWSE', 1)
INSERT [dbo].[RGP_RoleAuthorityList] ([ID], [UserID], [RoleID], [ModuleID], [AuthorityTag], [Flag]) VALUES (60, 0, 4, 16, N'RGP_ADD', 1)
INSERT [dbo].[RGP_RoleAuthorityList] ([ID], [UserID], [RoleID], [ModuleID], [AuthorityTag], [Flag]) VALUES (61, 0, 4, 16, N'RGP_EDIT', 1)
INSERT [dbo].[RGP_RoleAuthorityList] ([ID], [UserID], [RoleID], [ModuleID], [AuthorityTag], [Flag]) VALUES (62, 0, 4, 16, N'RGP_DELETE', 1)
INSERT [dbo].[RGP_RoleAuthorityList] ([ID], [UserID], [RoleID], [ModuleID], [AuthorityTag], [Flag]) VALUES (63, 0, 4, 16, N'RGP_VERIFY', 1)
INSERT [dbo].[RGP_RoleAuthorityList] ([ID], [UserID], [RoleID], [ModuleID], [AuthorityTag], [Flag]) VALUES (64, 0, 4, 16, N'RGP_MOVE', 1)
INSERT [dbo].[RGP_RoleAuthorityList] ([ID], [UserID], [RoleID], [ModuleID], [AuthorityTag], [Flag]) VALUES (65, 0, 4, 17, N'RGP_BROWSE', 1)
INSERT [dbo].[RGP_RoleAuthorityList] ([ID], [UserID], [RoleID], [ModuleID], [AuthorityTag], [Flag]) VALUES (66, 0, 4, 17, N'RGP_ADD', 1)
INSERT [dbo].[RGP_RoleAuthorityList] ([ID], [UserID], [RoleID], [ModuleID], [AuthorityTag], [Flag]) VALUES (67, 0, 4, 17, N'RGP_EDIT', 1)
INSERT [dbo].[RGP_RoleAuthorityList] ([ID], [UserID], [RoleID], [ModuleID], [AuthorityTag], [Flag]) VALUES (69, 0, 5, 25, N'RGP_ADD', 1)
INSERT [dbo].[RGP_RoleAuthorityList] ([ID], [UserID], [RoleID], [ModuleID], [AuthorityTag], [Flag]) VALUES (70, 0, 5, 25, N'RGP_EDIT', 1)
INSERT [dbo].[RGP_RoleAuthorityList] ([ID], [UserID], [RoleID], [ModuleID], [AuthorityTag], [Flag]) VALUES (71, 0, 5, 25, N'RGP_DELETE', 1)
INSERT [dbo].[RGP_RoleAuthorityList] ([ID], [UserID], [RoleID], [ModuleID], [AuthorityTag], [Flag]) VALUES (72, 0, 5, 25, N'RGP_SEARCH', 1)
INSERT [dbo].[RGP_RoleAuthorityList] ([ID], [UserID], [RoleID], [ModuleID], [AuthorityTag], [Flag]) VALUES (73, 0, 5, 25, N'RGP_VERIFY', 1)
INSERT [dbo].[RGP_RoleAuthorityList] ([ID], [UserID], [RoleID], [ModuleID], [AuthorityTag], [Flag]) VALUES (74, 0, 5, 25, N'RGP_MOVE', 1)
INSERT [dbo].[RGP_RoleAuthorityList] ([ID], [UserID], [RoleID], [ModuleID], [AuthorityTag], [Flag]) VALUES (77, 0, 4, 25, N'RGP_ADD', 1)
INSERT [dbo].[RGP_RoleAuthorityList] ([ID], [UserID], [RoleID], [ModuleID], [AuthorityTag], [Flag]) VALUES (78, 0, 4, 25, N'RGP_EDIT', 1)
INSERT [dbo].[RGP_RoleAuthorityList] ([ID], [UserID], [RoleID], [ModuleID], [AuthorityTag], [Flag]) VALUES (79, 0, 4, 25, N'RGP_DELETE', 1)
INSERT [dbo].[RGP_RoleAuthorityList] ([ID], [UserID], [RoleID], [ModuleID], [AuthorityTag], [Flag]) VALUES (80, 0, 4, 25, N'RGP_SEARCH', 1)
INSERT [dbo].[RGP_RoleAuthorityList] ([ID], [UserID], [RoleID], [ModuleID], [AuthorityTag], [Flag]) VALUES (81, 0, 4, 25, N'RGP_VERIFY', 1)
INSERT [dbo].[RGP_RoleAuthorityList] ([ID], [UserID], [RoleID], [ModuleID], [AuthorityTag], [Flag]) VALUES (82, 0, 4, 25, N'RGP_MOVE', 1)
INSERT [dbo].[RGP_RoleAuthorityList] ([ID], [UserID], [RoleID], [ModuleID], [AuthorityTag], [Flag]) VALUES (83, 0, 4, 24, N'RGP_BROWSE', 1)
INSERT [dbo].[RGP_RoleAuthorityList] ([ID], [UserID], [RoleID], [ModuleID], [AuthorityTag], [Flag]) VALUES (84, 0, 4, 24, N'RGP_EDIT', 1)
INSERT [dbo].[RGP_RoleAuthorityList] ([ID], [UserID], [RoleID], [ModuleID], [AuthorityTag], [Flag]) VALUES (85, 0, 5, 24, N'RGP_BROWSE', 1)
INSERT [dbo].[RGP_RoleAuthorityList] ([ID], [UserID], [RoleID], [ModuleID], [AuthorityTag], [Flag]) VALUES (86, 0, 5, 24, N'RGP_EDIT', 1)
INSERT [dbo].[RGP_RoleAuthorityList] ([ID], [UserID], [RoleID], [ModuleID], [AuthorityTag], [Flag]) VALUES (87, 0, 5, 14, N'RGP_BROWSE', 1)
INSERT [dbo].[RGP_RoleAuthorityList] ([ID], [UserID], [RoleID], [ModuleID], [AuthorityTag], [Flag]) VALUES (88, 0, 5, 14, N'RGP_ADD', 1)
INSERT [dbo].[RGP_RoleAuthorityList] ([ID], [UserID], [RoleID], [ModuleID], [AuthorityTag], [Flag]) VALUES (89, 0, 5, 14, N'RGP_EDIT', 1)
INSERT [dbo].[RGP_RoleAuthorityList] ([ID], [UserID], [RoleID], [ModuleID], [AuthorityTag], [Flag]) VALUES (90, 0, 5, 14, N'RGP_DELETE', 1)
INSERT [dbo].[RGP_RoleAuthorityList] ([ID], [UserID], [RoleID], [ModuleID], [AuthorityTag], [Flag]) VALUES (91, 0, 5, 14, N'RGP_VERIFY', 1)
INSERT [dbo].[RGP_RoleAuthorityList] ([ID], [UserID], [RoleID], [ModuleID], [AuthorityTag], [Flag]) VALUES (92, 0, 5, 14, N'RGP_MOVE', 1)
INSERT [dbo].[RGP_RoleAuthorityList] ([ID], [UserID], [RoleID], [ModuleID], [AuthorityTag], [Flag]) VALUES (93, 0, 6, 14, N'RGP_BROWSE', 1)
INSERT [dbo].[RGP_RoleAuthorityList] ([ID], [UserID], [RoleID], [ModuleID], [AuthorityTag], [Flag]) VALUES (94, 0, 6, 25, N'RGP_ADD', 1)
INSERT [dbo].[RGP_RoleAuthorityList] ([ID], [UserID], [RoleID], [ModuleID], [AuthorityTag], [Flag]) VALUES (95, 0, 6, 25, N'RGP_EDIT', 1)
SET IDENTITY_INSERT [dbo].[RGP_RoleAuthorityList] OFF
/****** Object:  Table [dbo].[RGP_ModuleType]    Script Date: 12/20/2008 16:52:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RGP_ModuleType](
	[ModuleTypeID] [int] IDENTITY(1,1) NOT NULL,
	[ModuleTypeName] [nvarchar](30) NOT NULL,
	[ModuleTypeOrder] [int] NOT NULL,
	[ModuleTypeDescription] [nvarchar](50) NULL,
 CONSTRAINT [PK_ModuleGroup] PRIMARY KEY CLUSTERED 
(
	[ModuleTypeID] ASC
) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'模块类型ID' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RGP_ModuleType', @level2type=N'COLUMN',@level2name=N'ModuleTypeID'
GO
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'模块类型名称' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RGP_ModuleType', @level2type=N'COLUMN',@level2name=N'ModuleTypeName'
GO
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'排序' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RGP_ModuleType', @level2type=N'COLUMN',@level2name=N'ModuleTypeOrder'
GO
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'说明' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RGP_ModuleType', @level2type=N'COLUMN',@level2name=N'ModuleTypeDescription'
GO
SET IDENTITY_INSERT [dbo].[RGP_ModuleType] ON
INSERT [dbo].[RGP_ModuleType] ([ModuleTypeID], [ModuleTypeName], [ModuleTypeOrder], [ModuleTypeDescription]) VALUES (1, N'menu01', 4, N'系统权限管理')
INSERT [dbo].[RGP_ModuleType] ([ModuleTypeID], [ModuleTypeName], [ModuleTypeOrder], [ModuleTypeDescription]) VALUES (2, N'menu03', 2, N'会员,公司员工管理')
INSERT [dbo].[RGP_ModuleType] ([ModuleTypeID], [ModuleTypeName], [ModuleTypeOrder], [ModuleTypeDescription]) VALUES (3, N'menu02', 3, N'系统配置相关功能')
INSERT [dbo].[RGP_ModuleType] ([ModuleTypeID], [ModuleTypeName], [ModuleTypeOrder], [ModuleTypeDescription]) VALUES (4, N'menu04', 1, N'样例演示')
SET IDENTITY_INSERT [dbo].[RGP_ModuleType] OFF
/****** Object:  Table [dbo].[RGP_Modules]    Script Date: 12/20/2008 16:52:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RGP_Modules](
	[ModuleID] [int] IDENTITY(1,1) NOT NULL,
	[ModuleTypeID] [int] NOT NULL,
	[ModuleName] [nvarchar](30) NOT NULL,
	[ModuleTag] [nvarchar](50) NOT NULL,
	[ModuleURL] [nvarchar](500) NULL,
	[ModuleDisabled] [bit] NOT NULL,
	[ModuleOrder] [int] NOT NULL,
	[ModuleDescription] [nvarchar](50) NULL,
	[IsMenu] [bit] NOT NULL,
 CONSTRAINT [PK_RGP_Modules] PRIMARY KEY CLUSTERED 
(
	[ModuleID] ASC
) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'模块ID' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RGP_Modules', @level2type=N'COLUMN',@level2name=N'ModuleID'
GO
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'模块类型' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RGP_Modules', @level2type=N'COLUMN',@level2name=N'ModuleTypeID'
GO
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'模块名称' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RGP_Modules', @level2type=N'COLUMN',@level2name=N'ModuleName'
GO
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'模块标识' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RGP_Modules', @level2type=N'COLUMN',@level2name=N'ModuleTag'
GO
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'模块地址' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RGP_Modules', @level2type=N'COLUMN',@level2name=N'ModuleURL'
GO
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'是否禁用' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RGP_Modules', @level2type=N'COLUMN',@level2name=N'ModuleDisabled'
GO
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'排序' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RGP_Modules', @level2type=N'COLUMN',@level2name=N'ModuleOrder'
GO
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'说明' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RGP_Modules', @level2type=N'COLUMN',@level2name=N'ModuleDescription'
GO
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'是否显示在导航菜单中' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RGP_Modules', @level2type=N'COLUMN',@level2name=N'IsMenu'
GO
SET IDENTITY_INSERT [dbo].[RGP_Modules] ON
INSERT [dbo].[RGP_Modules] ([ModuleID], [ModuleTypeID], [ModuleName], [ModuleTag], [ModuleURL], [ModuleDisabled], [ModuleOrder], [ModuleDescription], [IsMenu]) VALUES (14, 2, N'menu0301', N'Mod_Member', N'../Modubles/Users/ListUsers.aspx', 1, 1, N'外部注册会员管理', 1)
INSERT [dbo].[RGP_Modules] ([ModuleID], [ModuleTypeID], [ModuleName], [ModuleTag], [ModuleURL], [ModuleDisabled], [ModuleOrder], [ModuleDescription], [IsMenu]) VALUES (18, 1, N'menu0102', N'Mod_Groups', N'../Modubles/sysconfig/GroupsPage.aspx', 1, 2, N'用户分组，角色分组', 1)
INSERT [dbo].[RGP_Modules] ([ModuleID], [ModuleTypeID], [ModuleName], [ModuleTag], [ModuleURL], [ModuleDisabled], [ModuleOrder], [ModuleDescription], [IsMenu]) VALUES (19, 1, N'menu0105', N'Mod_Roles', N'../Modubles/sysconfig/RolesPage.aspx', 1, 5, N'管理角色', 1)
INSERT [dbo].[RGP_Modules] ([ModuleID], [ModuleTypeID], [ModuleName], [ModuleTag], [ModuleURL], [ModuleDisabled], [ModuleOrder], [ModuleDescription], [IsMenu]) VALUES (20, 1, N'menu0103', N'Mod_ModuleType', N'../Modubles/sysconfig/ModuleTypePage.aspx', 1, 3, N'功能模块分类', 1)
INSERT [dbo].[RGP_Modules] ([ModuleID], [ModuleTypeID], [ModuleName], [ModuleTag], [ModuleURL], [ModuleDisabled], [ModuleOrder], [ModuleDescription], [IsMenu]) VALUES (21, 1, N'menu0104', N'Mod_Modules', N'../Modubles/sysconfig/ModulesPage.aspx', 1, 4, N'模块管理', 1)
INSERT [dbo].[RGP_Modules] ([ModuleID], [ModuleTypeID], [ModuleName], [ModuleTag], [ModuleURL], [ModuleDisabled], [ModuleOrder], [ModuleDescription], [IsMenu]) VALUES (22, 1, N'menu0106', N'Mod_RoleAuthority', N'../Modubles/sysconfig/RoleAuthorizedPage.aspx', 1, 6, N'', 1)
INSERT [dbo].[RGP_Modules] ([ModuleID], [ModuleTypeID], [ModuleName], [ModuleTag], [ModuleURL], [ModuleDisabled], [ModuleOrder], [ModuleDescription], [IsMenu]) VALUES (23, 1, N'menu0101', N'Mod_Authorized', N'../Modubles/sysconfig/AuthorityPage.aspx', 1, 1, N'', 1)
INSERT [dbo].[RGP_Modules] ([ModuleID], [ModuleTypeID], [ModuleName], [ModuleTag], [ModuleURL], [ModuleDisabled], [ModuleOrder], [ModuleDescription], [IsMenu]) VALUES (24, 3, N'menu0201', N'Mod_Config', N'../Modubles/sysconfig/ConfigPage.aspx', 1, 1, N'系统管理设置', 1)
INSERT [dbo].[RGP_Modules] ([ModuleID], [ModuleTypeID], [ModuleName], [ModuleTag], [ModuleURL], [ModuleDisabled], [ModuleOrder], [ModuleDescription], [IsMenu]) VALUES (25, 4, N'menu0401', N'Mod_Control', N'../Modubles/Demo/GeneralControl.aspx', 1, 1, N'一般组件的控制', 1)
SET IDENTITY_INSERT [dbo].[RGP_Modules] OFF
/****** Object:  Table [dbo].[RGP_ModuleAuthorityList]    Script Date: 12/20/2008 16:52:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RGP_ModuleAuthorityList](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ModuleID] [int] NOT NULL,
	[AuthorityTag] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_ModuleAuthorityList] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'模块ID' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RGP_ModuleAuthorityList', @level2type=N'COLUMN',@level2name=N'ModuleID'
GO
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'权限标识' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RGP_ModuleAuthorityList', @level2type=N'COLUMN',@level2name=N'AuthorityTag'
GO
SET IDENTITY_INSERT [dbo].[RGP_ModuleAuthorityList] ON
INSERT [dbo].[RGP_ModuleAuthorityList] ([ID], [ModuleID], [AuthorityTag]) VALUES (35, 14, N'RGP_SHARCH')
INSERT [dbo].[RGP_ModuleAuthorityList] ([ID], [ModuleID], [AuthorityTag]) VALUES (36, 14, N'RGP_VERIFY')
INSERT [dbo].[RGP_ModuleAuthorityList] ([ID], [ModuleID], [AuthorityTag]) VALUES (37, 14, N'RGP_MOVE')
INSERT [dbo].[RGP_ModuleAuthorityList] ([ID], [ModuleID], [AuthorityTag]) VALUES (45, 14, N'RGP_BROWSE')
INSERT [dbo].[RGP_ModuleAuthorityList] ([ID], [ModuleID], [AuthorityTag]) VALUES (46, 18, N'RGP_BROWSE')
INSERT [dbo].[RGP_ModuleAuthorityList] ([ID], [ModuleID], [AuthorityTag]) VALUES (47, 18, N'RGP_ADD')
INSERT [dbo].[RGP_ModuleAuthorityList] ([ID], [ModuleID], [AuthorityTag]) VALUES (48, 18, N'RGP_EDIT')
INSERT [dbo].[RGP_ModuleAuthorityList] ([ID], [ModuleID], [AuthorityTag]) VALUES (49, 18, N'RGP_DELETE')
INSERT [dbo].[RGP_ModuleAuthorityList] ([ID], [ModuleID], [AuthorityTag]) VALUES (50, 18, N'RGP_SHARCH')
INSERT [dbo].[RGP_ModuleAuthorityList] ([ID], [ModuleID], [AuthorityTag]) VALUES (51, 14, N'RGP_ADD')
INSERT [dbo].[RGP_ModuleAuthorityList] ([ID], [ModuleID], [AuthorityTag]) VALUES (52, 14, N'RGP_EDIT')
INSERT [dbo].[RGP_ModuleAuthorityList] ([ID], [ModuleID], [AuthorityTag]) VALUES (53, 14, N'RGP_DELETE')
INSERT [dbo].[RGP_ModuleAuthorityList] ([ID], [ModuleID], [AuthorityTag]) VALUES (54, 18, N'RGP_MOVE')
INSERT [dbo].[RGP_ModuleAuthorityList] ([ID], [ModuleID], [AuthorityTag]) VALUES (55, 19, N'RGP_BROWSE')
INSERT [dbo].[RGP_ModuleAuthorityList] ([ID], [ModuleID], [AuthorityTag]) VALUES (56, 19, N'RGP_ADD')
INSERT [dbo].[RGP_ModuleAuthorityList] ([ID], [ModuleID], [AuthorityTag]) VALUES (57, 19, N'RGP_EDIT')
INSERT [dbo].[RGP_ModuleAuthorityList] ([ID], [ModuleID], [AuthorityTag]) VALUES (58, 19, N'RGP_DELETE')
INSERT [dbo].[RGP_ModuleAuthorityList] ([ID], [ModuleID], [AuthorityTag]) VALUES (59, 19, N'RGP_MOVE')
INSERT [dbo].[RGP_ModuleAuthorityList] ([ID], [ModuleID], [AuthorityTag]) VALUES (60, 20, N'RGP_BROWSE')
INSERT [dbo].[RGP_ModuleAuthorityList] ([ID], [ModuleID], [AuthorityTag]) VALUES (61, 20, N'RGP_ADD')
INSERT [dbo].[RGP_ModuleAuthorityList] ([ID], [ModuleID], [AuthorityTag]) VALUES (62, 20, N'RGP_EDIT')
INSERT [dbo].[RGP_ModuleAuthorityList] ([ID], [ModuleID], [AuthorityTag]) VALUES (63, 20, N'RGP_DELETE')
INSERT [dbo].[RGP_ModuleAuthorityList] ([ID], [ModuleID], [AuthorityTag]) VALUES (64, 21, N'RGP_BROWSE')
INSERT [dbo].[RGP_ModuleAuthorityList] ([ID], [ModuleID], [AuthorityTag]) VALUES (65, 21, N'RGP_ADD')
INSERT [dbo].[RGP_ModuleAuthorityList] ([ID], [ModuleID], [AuthorityTag]) VALUES (66, 21, N'RGP_EDIT')
INSERT [dbo].[RGP_ModuleAuthorityList] ([ID], [ModuleID], [AuthorityTag]) VALUES (67, 21, N'RGP_DELETE')
INSERT [dbo].[RGP_ModuleAuthorityList] ([ID], [ModuleID], [AuthorityTag]) VALUES (68, 21, N'RGP_MOVE')
INSERT [dbo].[RGP_ModuleAuthorityList] ([ID], [ModuleID], [AuthorityTag]) VALUES (69, 22, N'RGP_BROWSE')
INSERT [dbo].[RGP_ModuleAuthorityList] ([ID], [ModuleID], [AuthorityTag]) VALUES (70, 22, N'RGP_EDIT')
INSERT [dbo].[RGP_ModuleAuthorityList] ([ID], [ModuleID], [AuthorityTag]) VALUES (71, 23, N'RGP_BROWSE')
INSERT [dbo].[RGP_ModuleAuthorityList] ([ID], [ModuleID], [AuthorityTag]) VALUES (72, 23, N'RGP_ADD')
INSERT [dbo].[RGP_ModuleAuthorityList] ([ID], [ModuleID], [AuthorityTag]) VALUES (73, 23, N'RGP_EDIT')
INSERT [dbo].[RGP_ModuleAuthorityList] ([ID], [ModuleID], [AuthorityTag]) VALUES (74, 23, N'RGP_DELETE')
INSERT [dbo].[RGP_ModuleAuthorityList] ([ID], [ModuleID], [AuthorityTag]) VALUES (78, 24, N'RGP_BROWSE')
INSERT [dbo].[RGP_ModuleAuthorityList] ([ID], [ModuleID], [AuthorityTag]) VALUES (79, 24, N'RGP_EDIT')
INSERT [dbo].[RGP_ModuleAuthorityList] ([ID], [ModuleID], [AuthorityTag]) VALUES (81, 25, N'RGP_ADD')
INSERT [dbo].[RGP_ModuleAuthorityList] ([ID], [ModuleID], [AuthorityTag]) VALUES (82, 25, N'RGP_EDIT')
INSERT [dbo].[RGP_ModuleAuthorityList] ([ID], [ModuleID], [AuthorityTag]) VALUES (83, 25, N'RGP_DELETE')
INSERT [dbo].[RGP_ModuleAuthorityList] ([ID], [ModuleID], [AuthorityTag]) VALUES (84, 25, N'RGP_SEARCH')
INSERT [dbo].[RGP_ModuleAuthorityList] ([ID], [ModuleID], [AuthorityTag]) VALUES (85, 25, N'RGP_VERIFY')
INSERT [dbo].[RGP_ModuleAuthorityList] ([ID], [ModuleID], [AuthorityTag]) VALUES (86, 25, N'RGP_MOVE')
INSERT [dbo].[RGP_ModuleAuthorityList] ([ID], [ModuleID], [AuthorityTag]) VALUES (97, 25, N'RGP_DOWNLOAD')
SET IDENTITY_INSERT [dbo].[RGP_ModuleAuthorityList] OFF
/****** Object:  Table [dbo].[RGP_Groups]    Script Date: 12/20/2008 16:52:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RGP_Groups](
	[GroupID] [int] IDENTITY(1,1) NOT NULL,
	[GroupName] [nvarchar](30) NOT NULL,
	[GroupOrder] [int] NOT NULL,
	[GroupDescription] [nvarchar](50) NULL,
 CONSTRAINT [PK_RGP_UserGroup] PRIMARY KEY CLUSTERED 
(
	[GroupID] ASC
) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'分组ID' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RGP_Groups', @level2type=N'COLUMN',@level2name=N'GroupID'
GO
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'组名称' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RGP_Groups', @level2type=N'COLUMN',@level2name=N'GroupName'
GO
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'排序' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RGP_Groups', @level2type=N'COLUMN',@level2name=N'GroupOrder'
GO
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'说明' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RGP_Groups', @level2type=N'COLUMN',@level2name=N'GroupDescription'
GO
SET IDENTITY_INSERT [dbo].[RGP_Groups] ON
INSERT [dbo].[RGP_Groups] ([GroupID], [GroupName], [GroupOrder], [GroupDescription]) VALUES (1, N'group1', 1, N'拥有系统最高权限')
INSERT [dbo].[RGP_Groups] ([GroupID], [GroupName], [GroupOrder], [GroupDescription]) VALUES (2, N'group2', 2, N'具用所有管理权限，无系统配置权限')
INSERT [dbo].[RGP_Groups] ([GroupID], [GroupName], [GroupOrder], [GroupDescription]) VALUES (3, N'group3', 3, N'无后台管理权限')
SET IDENTITY_INSERT [dbo].[RGP_Groups] OFF
/****** Object:  Table [dbo].[RGP_Configuration]    Script Date: 12/20/2008 16:52:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RGP_Configuration](
	[ItemID] [int] IDENTITY(1,1) NOT NULL,
	[ItemName] [nvarchar](50) NOT NULL,
	[ItemValue] [nvarchar](500) NULL,
	[ItemDescription] [nvarchar](500) NULL,
 CONSTRAINT [PK_Sys_Configuration] PRIMARY KEY CLUSTERED 
(
	[ItemID] ASC
) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'配置项ID' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RGP_Configuration', @level2type=N'COLUMN',@level2name=N'ItemID'
GO
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'配置名' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RGP_Configuration', @level2type=N'COLUMN',@level2name=N'ItemName'
GO
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'配置值' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RGP_Configuration', @level2type=N'COLUMN',@level2name=N'ItemValue'
GO
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'说明' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RGP_Configuration', @level2type=N'COLUMN',@level2name=N'ItemDescription'
GO
SET IDENTITY_INSERT [dbo].[RGP_Configuration] ON
INSERT [dbo].[RGP_Configuration] ([ItemID], [ItemName], [ItemValue], [ItemDescription]) VALUES (1, N'InitRoleID', N'6', N'注册时初始化权限，设置值必须大于0')
INSERT [dbo].[RGP_Configuration] ([ItemID], [ItemName], [ItemValue], [ItemDescription]) VALUES (2, N'initGroupID', N'3', N'注册时初始化用户组，设置值必须大于0')
INSERT [dbo].[RGP_Configuration] ([ItemID], [ItemName], [ItemValue], [ItemDescription]) VALUES (3, N'IsVerifyUser', N'1', N'注册时是否启用审核，启用则不写入用户权限和用户组信息，审核时写入,输入值只能为0或1')
SET IDENTITY_INSERT [dbo].[RGP_Configuration] OFF
/****** Object:  Table [dbo].[RGP_AuthorityDir]    Script Date: 12/20/2008 16:52:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RGP_AuthorityDir](
	[AuthorityID] [int] IDENTITY(1,1) NOT NULL,
	[AuthorityName] [nvarchar](30) NOT NULL,
	[AuthorityTag] [nvarchar](50) NOT NULL,
	[AuthorityDescription] [nvarchar](50) NULL,
	[AuthorityOrder] [int] NOT NULL,
 CONSTRAINT [PK_RGP_AuthorityDir] PRIMARY KEY CLUSTERED 
(
	[AuthorityID] ASC
) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'权限ID' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RGP_AuthorityDir', @level2type=N'COLUMN',@level2name=N'AuthorityID'
GO
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'权限名称' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RGP_AuthorityDir', @level2type=N'COLUMN',@level2name=N'AuthorityName'
GO
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'权限标识' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RGP_AuthorityDir', @level2type=N'COLUMN',@level2name=N'AuthorityTag'
GO
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'说明' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RGP_AuthorityDir', @level2type=N'COLUMN',@level2name=N'AuthorityDescription'
GO
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'排序' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RGP_AuthorityDir', @level2type=N'COLUMN',@level2name=N'AuthorityOrder'
GO
SET IDENTITY_INSERT [dbo].[RGP_AuthorityDir] ON
INSERT [dbo].[RGP_AuthorityDir] ([AuthorityID], [AuthorityName], [AuthorityTag], [AuthorityDescription], [AuthorityOrder]) VALUES (1, N'AItem1', N'RGP_BROWSE', N'页面访问权限', 1)
INSERT [dbo].[RGP_AuthorityDir] ([AuthorityID], [AuthorityName], [AuthorityTag], [AuthorityDescription], [AuthorityOrder]) VALUES (2, N'AItem2', N'RGP_ADD', N'页面中的添加操作权限', 2)
INSERT [dbo].[RGP_AuthorityDir] ([AuthorityID], [AuthorityName], [AuthorityTag], [AuthorityDescription], [AuthorityOrder]) VALUES (3, N'AItem3', N'RGP_EDIT', N'页面中的编辑修改操作权限', 3)
INSERT [dbo].[RGP_AuthorityDir] ([AuthorityID], [AuthorityName], [AuthorityTag], [AuthorityDescription], [AuthorityOrder]) VALUES (4, N'AItem4', N'RGP_DELETE', N'页面中的删除操作权限', 4)
INSERT [dbo].[RGP_AuthorityDir] ([AuthorityID], [AuthorityName], [AuthorityTag], [AuthorityDescription], [AuthorityOrder]) VALUES (5, N'AItem5', N'RGP_SEARCH', N'数据搜索权限', 5)
INSERT [dbo].[RGP_AuthorityDir] ([AuthorityID], [AuthorityName], [AuthorityTag], [AuthorityDescription], [AuthorityOrder]) VALUES (6, N'AItem6', N'RGP_VERIFY', N'记录审核权限', 6)
INSERT [dbo].[RGP_AuthorityDir] ([AuthorityID], [AuthorityName], [AuthorityTag], [AuthorityDescription], [AuthorityOrder]) VALUES (7, N'AItem7', N'RGP_MOVE', N'移动记录的权限', 7)
INSERT [dbo].[RGP_AuthorityDir] ([AuthorityID], [AuthorityName], [AuthorityTag], [AuthorityDescription], [AuthorityOrder]) VALUES (9, N'AItem8', N'RGP_PRINT', N'打印文档权限', 8)
INSERT [dbo].[RGP_AuthorityDir] ([AuthorityID], [AuthorityName], [AuthorityTag], [AuthorityDescription], [AuthorityOrder]) VALUES (10, N'AItem9', N'RGP_DOWNLOAD', N'下载权限', 9)
INSERT [dbo].[RGP_AuthorityDir] ([AuthorityID], [AuthorityName], [AuthorityTag], [AuthorityDescription], [AuthorityOrder]) VALUES (11, N'AItem10', N'RGP_BACK', N'资料备份权限', 10)
SET IDENTITY_INSERT [dbo].[RGP_AuthorityDir] OFF
/****** Object:  Default [DF_AuthorityDir_AuthorityOrder]    Script Date: 12/20/2008 16:52:53 ******/
ALTER TABLE [dbo].[RGP_AuthorityDir] ADD  CONSTRAINT [DF_AuthorityDir_AuthorityOrder]  DEFAULT ((0)) FOR [AuthorityOrder]
GO
/****** Object:  Default [DF_RGP_UserGroup_UserGroupOrder]    Script Date: 12/20/2008 16:52:53 ******/
ALTER TABLE [dbo].[RGP_Groups] ADD  CONSTRAINT [DF_RGP_UserGroup_UserGroupOrder]  DEFAULT ((0)) FOR [GroupOrder]
GO
/****** Object:  Default [DF_RGP_Modules_ModuleDisabled]    Script Date: 12/20/2008 16:52:53 ******/
ALTER TABLE [dbo].[RGP_Modules] ADD  CONSTRAINT [DF_RGP_Modules_ModuleDisabled]  DEFAULT ((1)) FOR [ModuleDisabled]
GO
/****** Object:  Default [DF_RGP_Modules_ModuleOrder]    Script Date: 12/20/2008 16:52:53 ******/
ALTER TABLE [dbo].[RGP_Modules] ADD  CONSTRAINT [DF_RGP_Modules_ModuleOrder]  DEFAULT ((0)) FOR [ModuleOrder]
GO
/****** Object:  Default [DF_RGP_Modules_IsMenu]    Script Date: 12/20/2008 16:52:53 ******/
ALTER TABLE [dbo].[RGP_Modules] ADD  CONSTRAINT [DF_RGP_Modules_IsMenu]  DEFAULT ((1)) FOR [IsMenu]
GO
/****** Object:  Default [DF_ModuleGroup_ModuleGroupOrder]    Script Date: 12/20/2008 16:52:53 ******/
ALTER TABLE [dbo].[RGP_ModuleType] ADD  CONSTRAINT [DF_ModuleGroup_ModuleGroupOrder]  DEFAULT ((0)) FOR [ModuleTypeOrder]
GO
/****** Object:  Default [DF_RGP_RoleAuthorityList_UserID]    Script Date: 12/20/2008 16:52:53 ******/
ALTER TABLE [dbo].[RGP_RoleAuthorityList] ADD  CONSTRAINT [DF_RGP_RoleAuthorityList_UserID]  DEFAULT ((0)) FOR [UserID]
GO
/****** Object:  Default [DF_RGP_RoleAuthorityList_RoleID]    Script Date: 12/20/2008 16:52:53 ******/
ALTER TABLE [dbo].[RGP_RoleAuthorityList] ADD  CONSTRAINT [DF_RGP_RoleAuthorityList_RoleID]  DEFAULT ((0)) FOR [RoleID]
GO
/****** Object:  Default [DF_RGP_RoleAuthorityList_Flag]    Script Date: 12/20/2008 16:52:53 ******/
ALTER TABLE [dbo].[RGP_RoleAuthorityList] ADD  CONSTRAINT [DF_RGP_RoleAuthorityList_Flag]  DEFAULT ((1)) FOR [Flag]
GO
/****** Object:  Default [DF_Users_RoleID]    Script Date: 12/20/2008 16:52:53 ******/
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF_Users_RoleID]  DEFAULT ((0)) FOR [RoleID]
GO
/****** Object:  Default [DF_Users_UserGroup]    Script Date: 12/20/2008 16:52:53 ******/
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF_Users_UserGroup]  DEFAULT ((0)) FOR [UserGroup]
GO
/****** Object:  Default [DF_Users_Status]    Script Date: 12/20/2008 16:52:53 ******/
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF_Users_Status]  DEFAULT ((1)) FOR [Status]
GO
/****** Object:  Default [DF_Users_IsOnline]    Script Date: 12/20/2008 16:52:53 ******/
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF_Users_IsOnline]  DEFAULT ((0)) FOR [IsOnline]
GO
/****** Object:  Default [DF_Users_IsLimit]    Script Date: 12/20/2008 16:52:53 ******/
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF_Users_IsLimit]  DEFAULT ((0)) FOR [IsLimit]
GO
