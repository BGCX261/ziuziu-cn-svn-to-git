if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ActiveType_SelectByID]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[ActiveType_SelectByID]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Album_InsertUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[Album_InsertUpdate]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Album_SelectByID]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[Album_SelectByID]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Area_InsertUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[Area_InsertUpdate]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Area_SelectByID]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[Area_SelectByID]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ArtClass_InsertUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[ArtClass_InsertUpdate]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ArtClass_SelectByID]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[ArtClass_SelectByID]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ArticleReply_InsertUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[ArticleReply_InsertUpdate]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ArticleReply_SelectByID]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[ArticleReply_SelectByID]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Article_InsertUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[Article_InsertUpdate]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Article_SelectByID]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[Article_SelectByID]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Batch]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[Batch]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CommendInfo_InsertUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[CommendInfo_InsertUpdate]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CommendInfo_SelectByID]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[CommendInfo_SelectByID]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Friend_InsertUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[Friend_InsertUpdate]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Friend_SelectByID]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[Friend_SelectByID]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[GetRecordByPageOrder]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[GetRecordByPageOrder]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Message_InsertUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[Message_InsertUpdate]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Message_SelectByID]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[Message_SelectByID]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Path_InsertUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[Path_InsertUpdate]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Path_SelectByID]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[Path_SelectByID]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PhotoReply_InsertUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[PhotoReply_InsertUpdate]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PhotoReply_SelectByID]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[PhotoReply_SelectByID]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Photo_InsertUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[Photo_InsertUpdate]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Photo_SelectByID]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[Photo_SelectByID]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Tags_InsertUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[Tags_InsertUpdate]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Tags_SelectByID]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[Tags_SelectByID]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Users_InsertUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[Users_InsertUpdate]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Users_SelectByID]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[Users_SelectByID]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ActiveType]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[ActiveType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Album]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[Album]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Area]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[Area]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ArtClass]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[ArtClass]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Article]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[Article]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ArticleReply]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[ArticleReply]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CommendInfo]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[CommendInfo]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Friend]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[Friend]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Message]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[Message]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Path]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[Path]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Photo]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[Photo]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PhotoReply]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[PhotoReply]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[RecentActive]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[RecentActive]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Tags]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[Tags]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Users]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[Users]
GO

CREATE TABLE [dbo].[ActiveType] (
	[ID] [int] IDENTITY (1, 1) NOT NULL ,
	[Content] [nvarchar] (1000) COLLATE Chinese_PRC_CI_AS NULL ,
	[Url] [nvarchar] (200) COLLATE Chinese_PRC_CI_AS NULL ,
	[IsDelete] [bit] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Album] (
	[ID] [int] IDENTITY (1, 1) NOT NULL ,
	[Title] [nvarchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Summary] [nvarchar] (1000) COLLATE Chinese_PRC_CI_AS NULL ,
	[AddDate] [datetime] NULL ,
	[IP] [nvarchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[UserID] [int] NULL ,
	[UpdateDate] [datetime] NULL ,
	[ShowPic] [nvarchar] (200) COLLATE Chinese_PRC_CI_AS NULL ,
	[IsCheck] [bit] NULL ,
	[IsDelete] [bit] NULL ,
	[IsCommon] [int] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Area] (
	[ID] [int] IDENTITY (1, 1) NOT NULL ,
	[AreaName] [nvarchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[AreaCode] [nvarchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Flag] [bit] NULL ,
	[ShortName] [nvarchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[IsDelete] [bit] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[ArtClass] (
	[ID] [int] IDENTITY (1, 1) NOT NULL ,
	[Title] [nvarchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[AddDate] [datetime] NULL ,
	[IP] [nvarchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Layer] [nvarchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[UpdateDate] [datetime] NULL ,
	[IsDelete] [bit] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Article] (
	[ID] [int] IDENTITY (1, 1) NOT NULL ,
	[Title] [nvarchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,
	[Content] [text] COLLATE Chinese_PRC_CI_AS NULL ,
	[AddDate] [datetime] NULL ,
	[IP] [nvarchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[UserID] [int] NULL ,
	[ClassID] [int] NULL ,
	[Summary] [nvarchar] (500) COLLATE Chinese_PRC_CI_AS NULL ,
	[TotalHits] [int] NULL ,
	[IsDraft] [bit] NULL ,
	[UpdateDate] [datetime] NULL ,
	[IsCheck] [bit] NULL ,
	[IsDelete] [bit] NULL ,
	[IsCommon] [int] NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[ArticleReply] (
	[ID] [int] IDENTITY (1, 1) NOT NULL ,
	[Content] [text] COLLATE Chinese_PRC_CI_AS NULL ,
	[AddDate] [datetime] NULL ,
	[IP] [nvarchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[UserID] [int] NULL ,
	[ArticleID] [int] NULL ,
	[IsCheck] [bit] NULL ,
	[IsDelete] [bit] NULL ,
	[UpdateDate] [datetime] NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[CommendInfo] (
	[ID] [int] IDENTITY (1, 1) NOT NULL ,
	[Title] [nvarchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,
	[Content] [text] COLLATE Chinese_PRC_CI_AS NULL ,
	[AddDate] [datetime] NULL ,
	[IP] [nvarchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[UserID] [int] NULL ,
	[ClassID] [int] NULL ,
	[Summary] [nvarchar] (500) COLLATE Chinese_PRC_CI_AS NULL ,
	[TotalHits] [int] NULL ,
	[IsDraft] [bit] NULL ,
	[UpdateDate] [datetime] NULL ,
	[IsCheck] [bit] NULL ,
	[IsDelete] [bit] NULL ,
	[IsCommon] [int] NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[Friend] (
	[ID] [int] IDENTITY (1, 1) NOT NULL ,
	[FriendID] [int] NULL ,
	[UserID] [int] NULL ,
	[AddDate] [datetime] NULL ,
	[IsCheck] [bit] NULL ,
	[IsDelete] [bit] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Message] (
	[ID] [int] IDENTITY (1, 1) NOT NULL ,
	[FromID] [char] (10) COLLATE Chinese_PRC_CI_AS NULL ,
	[ToID] [int] NULL ,
	[Title] [nvarchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Content] [text] COLLATE Chinese_PRC_CI_AS NULL ,
	[AddDate] [datetime] NULL ,
	[IsCheck] [bit] NULL ,
	[IsDelete] [bit] NULL ,
	[IsSee] [bit] NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[Path] (
	[ID] [int] IDENTITY (1, 1) NOT NULL ,
	[Content] [text] COLLATE Chinese_PRC_CI_AS NULL ,
	[InfoID] [int] NULL ,
	[Flag] [int] NULL ,
	[UserID] [int] NULL ,
	[AddDate] [datetime] NULL ,
	[IP] [nvarchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[PathID] [int] NULL ,
	[IsDelete] [bit] NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[Photo] (
	[ID] [int] IDENTITY (1, 1) NOT NULL ,
	[Summary] [nvarchar] (1000) COLLATE Chinese_PRC_CI_AS NULL ,
	[AddDate] [datetime] NULL ,
	[TotalHits] [int] NULL ,
	[BigPic] [nvarchar] (200) COLLATE Chinese_PRC_CI_AS NULL ,
	[SmallPic] [nvarchar] (200) COLLATE Chinese_PRC_CI_AS NULL ,
	[AlbumID] [int] NULL ,
	[IsCheck] [bit] NULL ,
	[IsDelete] [bit] NULL ,
	[IsCommon] [int] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[PhotoReply] (
	[ID] [int] IDENTITY (1, 1) NOT NULL ,
	[Content] [text] COLLATE Chinese_PRC_CI_AS NULL ,
	[AddDate] [datetime] NULL ,
	[IP] [nvarchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[UserID] [int] NULL ,
	[PhotoID] [int] NULL ,
	[IsCheck] [bit] NULL ,
	[IsDelete] [bit] NULL ,
	[UpdateDate] [datetime] NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[RecentActive] (
	[ID] [int] IDENTITY (1, 1) NOT NULL ,
	[UserId] [int] NULL ,
	[Content] [text] COLLATE Chinese_PRC_CI_AS NULL ,
	[AddDate] [datetime] NULL ,
	[ActiveType] [int] NULL ,
	[IsCheck] [bit] NULL ,
	[IsDelete] [bit] NULL ,
	[IsSee] [bit] NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[Tags] (
	[ID] [int] IDENTITY (1, 1) NOT NULL ,
	[TagName] [nvarchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[AreaCode] [nvarchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[InfoID] [int] NULL ,
	[Flag] [bit] NULL ,
	[IsDelete] [bit] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Users] (
	[ID] [int] IDENTITY (1, 1) NOT NULL ,
	[Nick] [nvarchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Email] [nvarchar] (200) COLLATE Chinese_PRC_CI_AS NULL ,
	[Pwd] [nvarchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,
	[DomainName] [nvarchar] (20) COLLATE Chinese_PRC_CI_AS NULL ,
	[AreaCode] [nvarchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[RegDate] [datetime] NULL ,
	[Sex] [bit] NULL ,
	[Birthday] [datetime] NULL ,
	[Brief] [nvarchar] (500) COLLATE Chinese_PRC_CI_AS NULL ,
	[Pic] [nvarchar] (200) COLLATE Chinese_PRC_CI_AS NULL ,
	[Blog] [nvarchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[LoginTimes] [int] NULL ,
	[LastDate] [datetime] NULL ,
	[LastIP] [nvarchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[VisitTimes] [int] NULL ,
	[IsForbid] [bit] NULL ,
	[LoginStatus] [int] NULL ,
	[IsDelete] [bit] NULL 
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[ActiveType] WITH NOCHECK ADD 
	CONSTRAINT [PK_ActiveType] PRIMARY KEY  CLUSTERED 
	(
		[ID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[Album] WITH NOCHECK ADD 
	CONSTRAINT [PK_Album] PRIMARY KEY  CLUSTERED 
	(
		[ID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[Area] WITH NOCHECK ADD 
	CONSTRAINT [PK_Area] PRIMARY KEY  CLUSTERED 
	(
		[ID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[ArtClass] WITH NOCHECK ADD 
	CONSTRAINT [PK_ArtClass] PRIMARY KEY  CLUSTERED 
	(
		[ID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[Article] WITH NOCHECK ADD 
	CONSTRAINT [PK_Article] PRIMARY KEY  CLUSTERED 
	(
		[ID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[ArticleReply] WITH NOCHECK ADD 
	CONSTRAINT [PK_ArticleReply] PRIMARY KEY  CLUSTERED 
	(
		[ID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[CommendInfo] WITH NOCHECK ADD 
	CONSTRAINT [PK_CommendInfo] PRIMARY KEY  CLUSTERED 
	(
		[ID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[Friend] WITH NOCHECK ADD 
	CONSTRAINT [PK_Friend] PRIMARY KEY  CLUSTERED 
	(
		[ID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[Message] WITH NOCHECK ADD 
	CONSTRAINT [PK_Message] PRIMARY KEY  CLUSTERED 
	(
		[ID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[Path] WITH NOCHECK ADD 
	CONSTRAINT [PK_Path] PRIMARY KEY  CLUSTERED 
	(
		[ID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[Photo] WITH NOCHECK ADD 
	CONSTRAINT [PK_Photo] PRIMARY KEY  CLUSTERED 
	(
		[ID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[PhotoReply] WITH NOCHECK ADD 
	CONSTRAINT [PK_PhotoReply] PRIMARY KEY  CLUSTERED 
	(
		[ID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[RecentActive] WITH NOCHECK ADD 
	CONSTRAINT [PK_RecentActive] PRIMARY KEY  CLUSTERED 
	(
		[ID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[Tags] WITH NOCHECK ADD 
	CONSTRAINT [PK_Tags] PRIMARY KEY  CLUSTERED 
	(
		[ID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[Users] WITH NOCHECK ADD 
	CONSTRAINT [PK_Users] PRIMARY KEY  CLUSTERED 
	(
		[ID]
	)  ON [PRIMARY] 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO


------------------------------------
--用途：得到实体对象的详细信息 
--项目名称：CodematicDemo
--说明：
--时间：2008-7-9 9:24:36
------------------------------------
CREATE PROCEDURE ActiveType_SelectByID
@ID int
 AS 
	SELECT 
	ID,Content,Url,IsDelete
	 FROM ActiveType
	 WHERE ID=@ID
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO


-- =============================================
-- Author:		
-- Create date: 080708
-- Description:	添加修改
--				
-- Return：		-300，重复；0,成功；-100,返回更新错误；-200，插入错误；
-- ReturnValue：@lD
-- =============================================
CREATE PROCEDURE [dbo].[Album_InsertUpdate]
(
@ID int output,
@Title nvarchar(50),
@Summary nvarchar(1000),
@AddDate datetime,
@IP nvarchar(50),
@UserID int,
@UpdateDate datetime,
@ShowPic nvarchar(200),
@IsCheck bit,
@IsDelete bit,
@IsCommon int,
@Provider int
)
AS
DECLARE @vIsExtension INT
BEGIN	
	SET NOCOUNT ON;		
	IF (@AddDate IS NULL)
		SELECT @AddDate=GETDATE()
	IF (@UpdateDate IS NULL)
		SELECT @UpdateDate=GETDATE()
	/*IF (LEN(@pExtension) > 0)
		SELECT @vIsExtension = 1*/
	BEGIN TRANSACTION
	IF (@Provider = 3) --更新
	BEGIN			
		UPDATE Album SET 
	[Title] = @Title,[Summary] = @Summary,[IP] = @IP,[UserID] = @UserID,[UpdateDate] = @UpdateDate,[ShowPic] = @ShowPic,[IsCheck] = @IsCheck,[IsDelete] = @IsDelete,[IsCommon] = @IsCommon
	WHERE ID=@ID 
		IF @@error <> 0
		BEGIN			
			ROLLBACK TRANSACTION
			return -100
		END

	END
	ELSE IF (@Provider = 2)--插入
	BEGIN
		INSERT INTO Album(
	[Title],[Summary],[AddDate],[IP],[UserID],[UpdateDate],[ShowPic],[IsCheck],[IsDelete],[IsCommon]
	)VALUES(
	@Title,@Summary,@AddDate,@IP,@UserID,@UpdateDate,@ShowPic,@IsCheck,@IsDelete,@IsCommon
	)
		IF @@error <> 0
		BEGIN
			ROLLBACK TRANSACTION			
			return -200
		END
                          SELECT @ID = @@IDENTITY	
	END

	COMMIT TRANSACTION
	RETURN 0 
    SET NOCOUNT OFF;
END
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO


------------------------------------
--用途：得到实体对象的详细信息 
--项目名称：CodematicDemo
--说明：
--时间：2008-7-9 9:24:36
------------------------------------
CREATE PROCEDURE Album_SelectByID
@ID int
 AS 
	SELECT 
	ID,Title,Summary,AddDate,IP,UserID,UpdateDate,ShowPic,IsCheck,IsDelete,IsCommon
	 FROM Album
	 WHERE ID=@ID
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO


-- =============================================
-- Author:		
-- Create date: 080708
-- Description:	添加修改
--				
-- Return：		-300，重复；0,成功；-100,返回更新错误；-200，插入错误；
-- ReturnValue：@lD
-- =============================================
CREATE PROCEDURE [dbo].[Area_InsertUpdate]
(
@ID int output,
@AreaName nvarchar(50),
@AreaCode nvarchar(50),
@Flag bit,
@ShortName nvarchar(50),
@Provider int
)
AS
DECLARE @vIsExtension INT
BEGIN	
	SET NOCOUNT ON;		
	BEGIN TRANSACTION
	IF (@Provider = 3) --更新
	BEGIN			
		UPDATE Area SET 
	[AreaName] = @AreaName,[AreaCode] = @AreaCode,[Flag] = @Flag,[ShortName] = @ShortName
	WHERE ID=@ID 
		IF @@error <> 0
		BEGIN			
			ROLLBACK TRANSACTION
			return -100
		END

	END
	ELSE IF (@Provider = 2)--插入
	BEGIN
		INSERT INTO Area(
	[AreaName],[AreaCode],[Flag],[ShortName]
	)VALUES(
	@AreaName,@AreaCode,@Flag,@ShortName
	)
		IF @@error <> 0
		BEGIN
			ROLLBACK TRANSACTION			
			return -200
		END
		SELECT @ID = @@IDENTITY	
	END

	COMMIT TRANSACTION
	RETURN 0 
    SET NOCOUNT OFF;
END
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO


------------------------------------
--用途：得到实体对象的详细信息 
--项目名称：CodematicDemo
--说明：
--时间：2008-7-9 9:24:36
------------------------------------
CREATE PROCEDURE Area_SelectByID
@ID int
 AS 
	SELECT 
	ID,AreaName,AreaCode,Flag,ShortName,IsDelete
	 FROM Area
	 WHERE ID=@ID
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS OFF 
GO


-- =============================================
-- Author:		
-- Create date: 080708
-- Description:	添加修改
--				
-- Return：		-300，重复；0,成功；-100,返回更新错误；-200，插入错误；
-- ReturnValue：@lD
-- =============================================
CREATE PROCEDURE [dbo].[ArtClass_InsertUpdate]
(
@ID int output,
@Title nvarchar(50),
@AddDate datetime,
@UpdateDate datetime,
@IP nvarchar(50),
@Layer nvarchar(50),
@Provider int
)
AS
DECLARE @vIsExtension INT
BEGIN	
	SET NOCOUNT ON;		
	IF (@AddDate IS NULL)
		SELECT @AddDate=GETDATE()
              IF (@UpdateDate IS NULL)
		SELECT @UpdateDate=GETDATE()
	/*IF (LEN(@pExtension) > 0)
		SELECT @vIsExtension = 1*/
	BEGIN TRANSACTION
	IF (@Provider = 3) --更新
	BEGIN			
		UPDATE ArtClass SET 
	[Title] = @Title,[UpdateDate] = @UpdateDate,[IP] = @IP,[Layer] = @Layer
	WHERE ID=@ID 
		IF @@error <> 0
		BEGIN			
			ROLLBACK TRANSACTION
			return -100
		END

	END
	ELSE IF (@Provider = 2)--插入
	BEGIN
		INSERT INTO ArtClass(
	[Title],[AddDate],[IP],[Layer]
	)VALUES(
	@Title,@AddDate,@IP,@Layer
	)
		IF @@error <> 0
		BEGIN
			ROLLBACK TRANSACTION			
			return -200
		END
		SELECT @ID = @@IDENTITY	
	END

	COMMIT TRANSACTION
	RETURN 0 
    SET NOCOUNT OFF;
END
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO


------------------------------------
--用途：得到实体对象的详细信息 
--项目名称：CodematicDemo
--说明：
--时间：2008-7-9 9:24:36
------------------------------------
CREATE PROCEDURE ArtClass_SelectByID
@ID int
 AS 
	SELECT 
	ID,Title,AddDate,IP,Layer,UpdateDate,IsDelete
	 FROM ArtClass
	 WHERE ID=@ID
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS OFF 
GO


-- =============================================
-- Author:		
-- Create date: 080708
-- Description:	添加修改
--				
-- Return：		-300，重复；0,成功；-100,返回更新错误；-200，插入错误；
-- ReturnValue：@lD
-- =============================================
CREATE PROCEDURE [dbo].[ArticleReply_InsertUpdate]
(
@ID int output,
@Content text,
@AddDate datetime,
@UpdateDate datetime,
@IP nvarchar(50),
@UserID int,
@ArticleID int,
@IsCheck bit,
@IsDelete bit,
@Provider int
)
AS
DECLARE @vIsExtension INT
BEGIN	
	SET NOCOUNT ON;		
	IF (@AddDate IS NULL)
		SELECT @AddDate=GETDATE()
	/*IF (LEN(@pExtension) > 0)
		SELECT @vIsExtension = 1*/
	BEGIN TRANSACTION
	IF (@Provider = 3) --更新
	BEGIN			
		UPDATE ArticleReply SET 
	[Content] = @Content,[UpdateDate] = @UpdateDate,[IP] = @IP,[UserID] = @UserID,[ArticleID] = @ArticleID,[IsCheck] = @IsCheck,[IsDelete] = @IsDelete
	WHERE ID=@ID 
		IF @@error <> 0
		BEGIN			
			ROLLBACK TRANSACTION
			return -100
		END

	END
	ELSE IF (@Provider = 2)--插入
	BEGIN
		INSERT INTO ArticleReply(
	[Content],[AddDate],[IP],[UserID],[ArticleID],[IsCheck],[IsDelete]
	)VALUES(
	@Content,@AddDate,@IP,@UserID,@ArticleID,@IsCheck,@IsDelete
	)
		IF @@error <> 0
		BEGIN
			ROLLBACK TRANSACTION			
			return -200
		END
		SELECT @ID = @@IDENTITY	
	END

	COMMIT TRANSACTION
	RETURN 0 
    SET NOCOUNT OFF;
END
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO


------------------------------------
--用途：得到实体对象的详细信息 
--项目名称：CodematicDemo
--说明：
--时间：2008-7-9 9:24:36
------------------------------------
CREATE PROCEDURE ArticleReply_SelectByID
@ID int
 AS 
	SELECT 
	ID,Content,AddDate,IP,UserID,ArticleID,IsCheck,IsDelete,UpdateDate
	 FROM ArticleReply
	 WHERE ID=@ID
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO


-- =============================================
-- Author:		
-- Create date: 080708
-- Description:	添加修改
--				
-- Return：		-300，重复；0,成功；-100,返回更新错误；-200，插入错误；
-- ReturnValue：@lD
-- =============================================
CREATE PROCEDURE [dbo].[Article_InsertUpdate]
(
@ID int output,
@Title nvarchar(100),
@Content text,
@AddDate datetime,
@IP nvarchar(50),
@UserID int,
@ClassID int,
@Summary nvarchar(500),
@TotalHits int,
@IsDraft bit,
@UpdateDate datetime,
@IsCheck bit,
@IsDelete bit,
@IsCommon int,
@Provider int
)
AS
DECLARE @vIsExtension INT
BEGIN	
	SET NOCOUNT ON;		
	IF (@AddDate IS NULL)
		SELECT @AddDate=GETDATE()
	IF (@UpdateDate IS NULL)
		SELECT @UpdateDate=GETDATE()
	/*IF (LEN(@pExtension) > 0)
		SELECT @vIsExtension = 1*/
	BEGIN TRANSACTION
	IF (@Provider = 3) --更新
	BEGIN			
		UPDATE Article SET 
	[Title] = @Title,[Content] = @Content,[IP] = @IP,[UserID] = @UserID,[ClassID] = @ClassID,[Summary] = @Summary,[TotalHits] = @TotalHits,[IsDraft] = @IsDraft,[UpdateDate] = @UpdateDate,[IsCheck] = @IsCheck,[IsDelete] = @IsDelete,[IsCommon] = @IsCommon
	WHERE ID=@ID 
		IF @@error <> 0
		BEGIN			
			ROLLBACK TRANSACTION
			return -100
		END

	END
	ELSE IF (@Provider = 2)--插入
	BEGIN
		INSERT INTO Article(
	[Title],[Content],[AddDate],[IP],[UserID],[ClassID],[Summary],[TotalHits],[IsDraft],[UpdateDate],[IsCheck],[IsDelete],[IsCommon]
	)VALUES(
	@Title,@Content,@AddDate,@IP,@UserID,@ClassID,@Summary,@TotalHits,@IsDraft,@UpdateDate,@IsCheck,@IsDelete,@IsCommon
	)
		IF @@error <> 0
		BEGIN
			ROLLBACK TRANSACTION			
			return -200
		END
		SELECT @ID = @@IDENTITY	
	END

	COMMIT TRANSACTION
	RETURN 0 
    SET NOCOUNT OFF;
END
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO


------------------------------------
--用途：得到实体对象的详细信息 
--项目名称：CodematicDemo
--说明：
--时间：2008-7-9 9:24:36
------------------------------------
CREATE PROCEDURE Article_SelectByID
@ID int
 AS 
	SELECT 
	ID,Title,Content,AddDate,IP,UserID,ClassID,Summary,TotalHits,IsDraft,UpdateDate,IsCheck,IsDelete,IsCommon
	 FROM Article
	 WHERE ID=@ID
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO

CREATE PROCEDURE Batch(--通用操作
	  @TableName VARCHAR(30),
	  @Column VARCHAR(50),
      @ColumnValue VARCHAR(50),
	  @PrimaryKey VARCHAR(50),	
      @PrimaryValueList VARCHAR(500)
)
AS
BEGIN
	SET NOCOUNT ON;
	DECLARE @strSQL NVARCHAR(100)
	SET @strSQL = 'UPDATE '+ @TableName + ' SET '+@Column+' = @ColumnValue' + ' WHERE '+@PrimaryKey+' IN ('+ @PrimaryValueList +')'
	BEGIN TRAN
	EXECUTE sp_executesql @strSQL,N'@ColumnValue VARCHAR(50)',@ColumnValue
	
	IF @@error !=0
		BEGIN
			ROLLBACK
		END
	ELSE
		BEGIN
			COMMIT
		END
	SET NOCOUNT OFF;
END
RETURN
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO


-- =============================================
-- Author:		
-- Create date: 080708
-- Description:	添加修改
--				
-- Return：		-300，重复；0,成功；-100,返回更新错误；-200，插入错误；
-- ReturnValue：@lD
-- =============================================
CREATE PROCEDURE [dbo].[CommendInfo_InsertUpdate]
(
@ID int output,
@Title nvarchar(100),
@Content text,
@AddDate datetime,
@IP nvarchar(50),
@UserID int,
@ClassID int,
@Summary nvarchar(500),
@TotalHits int,
@IsDraft bit,
@UpdateDate datetime,
@IsCheck bit,
@IsDelete bit,
@IsCommon int,
@Provider int
)
AS
DECLARE @vIsExtension INT
BEGIN	
	SET NOCOUNT ON;		
	IF (@AddDate IS NULL)
		SELECT @AddDate=GETDATE()
	IF (@UpdateDate IS NULL)
		SELECT @UpdateDate=GETDATE()
	/*IF (LEN(@pExtension) > 0)
		SELECT @vIsExtension = 1*/
	BEGIN TRANSACTION
	IF (@Provider = 3) --更新
	BEGIN			
		UPDATE Article SET 
	[Title] = @Title,[Content] = @Content,[IP] = @IP,[UserID] = @UserID,[ClassID] = @ClassID,[Summary] = @Summary,[TotalHits] = @TotalHits,[IsDraft] = @IsDraft,[UpdateDate] = @UpdateDate,[IsCheck] = @IsCheck,[IsDelete] = @IsDelete,[IsCommon] = @IsCommon
	WHERE ID=@ID 
		IF @@error <> 0
		BEGIN			
			ROLLBACK TRANSACTION
			return -100
		END

	END
	ELSE IF (@Provider = 2)--插入
	BEGIN
		INSERT INTO Article(
	[Title],[Content],[AddDate],[IP],[UserID],[ClassID],[Summary],[TotalHits],[IsDraft],[UpdateDate],[IsCheck],[IsDelete],[IsCommon]
	)VALUES(
	@Title,@Content,@AddDate,@IP,@UserID,@ClassID,@Summary,@TotalHits,@IsDraft,@UpdateDate,@IsCheck,@IsDelete,@IsCommon
	)
		IF @@error <> 0
		BEGIN
			ROLLBACK TRANSACTION			
			return -200
		END
		SELECT @ID = @@IDENTITY	
	END

	COMMIT TRANSACTION
	RETURN 0 
    SET NOCOUNT OFF;
END
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO


------------------------------------
--用途：得到实体对象的详细信息 
--项目名称：CodematicDemo
--说明：
--时间：2008-7-9 9:24:36
------------------------------------
CREATE PROCEDURE CommendInfo_SelectByID
@ID int
 AS 
	SELECT 
	ID,Title,Content,AddDate,IP,UserID,ClassID,Summary,TotalHits,IsDraft,UpdateDate,IsCheck,IsDelete,IsCommon
	 FROM CommendInfo
	 WHERE ID=@ID
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO


-- =============================================
-- Author:		
-- Create date: 080708
-- Description:	添加修改
--				
-- Return：		-300，重复；0,成功；-100,返回更新错误；-200，插入错误；
-- ReturnValue：@lD
-- =============================================
CREATE PROCEDURE [dbo].[Friend_InsertUpdate]
(
@ID int output,
@FriendID int,
@UserID int,
@AddDate datetime,
@IsCheck bit,
@IsDelete bit,
@Provider int
)
AS
DECLARE @vIsExtension INT
BEGIN	
	SET NOCOUNT ON;		
	IF (@AddDate IS NULL)
		SELECT @AddDate=GETDATE()
	/*IF (LEN(@pExtension) > 0)
		SELECT @vIsExtension = 1*/
	BEGIN TRANSACTION
	IF (@Provider = 3) --更新
	BEGIN			
		UPDATE Friend SET 
	[FriendID] = @FriendID,[UserID] = @UserID,[AddDate] = @AddDate,[IsCheck] = @IsCheck,[IsDelete] = @IsDelete
	WHERE ID=@ID 
		IF @@error <> 0
		BEGIN			
			ROLLBACK TRANSACTION
			return -100
		END

	END
	ELSE IF (@Provider = 2)--插入
	BEGIN
		INSERT INTO Friend(
	[FriendID],[UserID],[AddDate],[IsCheck],[IsDelete]
	)VALUES(
	@FriendID,@UserID,@AddDate,@IsCheck,@IsDelete
	)
		IF @@error <> 0
		BEGIN
			ROLLBACK TRANSACTION			
			return -200
		END
		SELECT @ID = @@IDENTITY	
	END

	COMMIT TRANSACTION
	RETURN 0 
    SET NOCOUNT OFF;
END
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO


------------------------------------
--用途：得到实体对象的详细信息 
--项目名称：CodematicDemo
--说明：
--时间：2008-7-9 9:24:36
------------------------------------
CREATE PROCEDURE Friend_SelectByID
@ID int
 AS 
	SELECT 
	ID,FriendID,UserID,AddDate,IsCheck,IsDelete
	 FROM Friend
	 WHERE ID=@ID
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO



CREATE procedure GetRecordByPageOrder
(
@tblName varchar(255),--表的名称
@strflds varchar(1000),---查询字段 O.name,O.id,
@strWhere varchar(1000) = ' ',--查询条件
@strOrderby varchar(200) = ' ',--排序
@fldName varchar(255),  -- 主键
@fldNameType varchar(255)='int',  -- 主键类型
@PageSize int=10,--页尺寸 
@PageIndex int=1,--页码 
@docount int=0 --为1 表示得到记录总数
)
as
set nocount on
declare @strSQL varchar(6000) 
if(@docount=1)
begin
set @strSQL=' select count('+@fldName+') from '+@tblName+' '+@strWhere
exec(@strSQL)
end
else
begin
declare @PageLowerBound int
declare @PageUpperBound int
set @PageLowerBound=(@pageindex-1)*@pagesize
set @PageUpperBound=@PageLowerBound+@pagesize
set rowcount @PageUpperBound
set @strSQL= ' declare @indextable table(id int identity(1,1),nid '+@fldNameType+')  ' 
set @strSQL= @strSQL+'  insert into @indextable(nid) select '+@fldName+' from '+@tblName+' '+@strWhere+'  '+@strOrderby
set @strSQL= @strSQL+' select  t.id as identityID,'+@strflds+'   from '+@tblName+' O,@indextable t where O.'+@fldName+'=t.nid 
and t.id>'+str(@PageLowerBound) +' and t.id<='+str(@PageUpperBound) +'  order by t.id '
exec(@strSQL)
end
set nocount off
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO


-- =============================================
-- Author:		
-- Create date: 080708
-- Description:	添加修改
--				
-- Return：		-300，重复；0,成功；-100,返回更新错误；-200，插入错误；
-- ReturnValue：@lD
-- =============================================
CREATE PROCEDURE [dbo].[Message_InsertUpdate]
(
@ID int output,
@FromID char(10),
@ToID int,
@Title nvarchar(50),
@Content text,
@AddDate datetime,
@IsCheck bit,
@IsDelete bit,
@IsSee bit,
@Provider int
)
AS
DECLARE @vIsExtension INT
BEGIN	
	SET NOCOUNT ON;		
	IF (@AddDate IS NULL)
		SELECT @AddDate=GETDATE()
	/*IF (LEN(@pExtension) > 0)
		SELECT @vIsExtension = 1*/
	BEGIN TRANSACTION
	IF (@Provider = 3) --更新
	BEGIN			
		UPDATE Message SET 
	[FromID] = @FromID,[ToID] = @ToID,[Title] = @Title,[Content] = @Content,[AddDate] = @AddDate,[IsCheck] = @IsCheck,[IsDelete] = @IsDelete,[IsSee] = @IsSee
	WHERE ID=@ID 
		IF @@error <> 0
		BEGIN			
			ROLLBACK TRANSACTION
			return -100
		END

	END
	ELSE IF (@Provider = 2)--插入
	BEGIN
		INSERT INTO Message(
	[FromID],[ToID],[Title],[Content],[AddDate],[IsCheck],[IsDelete],[IsSee]
	)VALUES(
	@FromID,@ToID,@Title,@Content,@AddDate,@IsCheck,@IsDelete,@IsSee
	)
		IF @@error <> 0
		BEGIN
			ROLLBACK TRANSACTION			
			return -200
		END
		SELECT @ID = @@IDENTITY	
	END

	COMMIT TRANSACTION
	RETURN 0 
    SET NOCOUNT OFF;
END
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO


------------------------------------
--用途：得到实体对象的详细信息 
--项目名称：CodematicDemo
--说明：
--时间：2008-7-9 9:24:36
------------------------------------
CREATE PROCEDURE Message_SelectByID
@ID int
 AS 
	SELECT 
	ID,FromID,ToID,Title,Content,AddDate,IsCheck,IsDelete,IsSee
	 FROM Message
	 WHERE ID=@ID
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO


-- =============================================
-- Author:		
-- Create date: 080708
-- Description:	添加修改
--				
-- Return：		-300，重复；0,成功；-100,返回更新错误；-200，插入错误；
-- ReturnValue：@lD
-- =============================================
CREATE PROCEDURE [dbo].[Path_InsertUpdate]
(
@ID int output,
@Content text,
@InfoID int,
@Flag int,
@UserID int,
@AddDate datetime,
@IP nvarchar(50),
@PathID int,
@Provider int
)
AS
DECLARE @vIsExtension INT
BEGIN	
	SET NOCOUNT ON;		
	IF (@AddDate IS NULL)
		SELECT @AddDate=GETDATE()
	/*IF (LEN(@pExtension) > 0)
		SELECT @vIsExtension = 1*/
	BEGIN TRANSACTION
	IF (@Provider = 3) --更新
	BEGIN			
		UPDATE Path SET 
	[Content] = @Content,[InfoID] = @InfoID,[Flag] = @Flag,[UserID] = @UserID,[AddDate] = @AddDate,[IP] = @IP,[PathID] = @PathID
	WHERE ID=@ID 
		IF @@error <> 0
		BEGIN			
			ROLLBACK TRANSACTION
			return -100
		END

	END
	ELSE IF (@Provider = 2)--插入
	BEGIN
		INSERT INTO Path(
	[Content],[InfoID],[Flag],[UserID],[AddDate],[IP],[PathID]
	)VALUES(
	@Content,@InfoID,@Flag,@UserID,@AddDate,@IP,@PathID
	)
		IF @@error <> 0
		BEGIN
			ROLLBACK TRANSACTION			
			return -200
		END
		SELECT @ID = @@IDENTITY	
	END

	COMMIT TRANSACTION
	RETURN 0 
    SET NOCOUNT OFF;
END
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO


------------------------------------
--用途：得到实体对象的详细信息 
--项目名称：CodematicDemo
--说明：
--时间：2008-7-9 9:24:36
------------------------------------
CREATE PROCEDURE Path_SelectByID
@ID int
 AS 
	SELECT 
	ID,Content,InfoID,Flag,UserID,AddDate,IP,PathID,IsDelete
	 FROM Path
	 WHERE ID=@ID
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO


-- =============================================
-- Author:		
-- Create date: 080708
-- Description:	添加修改
--				
-- Return：		-300，重复；0,成功；-100,返回更新错误；-200，插入错误；
-- ReturnValue：@lD
-- =============================================
CREATE PROCEDURE [dbo].[PhotoReply_InsertUpdate]
(
@ID int output,
@Content text,
@AddDate datetime,
@IP nvarchar(50),
@UserID int,
@PhotoID int,
@IsCheck bit,
@IsDelete bit,
@UpdateDate datetime,
@Provider int
)
AS
DECLARE @vIsExtension INT
BEGIN	
	SET NOCOUNT ON;		
	IF (@AddDate IS NULL)
		SELECT @AddDate=GETDATE()
	IF (@UpdateDate IS NULL)
		SELECT @UpdateDate=GETDATE()
	/*IF (LEN(@pExtension) > 0)
		SELECT @vIsExtension = 1*/
	BEGIN TRANSACTION
	IF (@Provider = 3) --更新
	BEGIN			
		UPDATE PhotoReply SET 
	[Content] = @Content,[IP] = @IP,[UserID] = @UserID,[PhotoID] = @PhotoID,[IsCheck] = @IsCheck,[IsDelete] = @IsDelete,[UpdateDate] = @UpdateDate
	WHERE ID=@ID 
		IF @@error <> 0
		BEGIN			
			ROLLBACK TRANSACTION
			return -100
		END

	END
	ELSE IF (@Provider = 2)--插入
	BEGIN
		INSERT INTO PhotoReply(
	[Content],[AddDate],[IP],[UserID],[PhotoID],[IsCheck],[IsDelete],[UpdateDate]
	)VALUES(
	@Content,@AddDate,@IP,@UserID,@PhotoID,@IsCheck,@IsDelete,@UpdateDate
	)
		IF @@error <> 0
		BEGIN
			ROLLBACK TRANSACTION			
			return -200
		END
		SELECT @ID = @@IDENTITY	
	END

	COMMIT TRANSACTION
	RETURN 0 
    SET NOCOUNT OFF;
END
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO


------------------------------------
--用途：得到实体对象的详细信息 
--项目名称：CodematicDemo
--说明：
--时间：2008-7-9 9:24:36
------------------------------------
CREATE PROCEDURE PhotoReply_SelectByID
@ID int
 AS 
	SELECT 
	ID,Content,AddDate,IP,UserID,PhotoID,IsCheck,IsDelete,UpdateDate
	 FROM PhotoReply
	 WHERE ID=@ID
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO


-- =============================================
-- Author:		
-- Create date: 080708
-- Description:	添加修改
--				
-- Return：		-300，重复；0,成功；-100,返回更新错误；-200，插入错误；
-- ReturnValue：@lD
-- =============================================
CREATE PROCEDURE [dbo].[Photo_InsertUpdate]
(
@ID int output,
@Summary nvarchar(1000),
@AddDate datetime,
@TotalHits int,
@BigPic nvarchar(200),
@SmallPic nvarchar(200),
@AlbumID int,
@IsCheck bit,
@IsDelete bit,
@IsCommon int,
@Provider int
)
AS
DECLARE @vIsExtension INT
BEGIN	
	SET NOCOUNT ON;		
	IF (@AddDate IS NULL)
		SELECT @AddDate=GETDATE()
	/*IF (LEN(@pExtension) > 0)
		SELECT @vIsExtension = 1*/
	BEGIN TRANSACTION
	IF (@Provider = 3) --更新
	BEGIN			
		UPDATE Photo SET 
	[Summary] = @Summary,[AddDate] = @AddDate,[TotalHits] = @TotalHits,[BigPic] = @BigPic,[SmallPic] = @SmallPic,[AlbumID] = @AlbumID,[IsCheck] = @IsCheck,[IsDelete] = @IsDelete,[IsCommon] = @IsCommon
	WHERE ID=@ID 
		IF @@error <> 0
		BEGIN			
			ROLLBACK TRANSACTION
			return -100
		END

	END
	ELSE IF (@Provider = 2)--插入
	BEGIN
		INSERT INTO Photo(
	[Summary],[AddDate],[TotalHits],[BigPic],[SmallPic],[AlbumID],[IsCheck],[IsDelete],[IsCommon]
	)VALUES(
	@Summary,@AddDate,@TotalHits,@BigPic,@SmallPic,@AlbumID,@IsCheck,@IsDelete,@IsCommon
	)
		IF @@error <> 0
		BEGIN
			ROLLBACK TRANSACTION			
			return -200
		END
		SELECT @ID = @@IDENTITY	
	END

	COMMIT TRANSACTION
	RETURN 0 
    SET NOCOUNT OFF;
END
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO


------------------------------------
--用途：得到实体对象的详细信息 
--项目名称：CodematicDemo
--说明：
--时间：2008-7-9 9:24:36
------------------------------------
CREATE PROCEDURE Photo_SelectByID
@ID int
 AS 
	SELECT 
	ID,Summary,AddDate,TotalHits,BigPic,SmallPic,AlbumID,IsCheck,IsDelete,IsCommon
	 FROM Photo
	 WHERE ID=@ID
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO


-- =============================================
-- Author:		
-- Create date: 080708
-- Description:	添加修改
--				
-- Return：		-300，重复；0,成功；-100,返回更新错误；-200，插入错误；
-- ReturnValue：@lD
-- =============================================
CREATE PROCEDURE [dbo].[Tags_InsertUpdate]
(
@ID int,
@TagName nvarchar(50),
@AreaCode nvarchar(50),
@InfoID int,
@Flag bit,
@Provider int
)
AS
DECLARE @vIsExtension INT
BEGIN	
	SET NOCOUNT ON;		
	/*IF (LEN(@pExtension) > 0)
		SELECT @vIsExtension = 1*/
	BEGIN TRANSACTION
	IF (@Provider = 3) --更新
	BEGIN			
		UPDATE Tags SET 
	[TagName] = @TagName,[AreaCode] = @AreaCode,[InfoID] = @InfoID,[Flag] = @Flag
	WHERE ID=@ID 
		IF @@error <> 0
		BEGIN			
			ROLLBACK TRANSACTION
			return -100
		END

	END
	ELSE IF (@Provider = 2)--插入
	BEGIN
		INSERT INTO Tags(
	[TagName],[AreaCode],[InfoID],[Flag]
	)VALUES(
	@TagName,@AreaCode,@InfoID,@Flag
	)
		IF @@error <> 0
		BEGIN
			ROLLBACK TRANSACTION			
			return -200
		END
                          SELECT @ID = @@IDENTITY	
	END

	COMMIT TRANSACTION
	RETURN 0 
    SET NOCOUNT OFF;
END
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO


------------------------------------
--用途：得到实体对象的详细信息 
--项目名称：CodematicDemo
--说明：
--时间：2008-7-9 9:24:36
------------------------------------
CREATE PROCEDURE Tags_SelectByID
@ID int
 AS 
	SELECT 
	ID,TagName,AreaCode,InfoID,Flag,IsDelete
	 FROM Tags
	 WHERE ID=@ID
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO


-- =============================================
-- Author:		
-- Create date: 080708
-- Description:	添加修改
--				
-- Return：		-300，重复；0,成功；-100,返回更新错误；-200，插入错误；
-- ReturnValue：@lD
-- =============================================
CREATE PROCEDURE [dbo].[Users_InsertUpdate]
(
@ID int output,
@Nick nvarchar(50),
@Email nvarchar(200),
@Pwd nvarchar(100),
@DomainName nvarchar(20),
@AreaCode nvarchar(50),
@RegDate datetime,
@Sex bit,
@Birthday datetime,
@Brief nvarchar(500),
@Pic nvarchar(200),
@Blog nvarchar(50),
@LoginTimes int,
@LastDate datetime,
@LastIP nvarchar(50),
@VisitTimes int,
@IsForbid bit,
@LoginStatus int,
@Provider int
)
AS
DECLARE @vIsExtension INT
BEGIN	
	SET NOCOUNT ON;		
	IF (@RegDate IS NULL)
		SELECT @RegDate=GETDATE()
	IF (@LastDate IS NULL)
		SELECT @LastDate=GETDATE()
	/*IF (LEN(@pExtension) > 0)
		SELECT @vIsExtension = 1*/
	BEGIN TRANSACTION
	IF (@Provider = 3) --更新
	BEGIN			
		UPDATE Users SET 
	[Nick] = @Nick,[Email] = @Email,[Pwd] = @Pwd,[DomainName] = @DomainName,[AreaCode] = @AreaCode,[Sex] = @Sex,[Birthday] = @Birthday,[Brief] = @Brief,[Pic] = @Pic,[Blog] = @Blog,[LoginTimes] = @LoginTimes,[LastDate] = @LastDate,[LastIP] = @LastIP,[VisitTimes] = @VisitTimes,[IsForbid] = @IsForbid,[LoginStatus] = @LoginStatus
	WHERE ID=@ID 
		IF @@error <> 0
		BEGIN			
			ROLLBACK TRANSACTION
			return -100
		END

	END
	ELSE IF (@Provider = 2)--插入
	BEGIN
		INSERT INTO Users(
	[Nick],[Email],[Pwd],[DomainName],[AreaCode],[RegDate],[Sex],[Birthday],[Brief],[Pic],[Blog],[LoginTimes],[LastDate],[LastIP],[VisitTimes],[IsForbid],[LoginStatus]
	)VALUES(
	@Nick,@Email,@Pwd,@DomainName,@AreaCode,@RegDate,@Sex,@Birthday,@Brief,@Pic,@Blog,@LoginTimes,@LastDate,@LastIP,@VisitTimes,@IsForbid,@LoginStatus
	)
		IF @@error <> 0
		BEGIN
			ROLLBACK TRANSACTION			
			return -200
		END
		SELECT @ID = @@IDENTITY	
	END

	COMMIT TRANSACTION
	RETURN 0 
    SET NOCOUNT OFF;
END
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO


------------------------------------
--用途：得到实体对象的详细信息 
--项目名称：CodematicDemo
--说明：
--时间：2008-7-9 9:24:36
------------------------------------
CREATE PROCEDURE Users_SelectByID
@ID int
 AS 
	SELECT 
	ID,Nick,Email,Pwd,DomainName,AreaCode,RegDate,Sex,Birthday,Brief,Pic,Blog,LoginTimes,LastDate,LastIP,VisitTimes,IsForbid,LoginStatus,IsDelete
	 FROM Users
	 WHERE ID=@ID
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

